using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;
using tdd_oop_interface_dependency_injection.CSharp.Main.Alphabets;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            EnglishAlphabet english = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(scrabble.score(""), Is.EqualTo(0));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            EnglishAlphabet english = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(scrabble.score("\n\r\t\b\f"), Is.EqualTo(0));
        }

        [Test]
        public void shouldScore1ForA() {
            EnglishAlphabet english = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(scrabble.score("a"), Is.EqualTo(1));
        }

        [Test]
        public void shouldScore4ForF() {
            EnglishAlphabet english = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(scrabble.score("f"), Is.EqualTo(4));
        }

        [Test]
        public void shouldScore6ForStreet() {
            EnglishAlphabet english = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(scrabble.score("street"), Is.EqualTo(6));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            EnglishAlphabet english = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(scrabble.score("quirky"), Is.EqualTo(22));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            RussianAlphabet russian = new RussianAlphabet();
            Scrabble scrabble = new Scrabble(russian);
            Assert.That(scrabble.score("дврфъ"), Is.EqualTo(18));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            GreekAlphabet greek = new GreekAlphabet();
            Scrabble scrabble = new Scrabble(greek);
            Assert.That(scrabble.score("φεψωλ"), Is.EqualTo(20));
        }
        [Test]
        public void shouldScore0GreekLetters()
        {
            GreekAlphabet greek = new GreekAlphabet();
            Scrabble scrabble = new Scrabble(greek);
            Assert.That(scrabble.score(""), Is.EqualTo(0));
        }
    }
}