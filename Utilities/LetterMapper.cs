namespace Pilak.Utilities
{
    public class LetterMapper
    {
        private static readonly Dictionary<string, string> LetterToCode = new Dictionary<string, string>()
        {
            { "الف", "ALEF" },
            { "ب", "BE" },
            { "پ", "PE" },
            { "ت", "TE" },
            { "ث", "SE" },
            { "ج", "JIM" },
            { "چ", "CHE" },
            { "ح", "HE" },
            { "خ", "KHE" },
            { "د", "DAL" },
            { "ذ", "ZAL" },
            { "ر", "RE" },
            { "ز", "ZE" },
            { "ژ", "ZHE" },
            { "س", "SIN" },
            { "ش", "SHIN" },
            { "ص", "SAD" },
            { "ض", "ZAD" },
            { "ط", "TA" },
            { "ظ", "ZA" },
            { "ع", "AEN" },
            { "غ", "GHAIN" },
            { "ف", "FE" },
            { "ق", "QAF" },
            { "ک", "KAF" },
            { "گ", "GAF" },
            { "ل", "LAM" },
            { "م", "MIM" },
            { "ن", "NUN" },
            { "و", "VAV" },
            { "ه", "HE" },
            { "ی", "YE" },
        };
        private static readonly Dictionary<string, string> CodeToLetter = new Dictionary<string, string>();

        static LetterMapper()
        {
            foreach (var pair in LetterToCode)
            {
                CodeToLetter[pair.Value] = pair.Key;
            }
        }

        public static string GetCode(string letter)
        {
            return LetterToCode.TryGetValue(letter, out var code) ? code : "Code not found";
        }

        public static string? GetLetter(string code)
        {
            return CodeToLetter.TryGetValue(code, out var letter) ? letter : "Character not found";
        }
    }
}
