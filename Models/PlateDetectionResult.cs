namespace Pilak.Models
{
    public class PlateDetectionResult
    {
        public required string plateImage { get; set; }
        public required string plateContentImage { get; set; }
        public required string firstDigitSection { get; set; }
        public required string letterSection { get; set; }
        public required string secondDigitSection { get; set; }
        public required string cityCode { get; set; }
    }
}
