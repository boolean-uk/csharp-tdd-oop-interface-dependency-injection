using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() 
        { IScoreOfLetters letterscore = new EnglishScore();
            Scrabble scrabble = new Scrabble(letterscore);
            Assert.That(0, Is.EqualTo(scrabble.score("")));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            IScoreOfLetters letterscore = new EnglishScore();
            Scrabble scrabble = new Scrabble(letterscore);
            Assert.That(0, Is.EqualTo(scrabble.score("\n\r\t\b\f")));
        }

        [Test]
        public void shouldScore1ForA() {
            IScoreOfLetters letterscore = new EnglishScore();
            Scrabble scrabble = new Scrabble(letterscore);
            Assert.That(1, Is.EqualTo(scrabble.score("a")));
        }

        [Test]
        public void shouldScore4ForF() {
            IScoreOfLetters letterscore = new EnglishScore();
            Scrabble scrabble = new Scrabble(letterscore);
            Assert.That(4, Is.EqualTo(scrabble.score("f")));
        }

        [Test]
        public void shouldScore6ForStreet() {
            IScoreOfLetters letterscore = new EnglishScore();
            Scrabble scrabble = new Scrabble(letterscore);
            Assert.That(6, Is.EqualTo(scrabble.score("street")));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            IScoreOfLetters letterscore = new EnglishScore();
            Scrabble scrabble = new Scrabble(letterscore);
            Assert.That(22, Is.EqualTo(scrabble.score("quirky")));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            IScoreOfLetters letterscore = new RussianScore();
            Scrabble scrabble = new Scrabble(letterscore);
            Assert.That(18, Is.EqualTo(scrabble.score("дврфъ")));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            IScoreOfLetters letterscore = new GreekScore();
            Scrabble scrabble = new Scrabble(letterscore); ;
            Assert.That(20, Is.EqualTo(scrabble.score("φεψωλ")));
        }
    }
}