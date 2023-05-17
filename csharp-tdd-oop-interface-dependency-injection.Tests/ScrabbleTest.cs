using Alphabet;
using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            IAlphabet russia = new RussiaAlphabet();
            Scrabble scrabble = new Scrabble(russia);
            Assert.AreEqual(0, scrabble.score(""));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            IAlphabet english = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(english);
            Assert.AreEqual(0, scrabble.score("\n\r\t\b\f"));
        }

        [Test]
        public void shouldScore1ForA() {
            IAlphabet english = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(english);
            Assert.AreEqual(1, scrabble.score("a"));
        }

        [Test]
        public void shouldScore4ForF() {
            IAlphabet english = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(english);
            Assert.AreEqual(4, scrabble.score("f"));
        }

        [Test]
        public void shouldScore6ForStreet() {
            IAlphabet english = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(english);
            Assert.AreEqual(6, scrabble.score("street"));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            IAlphabet english = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(english);
            Assert.AreEqual(22, scrabble.score("quirky"));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            IAlphabet russia = new RussiaAlphabet();
            Scrabble scrabble = new Scrabble(russia);
            Assert.AreEqual(18, scrabble.score("дврфъ"));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            IAlphabet greek = new GreekAlphabet();
            Scrabble scrabble = new Scrabble(greek) ;
            Assert.AreEqual(20, scrabble.score("φεψωλ"));
        }
    }
}