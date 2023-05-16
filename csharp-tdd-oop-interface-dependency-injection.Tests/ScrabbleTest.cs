using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main.Alphabets;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            Scrabble scrabble = new Scrabble(new English());
            Assert.AreEqual(0, scrabble.score(""));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            Scrabble scrabble = new Scrabble(new English());
            Assert.AreEqual(0, scrabble.score("\n\r\t\b\f"));
        }

        [Test]
        public void shouldScore1ForA() {
            Scrabble scrabble = new Scrabble(new English());
            Assert.AreEqual(1, scrabble.score("a"));
        }

        [Test]
        public void shouldScore4ForF() {
            Scrabble scrabble = new Scrabble(new English());
            Assert.AreEqual(4, scrabble.score("f"));
        }

        [Test]
        public void shouldScore6ForStreet() {
            Scrabble scrabble = new Scrabble(new English());
            Assert.AreEqual(6, scrabble.score("street"));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            Scrabble scrabble = new Scrabble(new English());
            Assert.AreEqual(22, scrabble.score("quirky"));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            Scrabble scrabble = new Scrabble(new Russian());
            Assert.AreEqual(17, scrabble.score("ягода"));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            Scrabble scrabble = new Scrabble(new Greek());
            Assert.AreEqual(14, scrabble.score("τέχνη"));
        }
    }
}