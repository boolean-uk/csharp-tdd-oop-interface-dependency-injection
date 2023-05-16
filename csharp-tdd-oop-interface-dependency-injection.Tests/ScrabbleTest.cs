using languages;
using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;
using TddOopInternal.InterfaceDependencyInjection.CSharp.Main.Interfaces;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            Language lang = new English();
            Scrabble scrabble = new Scrabble(lang);
            Assert.AreEqual(0, scrabble.score(""));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            Language lang = new English();
            Scrabble scrabble = new Scrabble(lang);
            Assert.AreEqual(0, scrabble.score("\n\r\t\b\f"));
        }

        [Test]
        public void shouldScore1ForA() {
            Language lang = new English();
            Scrabble scrabble = new Scrabble(lang);
            Assert.AreEqual(1, scrabble.score("a"));
        }

        [Test]
        public void shouldScore4ForF() {
            Language lang = new English();
            Scrabble scrabble = new Scrabble(lang);
            Assert.AreEqual(4, scrabble.score("f"));
        }

        [Test]
        public void shouldScore6ForStreet() {
            Language lang = new English();
            Scrabble scrabble = new Scrabble(lang);
            Assert.AreEqual(6, scrabble.score("street"));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            Language lang = new English();
            Scrabble scrabble = new Scrabble(lang);
            Assert.AreEqual(22, scrabble.score("quirky"));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            Language lang = new Russian();
            Scrabble scrabble = new Scrabble(lang);
            Assert.AreEqual(18, scrabble.score("дврфъ"));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            Language lang = new Greek();
            Scrabble scrabble = new Scrabble(lang);
            Assert.AreEqual(20, scrabble.score("φεψωλ"));
        }
    }
}