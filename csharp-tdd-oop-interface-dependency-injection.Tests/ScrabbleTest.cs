using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() 
        {
            ILetterScoresProvider letterScoresProvider = new GreekLetterScoresProvider();
            Scrabble scrabble = new Scrabble(letterScoresProvider);
            Assert.That(0, Is.EqualTo(scrabble.Score("")));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            ILetterScoresProvider letterScoresProvider = new EnglishLetterScoresProvider();
            Scrabble scrabble = new Scrabble(letterScoresProvider);
            Assert.That(0, Is.EqualTo(scrabble.Score("\n\r\t\b\f")));
        }

        [Test]
        public void shouldScore1ForA() {
            ILetterScoresProvider letterScoresProvider = new EnglishLetterScoresProvider();
            Scrabble scrabble = new Scrabble(letterScoresProvider);
            Assert.That(1, Is.EqualTo(scrabble.Score("a")));
        }

        [Test]
        public void shouldScore4ForF() {
            ILetterScoresProvider letterScoresProvider = new EnglishLetterScoresProvider();
            Scrabble scrabble = new Scrabble(letterScoresProvider);
            Assert.That(4, Is.EqualTo(scrabble.Score("f")));
        }

        [Test]
        public void shouldScore6ForStreet() {
            ILetterScoresProvider letterScoresProvider = new EnglishLetterScoresProvider();
            Scrabble scrabble = new Scrabble(letterScoresProvider);
            Assert.That(6, Is.EqualTo(scrabble.Score("street")));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            ILetterScoresProvider letterScoresProvider = new EnglishLetterScoresProvider();
            Scrabble scrabble = new Scrabble(letterScoresProvider);
            Assert.That(22, Is.EqualTo(scrabble.Score("quirky")));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            ILetterScoresProvider letterScoresProvider = new RussianLetterScoresProvider();
            Scrabble scrabble = new Scrabble(letterScoresProvider);
            Assert.That(18, Is.EqualTo(scrabble.Score("дврфъ")));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            ILetterScoresProvider letterScoresProvider = new GreekLetterScoresProvider();
            Scrabble scrabble = new Scrabble(letterScoresProvider);
            Assert.That(20, Is.EqualTo(scrabble.Score("φεψωλ")));
        }
    }
}