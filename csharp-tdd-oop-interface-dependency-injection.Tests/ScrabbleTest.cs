using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {

        private Scrabble _scrabbleEnglish;
        private Scrabble _scrabbleGreek;
        private Scrabble _scrabbleRussian;

        [SetUp]
        public void SetUp()
        {
            IAlphabet english = new EnglishAlphabet();
            IAlphabet greek = new GreekAlphabet();
            IAlphabet russian = new RussianAlphabet();
            _scrabbleEnglish = new Scrabble(english);
            _scrabbleGreek = new Scrabble(greek);
            _scrabbleRussian = new Scrabble(russian);
        }
        [Test]
        public void shouldGive0ForEmptyWords() {

            Assert.AreEqual(0, _scrabbleEnglish.score(""));
            Assert.AreEqual(0, _scrabbleGreek.score(""));
            Assert.AreEqual(0, _scrabbleRussian.score(""));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
           
            Assert.AreEqual(0, _scrabbleEnglish.score("\n\r\t\b\f"));
            Assert.AreEqual(0, _scrabbleRussian.score("\n\r\t\b\f"));
            Assert.AreEqual(0, _scrabbleGreek.score("\n\r\t\b\f"));
        }

        [Test]
        public void shouldScore1ForA() {
           
            Assert.AreEqual(1, _scrabbleEnglish.score("a"));
            Assert.AreEqual(1, _scrabbleGreek.score("α"));
            Assert.AreEqual(1, _scrabbleRussian.score("а"));
        }

        [Test]
        public void shouldScore4ForF() {
        
            Assert.AreEqual(4, _scrabbleEnglish.score("f"));
            Assert.AreEqual(4, _scrabbleGreek.score("κ"));
            Assert.AreEqual(4, _scrabbleRussian.score("о"));
        }

        [Test]
        public void shouldScore6ForStreet() {
      
            Assert.AreEqual(6, _scrabbleEnglish.score("street"));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            Assert.AreEqual(22, _scrabbleEnglish.score("quirky"));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            Assert.AreEqual(18, _scrabbleRussian.score("дврфъ"));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            Assert.AreEqual(20, _scrabbleGreek.score("φεψωλ"));
        }
    }
}