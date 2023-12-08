using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            Scrabble scrabble = new Scrabble(new EnglishAlphabet());
            //Assert.AreEqual(0, scrabble.score(""));
            Assert.That(scrabble.score(""), Is.EqualTo(0));
        }

        [Test]
        public void shouldGive0ForWhiteSpace()
        {
            Scrabble scrabble = new Scrabble(new EnglishAlphabet());
            //Assert.AreEqual(0, scrabble.score("\n\r\t\b\f"));
            Assert.That(scrabble.score("\n\r\t\b\f"), Is.EqualTo(0));
        }

        [Test]
        public void shouldScore1ForA()
        {
            Scrabble scrabble = new Scrabble(new EnglishAlphabet());
            //Assert.AreEqual(1, scrabble.score("a"));
            Assert.That(scrabble.score("a"), Is.EqualTo(1));
        }

        [Test]
        public void shouldScore4ForF()
        {
            Scrabble scrabble = new Scrabble(new EnglishAlphabet());
            //Assert.AreEqual(4, scrabble.score("f"));
            Assert.That(scrabble.score("f"), Is.EqualTo(4));
        }

        [Test]
        public void shouldScore6ForStreet()
        {
            Scrabble scrabble = new Scrabble(new EnglishAlphabet());
            //Assert.AreEqual(6, scrabble.score("street"));
            Assert.That(scrabble.score("street"), Is.EqualTo(6));
        }

        [Test]
        public void shouldScore22ForQuirky()
        {
            Scrabble scrabble = new Scrabble(new EnglishAlphabet());
            //Assert.AreEqual(22, scrabble.score("quirky"));
            Assert.That(scrabble.score("quirky"), Is.EqualTo(22));
        }

        [Test]
        public void shouldScoreRussianLetters()
        {
            Scrabble scrabble = new Scrabble(new RussianAlphabet());
            //Assert.AreEqual(18, scrabble.score("дврфъ"));
            Assert.That(scrabble.score("дврфъ"), Is.EqualTo(18));
        }

        [Test]
        public void shouldScoreGreekLetters()
        {
            Scrabble scrabble = new Scrabble(new GreekAlphabet());
            //Assert.AreEqual(20, scrabble.score("φεψωλ"));
            Assert.That(scrabble.score("φεψωλ"), Is.EqualTo(20));
        }
    }
}