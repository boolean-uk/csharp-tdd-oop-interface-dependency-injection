using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            CommonAlphabet alphabet = new CommonAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.That(0, Is.EqualTo(scrabble.score("")));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            CommonAlphabet alphabet = new CommonAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.That(0, Is.EqualTo(scrabble.score("\n\r\t\b\f")));
        }

        [Test]
        public void shouldScore1ForA() {
            CommonAlphabet alphabet = new CommonAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.That(1, Is.EqualTo(scrabble.score("a")));
        }

        [Test]
        public void shouldScore4ForF() {
            CommonAlphabet alphabet = new CommonAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.That(4, Is.EqualTo(scrabble.score("f")));
        }

        [Test]
        public void shouldScore6ForStreet() {
            CommonAlphabet alphabet = new CommonAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.That(6, Is.EqualTo(scrabble.score("street")));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            CommonAlphabet alphabet = new CommonAlphabet();
            Scrabble scrabble = new Scrabble(alphabet);
            Assert.That(scrabble.score("quirky"), Is.EqualTo(22));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            CryllicAlphabet cryllicAlphabet = new CryllicAlphabet();
            Scrabble scrabble = new Scrabble(cryllicAlphabet);
            Assert.That(scrabble.score("дврфъ"), Is.EqualTo(18));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            GreekAlphabet greekAlphabet = new GreekAlphabet();
            Scrabble scrabble = new Scrabble(greekAlphabet);
            Assert.That(scrabble.score("φεψωλ"), Is.EqualTo(20));
        }
    }
}