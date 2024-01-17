using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{
    [TestFixture]
    public class ScrabbleTest
    {
        [Test]
        public void shouldGive0ForEmptyWords()
        {
            Scrabble scrabble = new Scrabble(new Alphabet());
            Assert.AreEqual(0 , scrabble.Score(""));
        }

        [Test]
        public void shouldGive0ForWhiteSpace()
        {
            Scrabble scrabble = new Scrabble(new Alphabet());
            Assert.AreEqual(0 , scrabble.Score("\n\r\t\b\f"));
        }

        [Test]
        public void shouldScore1ForA()
        {
            Scrabble scrabble = new Scrabble(new Alphabet());
            Assert.AreEqual(1 , scrabble.Score("a"));
        }

        [Test]
        public void shouldScore4ForF()
        {
            Scrabble scrabble = new Scrabble(new Alphabet());
            Assert.AreEqual(4 , scrabble.Score("f"));
        }

        [Test]
        public void shouldScore6ForStreet()
        {
            Scrabble scrabble = new Scrabble(new Alphabet());
            Assert.AreEqual(6 , scrabble.Score("street"));
        }

        [Test]
        public void shouldScore22ForQuirky()
        {
            Scrabble scrabble = new Scrabble(new Alphabet());
            Assert.AreEqual(22 , scrabble.Score("quirky"));
        }

        [Test]
        public void shouldScoreRussianLetters()
        {
            Scrabble scrabble = new Scrabble(new RussianAlphabet());
            Assert.AreEqual(18 , scrabble.Score("дврфъ"));
        }

        [Test]
        public void shouldScoreGreekLetters()
        {
            Scrabble scrabble = new Scrabble(new GreekAlphabet());
            Assert.AreEqual(20 , scrabble.Score("φεψωλ"));
        }
    }
}
