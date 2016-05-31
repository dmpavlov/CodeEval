namespace Domain
{
    public class PangramsAnalyzer
    {
        private readonly Alphabet alphabet = new Alphabet();

        public string FindMissingLetters(string sentense)
        {
            if (IsEmpty(sentense))
            {
                return alphabet.ToString();
            }

            foreach (var letter in sentense)
            {
                alphabet.MarkAsFound(letter);
            }

            return alphabet.PrintNotFoundLetters();
        }

        private static bool IsEmpty(string sentense)
        {
            return string.IsNullOrEmpty(sentense);
        }
    }
}