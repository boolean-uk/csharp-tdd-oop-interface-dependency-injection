using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            EnglishAlphabet en = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(en);
            Assert.That(0, Is.EqualTo(scrabble.score("")));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            EnglishAlphabet en = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(en);
            Assert.That(0, Is.EqualTo(scrabble.score("\n\r\t\b\f")));
        }

        [Test]
        public void shouldScore1ForA() {
            EnglishAlphabet en = new EnglishAlphabet();

            Scrabble scrabble = new Scrabble(en);
            Assert.That(1, Is.EqualTo(scrabble.score("a")));
        }

        [Test]
        public void shouldScore4ForF() {
            EnglishAlphabet en = new EnglishAlphabet();

            Scrabble scrabble = new Scrabble(en);
            Assert.That(4, Is.EqualTo(scrabble.score("f")));
        }

        [Test]
        public void shouldScore6ForStreet() {
            EnglishAlphabet en = new EnglishAlphabet();

            Scrabble scrabble = new Scrabble(en);
            Assert.That(6, Is.EqualTo(scrabble.score("street")));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            EnglishAlphabet en = new EnglishAlphabet();

            Scrabble scrabble = new Scrabble(en);
            Assert.That(22, Is.EqualTo(scrabble.score("quirky")));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            RussianAlphabet ru = new RussianAlphabet();
            Scrabble scrabble = new Scrabble(ru);
            Assert.That(18, Is.EqualTo(scrabble.score("дврфъ")));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            GreekAlphabet gre = new GreekAlphabet();
            Scrabble scrabble = new Scrabble(gre);
            Assert.That(20, Is.EqualTo(scrabble.score("φεψωλ")));
        }
    }
}