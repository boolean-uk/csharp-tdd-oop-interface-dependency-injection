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
            IAlphabet alphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(0, scrabble.Score(""));
        }

        [Test]
        public void ShouldGive0ForWhiteSpace()
        {
            IAlphabet alphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(0, scrabble.Score("\n\r\t\b\f"));
        }

        [Test]
        public void ShouldScore1ForA()
        {
            IAlphabet alphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(1, scrabble.Score("a"));
        }

        [Test]
        public void ShouldScore4ForF()
        {
            IAlphabet alphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(4, scrabble.Score("f"));
        }

        [Test]
        public void ShouldScore6ForStreet()
        {
            IAlphabet alphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(6, scrabble.Score("street"));
        }

        [Test]
        public void ShouldScore22ForQuirky()
        {
            IAlphabet alphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.AreEqual(22, scrabble.Score("quirky"));
        }

        [Test]
        public void ShouldScoreRussianLetters()
        {            
            IAlphabet russianAlphabet = new RussianAlphabet(); 
            Scrabble scrabble = new Scrabble(russianAlphabet); 
            Assert.AreEqual(18, scrabble.Score("дврфъ"));
        }

        [Test]
        public void shouldScoreGreekLetters()
        {
            IAlphabet greekAlphabet = new GreekAlphabet(); 
            Scrabble scrabble = new Scrabble(greekAlphabet); 
            Assert.AreEqual(20, scrabble.Score("φεψωλ"));
        }
    }
}