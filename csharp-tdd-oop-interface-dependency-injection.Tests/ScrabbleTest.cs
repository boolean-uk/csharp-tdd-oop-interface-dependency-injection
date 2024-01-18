using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;
using tdd_oop_interface_dependency_injection.CSharp.Main.Language;
using tdd_oop_interface_dependency_injection.CSharp.Main.Main.Language;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            Greek greek = new Greek();
            Scrabble scrabble = new Scrabble(greek);
            Assert.That(0, Is.EqualTo(scrabble.score("")));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            English english = new English();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(0, Is.EqualTo(scrabble.score("\n\r\t\b\f")));
        }

        [Test]
        public void shouldScore1ForA() {
            English english = new English();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(1, Is.EqualTo(scrabble.score("a")));
        }

        [Test]
        public void shouldScore4ForF() {
            English english = new English();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(4, Is.EqualTo(scrabble.score("f")));
        }

        [Test]
        public void shouldScore6ForStreet() {
            English english = new English();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(6, Is.EqualTo(scrabble.score("street")));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            English english = new English();
            Scrabble scrabble = new Scrabble(english);
            Assert.That(22, Is.EqualTo(scrabble.score("quirky")));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            Russian russian =  new Russian();
            Scrabble scrabble = new Scrabble(russian);
            Assert.That(18, Is.EqualTo(scrabble.score("дврфъ")));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            Greek greek = new Greek();
            Scrabble scrabble = new Scrabble(greek);
            Assert.That(20, Is.EqualTo(scrabble.score("φεψωλ")));
        }
    }
}