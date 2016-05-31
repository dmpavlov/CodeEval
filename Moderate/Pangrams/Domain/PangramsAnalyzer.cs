namespace Domain
{
    public class PangramsAnalyzer
    {
        private readonly Alpabet alphabet = new Alpabet();

        public string FindMissingLetters(string sentense)
        {
            if (string.IsNullOrEmpty(sentense))
            {
                return alphabet.ToString();
            }

            foreach (var letter in sentense)
            {
                alphabet.MarkAsFound(letter);
            }

            return alphabet.PrintNotFoundLetters();
        }
    }
}