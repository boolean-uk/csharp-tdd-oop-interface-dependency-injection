using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            Alphabet Eng = new EnglishaAlphabet(); 
            Scrabble scrabble = new Scrabble(Eng);
            Assert.AreEqual(0, scrabble.score(""));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            Alphabet Eng = new EnglishaAlphabet();
            Scrabble scrabble = new Scrabble(Eng);
            Assert.AreEqual(0, scrabble.score("\n\r\t\b\f"));
        }

        [Test]
        public void shouldScore1ForA() {
            Alphabet Eng = new EnglishaAlphabet();
            Scrabble scrabble = new Scrabble(Eng);
            Assert.AreEqual(1, scrabble.score("a"));
        }

        [Test]
        public void shouldScore4ForF() {
            Alphabet Eng = new EnglishaAlphabet();
            Scrabble scrabble = new Scrabble(Eng);
            Assert.AreEqual(4, scrabble.score("f"));
        }

        [Test]
        public void shouldScore6ForStreet() {
            Alphabet Eng = new EnglishaAlphabet();
            Scrabble scrabble = new Scrabble(Eng);
            Assert.AreEqual(6, scrabble.score("street"));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            Alphabet Eng = new EnglishaAlphabet();
            Scrabble scrabble = new Scrabble(Eng);
            Assert.AreEqual(22, scrabble.score("quirky"));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            Alphabet Rus = new RussianAlphabet();
            Scrabble scrabble = new Scrabble(Rus);
            Assert.AreEqual(18, scrabble.score("дврфъ"));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            Alphabet Gre = new GreekAlphabet();
            Scrabble scrabble = new Scrabble(Gre);
            Assert.AreEqual(20, scrabble.score("φεψωλ"));
        }
    }
}