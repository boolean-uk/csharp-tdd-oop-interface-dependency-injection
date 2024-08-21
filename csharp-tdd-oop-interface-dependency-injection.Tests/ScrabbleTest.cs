using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{
        [TestFixture]
        public class ScrabbleTest {
            [Test]
            public void shouldGive0ForEmptyWords() {
                EnglishAlphabet alphabet = new EnglishAlphabet();
                Scrabble scrabble = new Scrabble(alphabet);
                Assert.That(0, Is.EqualTo(scrabble.score("")));
            }

            [Test]
            public void shouldGive0ForWhiteSpace() {
                EnglishAlphabet alphabet = new EnglishAlphabet();
                Scrabble scrabble = new Scrabble(alphabet);
                Assert.That(0, Is.EqualTo(scrabble.score("\n\r\t\b\f")));
            }

            [Test]
            public void shouldScore1ForA() {
                EnglishAlphabet alphabet = new EnglishAlphabet();
                Scrabble scrabble = new Scrabble(alphabet);
                Assert.That(1, Is.EqualTo(scrabble.score("a")));
            }

            [Test]
            public void shouldScore4ForF() {
                EnglishAlphabet alphabet = new EnglishAlphabet();
                Scrabble scrabble = new Scrabble(alphabet);
                Assert.That(4, Is.EqualTo(scrabble.score("f")));
            }

            [Test]
            public void shouldScore6ForStreet() {
                EnglishAlphabet alphabet = new EnglishAlphabet();
                Scrabble scrabble = new Scrabble(alphabet);
                Assert.That(6, Is.EqualTo(scrabble.score("street")));
            }

            [Test]
            public void shouldScore22ForQuirky() {
                EnglishAlphabet alphabet = new EnglishAlphabet();
                Scrabble scrabble = new Scrabble(alphabet);
                Assert.That(22, Is.EqualTo(scrabble.score("quirky")));
            }

            [Test]
            public void shouldScoreRussianLetters() {
                RussianAlphabet alphabet = new RussianAlphabet();
                Scrabble scrabble = new Scrabble(alphabet);
                Assert.That(18, Is.EqualTo(scrabble.score("дврфъ")));
            }

            [Test]
            public void shouldScoreGreekLetters() {
                GreekAlphabet alphabet = new GreekAlphabet();
                Scrabble scrabble = new Scrabble(alphabet);
                Assert.That(20, Is.EqualTo(scrabble.score("φεψωλ")));
            }
    }
}