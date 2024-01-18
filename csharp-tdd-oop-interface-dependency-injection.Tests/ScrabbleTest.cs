using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {

            englishAlphabet e = new englishAlphabet();
            Scrabble scrabble = new Scrabble(e);
            Assert.AreEqual(0, scrabble.score(""));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            englishAlphabet e = new englishAlphabet();
            Scrabble scrabble = new Scrabble(e);
            Assert.AreEqual(0, scrabble.score("\n\r\t\b\f"));
        }

        [Test]
        public void shouldScore1ForA() {
            englishAlphabet e = new englishAlphabet();
            Scrabble scrabble = new Scrabble(e);
            Assert.AreEqual(1, scrabble.score("a"));
        }

        [Test]
        public void shouldScore4ForF() {

            englishAlphabet e = new englishAlphabet();
            Scrabble scrabble = new Scrabble(e);
            Assert.AreEqual(4, scrabble.score("f"));
        }

        [Test]
        public void shouldScore6ForStreet() {

            englishAlphabet e = new englishAlphabet();
            Scrabble scrabble = new Scrabble(e);
            Assert.AreEqual(6, scrabble.score("street"));
        }

        [Test]
        public void shouldScore22ForQuirky() {

            englishAlphabet e = new englishAlphabet();
            Scrabble scrabble = new Scrabble(e);
            Assert.AreEqual(22, scrabble.score("quirky"));
        }

        [Test]
        public void shouldScoreRussianLetters() {

            russianAlphabet r = new russianAlphabet();
            Scrabble scrabble = new Scrabble(r);
            Assert.AreEqual(18, scrabble.score("дврфъ"));
        }

        [Test]
        public void shouldScoreGreekLetters() {

            greekAlphabet g = new greekAlphabet();
            Scrabble scrabble = new Scrabble(g);
            Assert.AreEqual(20, scrabble.score("φεψωλ"));
        }
    }
}