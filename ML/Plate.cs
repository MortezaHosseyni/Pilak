using Microsoft.ML;
using Microsoft.ML.Data;

namespace Pilak.ML
{
    public class Plate
    {
        private readonly MLContext _mlContext;
        private readonly ITransformer _model;
        private const int ImageWidth = 224; private const int ImageHeight = 224; private const string InputColumnName = "images"; private const string OutputColumnName = "output0";
        public Plate(string modelPath)
        {
            _mlContext = new MLContext();

            var pipeline = _mlContext.Transforms.ApplyOnnxModel(
                modelFile: modelPath,
                outputColumnNames: new[] { OutputColumnName },
                inputColumnNames: new[] { InputColumnName });

            _model = pipeline.Fit(_mlContext.Data.LoadFromEnumerable(new List<CarPlateInput>()));
        }

        public class CarPlateInput
        {
            [ColumnName(InputColumnName)]
            public float[] Image { get; set; }
        }

        public class CarPlateOutput
        {
            [ColumnName(OutputColumnName)]
            public float[] Predictions { get; set; }
        }

        private float[] PreprocessImage(string imagePath)
        {
            using (var bitmap = new Bitmap(Image.FromFile(imagePath)))
            {
                var resizedBitmap = new Bitmap(bitmap, new Size(ImageWidth, ImageHeight));

                var imageData = new List<float>();

                for (int y = 0; y < resizedBitmap.Height; y++)
                {
                    for (int x = 0; x < resizedBitmap.Width; x++)
                    {
                        var color = resizedBitmap.GetPixel(x, y);

                        imageData.Add(color.R / 255f);
                        imageData.Add(color.G / 255f);
                        imageData.Add(color.B / 255f);
                    }
                }

                if (imageData.Count != ImageWidth * ImageHeight * 3)
                {
                    throw new InvalidOperationException("Image data size does not match expected input dimensions.");
                }

                return imageData.ToArray();
            }
        }

        public List<float[]> Predict(string imagePath)
        {
            var image = PreprocessImage(imagePath);
            var inputData = new List<CarPlateInput> { new CarPlateInput { Image = image } };

            var dataView = _mlContext.Data.LoadFromEnumerable(inputData);

            var transformedData = _model.Transform(dataView);
            var predictions = _mlContext.Data.CreateEnumerable<CarPlateOutput>(transformedData, reuseRowObject: false);

            var results = new List<float[]>();
            foreach (var prediction in predictions)
            {
                results.Add(prediction.Predictions);
            }
            return results;
        }
    }
}
