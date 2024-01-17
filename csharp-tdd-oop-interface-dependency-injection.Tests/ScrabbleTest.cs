using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [TestCase("english")]
        [TestCase("russian")]
        [TestCase("greek")]
        public void shouldGive0ForEmptyWords(string language) {
            Scrabble scrabble = new Scrabble(language);
            Assert.That(scrabble.score(""), Is.EqualTo(0));
        }

        [TestCase("english")]
        [TestCase("russian")]
        [TestCase("greek")]
        public void shouldGive0ForWhiteSpace(string language) {
            Scrabble scrabble = new Scrabble(language);
            Assert.That(scrabble.score("\n\r\t\b\f"), Is.EqualTo(0));
        }

        [TestCase("english")]
        public void shouldScore1ForA(string language) {
            Scrabble scrabble = new Scrabble(language);
            Assert.That(scrabble.score("a"), Is.EqualTo(1));
        }

        [TestCase("english")]
        public void shouldScore4ForF(string language) {
            Scrabble scrabble = new Scrabble(language);
            Assert.That(scrabble.score("f"), Is.EqualTo(4));
        }

        [TestCase("english")]
        public void shouldScore6ForStreet(string language) {
            Scrabble scrabble = new Scrabble(language);
                Assert.That(scrabble.score("street"), Is.EqualTo(6));
            }

        [TestCase("english")]
        public void shouldScore22ForQuirky(string language) {
            Scrabble scrabble = new Scrabble(language);
            Assert.That(scrabble.score("quirky"), Is.EqualTo(22));
        }

        [TestCase("russian")]
        public void shouldScoreRussianLetters(string language) {
            Scrabble scrabble = new Scrabble(language);
            Assert.That(scrabble.score("дврфъ"), Is.EqualTo(18));
        }

        [TestCase("greek")]
        public void shouldScoreGreekLetters(string language) {
            Scrabble scrabble = new Scrabble(language);
            Assert.That(scrabble.score("φεψωλ"), Is.EqualTo(20));
        }
    }
}