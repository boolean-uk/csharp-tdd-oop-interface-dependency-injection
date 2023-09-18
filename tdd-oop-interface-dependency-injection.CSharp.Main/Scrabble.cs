namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble
    {
        private Dictionary<Char, int> letterScores;

        public Scrabble(IScoreOfTheLetters letterScoresProvider)
        {
            this.letterScores = letterScoresProvider.GetLetterScores();
        }

        public int score(String word)
        {
            if (word == null)
            {
                return 0;
            }

            int total = 0;

            foreach (char ch in word.ToLower().ToCharArray()) // case insentivity
            {
                if (char.IsLetter(ch) && this.letterScores.ContainsKey(ch)) // check if char s a letter
                {
                    int score = this.letterScores[ch];
                    total += score;
                }
            }
            return total;
        }
    }
}
