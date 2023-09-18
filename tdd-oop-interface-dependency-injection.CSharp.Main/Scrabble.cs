namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble
    {
        Dictionary<char, int> letterScores;
        /* private List<IScrabbleScoreTable> _letterScores = new List<IScrabbleScoreTable>();*/

        /* public void CountScore(IScrabbleScoreTable letterScores)
         {
             _letter = letterScores.getLetterScores();
         }*/

        /* public List<IScrabbleScoreTable> GetScore { get { return _letterScores; } }
         public int ScoreTotal { get { return _letterScores.Sum(x =>*/


        public Scrabble(IScrabbleScoreTable a)
        {
            this.letterScores = a.getLetterScores();
        }

        public int score(String word)
        {
            int total = 0;

            foreach (char ch in word.ToCharArray())
            {
                if (this.letterScores.ContainsKey(ch))
                {
                    int score = this.letterScores[ch];
                    total += score;
                }
            }

            return total;
        }

    }

}
