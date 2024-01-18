namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble
    {
        private Dictionary<Char, int> _letterScores;
        private IAlphabet _alphabet;
        public Scrabble(IAlphabet alphabet)
        {
            this._alphabet = alphabet;
            this._letterScores = alphabet.GetLetterScores();
        }

        public int score(String word)
        {
            int total = 0;

            foreach (char ch in word.ToCharArray())
            {
                if (this._letterScores.ContainsKey(ch))
                {
                    int score = this._letterScores[ch];
                    total += score;
                }
            }

            return total;
        }
    }
}
