using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{
    [TestFixture]
    public class ScrabbleTest
    {
        [Test]
        public void ShouldGive0ForEmptyWords()
        {
            ILetterScoresProvider letterScoresProvider = new Alphabet();
            Scrabble scrabble = new Scrabble(letterScoresProvider);

            Assert.That(0, Is.EqualTo(scrabble.Score("")));
        }

        [Test]
        public void ShouldGive0ForWhiteSpace()
        {
            ILetterScoresProvider letterScoresProvider = new Alphabet();
            Scrabble scrabble = new Scrabble(letterScoresProvider);

            Assert.That(0, Is.EqualTo(scrabble.Score("\n\r\t\b\f")));
        }

        [Test]
        public void ShouldScore1ForA()
        {
            ILetterScoresProvider letterScoresProvider = new Alphabet();
            Scrabble scrabble = new Scrabble(letterScoresProvider);

            Assert.That(1, Is.EqualTo(scrabble.Score("a")));
        }

        [Test]
        public void ShouldScore4ForF()
        {
            ILetterScoresProvider letterScoresProvider = new Alphabet();
            Scrabble scrabble = new Scrabble(letterScoresProvider);

            Assert.That(4, Is.EqualTo(scrabble.Score("f")));
        }

        [Test]
        public void ShouldScore6ForStreet()
        {
            ILetterScoresProvider letterScoresProvider = new Alphabet();
            Scrabble scrabble = new Scrabble(letterScoresProvider);

            Assert.That(6, Is.EqualTo(scrabble.Score("street")));
        }

        [Test]
        public void ShouldScore22ForQuirky()
        {
            ILetterScoresProvider letterScoresProvider = new Alphabet();
            Scrabble scrabble = new Scrabble(letterScoresProvider);

            Assert.That(22, Is.EqualTo(scrabble.Score("quirky")));
        }

        [Test]
        public void ShouldScoreRussianLetters()
        {
            ILetterScoresProvider letterScoresProvider = new RussianLetterScoresProvider(); // Replace with a Russian letter scores provider
            Scrabble scrabble = new Scrabble(letterScoresProvider);

            Assert.That(18, Is.EqualTo(scrabble.Score("дврфъ")));
        }

        [Test]
        public void ShouldScoreGreekLetters()
        {
            ILetterScoresProvider letterScoresProvider = new GreekLetterScoresProvider(); // Replace with a Greek letter scores provider
            Scrabble scrabble = new Scrabble(letterScoresProvider);

            Assert.That(20, Is.EqualTo(scrabble.Score("φεψωλ")));
        }
    }
}
