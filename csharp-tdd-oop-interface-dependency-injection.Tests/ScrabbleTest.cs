using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            Alphabet alphabet = new Alphabet();
            Scrabble scrabble = new Scrabble(alphabet,"Greek");
            Assert.AreEqual(0, scrabble.score(""));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            Alphabet alphabet = new Alphabet();
            Scrabble scrabble = new Scrabble(alphabet, "Greek");
            Assert.AreEqual(0, scrabble.score("\n\r\t\b\f"));
        }

        [Test]
        public void shouldScore1ForA() {
            Alphabet alphabet = new Alphabet();
            Scrabble scrabble = new Scrabble(alphabet, "English");
            Assert.AreEqual(1, scrabble.score("a"));
        }

        [Test]
        public void shouldScore4ForF() {
            Alphabet alphabet = new Alphabet();
            Scrabble scrabble = new Scrabble(alphabet, "English");
            Assert.AreEqual(4, scrabble.score("f"));
        }

        [Test]
        public void shouldScore6ForStreet() {
            Alphabet alphabet = new Alphabet();
            Scrabble scrabble = new Scrabble(alphabet, "English");
            Assert.AreEqual(6, scrabble.score("street"));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            Alphabet alphabet = new Alphabet();
            Scrabble scrabble = new Scrabble(alphabet, "English");
            Assert.AreEqual(22, scrabble.score("quirky"));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            Alphabet alphabet = new Alphabet();
            Scrabble scrabble = new Scrabble(alphabet, "Russian");
            Assert.AreEqual(18, scrabble.score("дврфъ"));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            Alphabet alphabet = new Alphabet();
            Scrabble scrabble = new Scrabble(alphabet, "Greek");
            Assert.AreEqual(20, scrabble.score("φεψωλ"));
        }
    }
}