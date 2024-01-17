using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            Alphabet a = new LatinAlphabet();
            Scrabble scrabble = new Scrabble(a);
            Assert.AreEqual(0, scrabble.score(""));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            Alphabet a = new LatinAlphabet();
            Scrabble scrabble = new Scrabble(a);
            Assert.AreEqual(0, scrabble.score("\n\r\t\b\f"));
        }

        [Test]
        public void shouldScore1ForA() {
            Alphabet a = new LatinAlphabet();
            Scrabble scrabble = new Scrabble(a);
            Assert.AreEqual(1, scrabble.score("a"));
        }

        [Test]
        public void shouldScore4ForF() {
            Alphabet a = new LatinAlphabet();
            Scrabble scrabble = new Scrabble(a);
            Assert.AreEqual(4, scrabble.score("f"));
        }

        [Test]
        public void shouldScore6ForStreet() {
            Alphabet a = new LatinAlphabet();
            Scrabble scrabble = new Scrabble(a);
            Assert.AreEqual(6, scrabble.score("street"));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            Alphabet a = new LatinAlphabet();
            Scrabble scrabble = new Scrabble(a);
            Assert.AreEqual(22, scrabble.score("quirky"));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            Alphabet ж = new CyrillicAlphabet();
            Scrabble scrabble = new Scrabble(ж);
            Assert.AreEqual(18, scrabble.score("дврфъ"));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            Alphabet λ = new GreekAlphabet();
            Scrabble scrabble = new Scrabble(λ);
            Assert.AreEqual(20, scrabble.score("φεψωλ"));
        }
    }
}