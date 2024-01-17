using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        
        private IAlphabet english;
        private IAlphabet greek;
        private IAlphabet russia;
        private Scrabble scrabble;
    
        [SetUp] 
        public void SetUp() {
            english = new EnglishAlphabet();
            greek = new GreekAlphabet();
            russia = new RussianAlphabet();
        }

        [Test]
        public void shouldGive0ForEmptyWords() {
            scrabble = new Scrabble(english);
            Assert.AreEqual(0, scrabble.score(""));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            scrabble = new Scrabble(english);
            Assert.AreEqual(0, scrabble.score("\n\r\t\b\f"));
        }

        [Test]
        public void shouldScore1ForA() {
            scrabble = new Scrabble(english);
            Assert.AreEqual(1, scrabble.score("a"));
        }

        [Test]
        public void shouldScore4ForF() {
            scrabble = new Scrabble(english);
            Assert.AreEqual(4, scrabble.score("f"));
        }

        [Test]
        public void shouldScore6ForStreet() {
            scrabble = new Scrabble(english);
            Assert.AreEqual(6, scrabble.score("street"));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            scrabble = new Scrabble(english);
            Assert.AreEqual(22, scrabble.score("quirky"));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            scrabble = new Scrabble(russia);
            Assert.AreEqual(18, scrabble.score("дврфъ"));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            Scrabble scrabble = new Scrabble(greek);
            Assert.AreEqual(20, scrabble.score("φεψωλ"));
        }
    }
}