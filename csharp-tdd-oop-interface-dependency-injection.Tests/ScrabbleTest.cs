using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

    [TestFixture]
    public class ScrabbleTest
    {
        private Dictionary<string, Scrabble> scrabbles;

        [SetUp]
        public void Setup()
        {
            scrabbles = new Dictionary<string, Scrabble>
            {
                {"English", new Scrabble(new EnglishLetterScores())},
                {"Russian", new Scrabble(new RussianLetterScores())},
                {"Greek", new Scrabble(new GreekLetterScores())}
            };
        }


        [Test]
        public void shouldGive0ForEmptyWords()
        {
            Assert.AreEqual(0, scrabbles["English"].score(""));
        }

        [Test]
        public void shouldGive0ForWhiteSpace()
        {
            Assert.AreEqual(0, scrabbles["English"].score("\n\r\t\b\f"));
        }

        [Test]
        public void shouldScoreBeCaseInsensitively()
        {
            Assert.AreEqual(scrabbles["English"].score("A"), scrabbles["English"].score("a"));
        }

        [Test]
        public void shouldIgnoreNonAlphabetCharacters()
        {
            Assert.AreEqual(11, scrabbles["English"].score("a1sdfsd!"));
        }

        [Test]
        public void shouldIgnoreNonExistentLetter()
        {
            Assert.AreEqual(0, scrabbles["English"].score("å"));
        }

        [Test]
        public void shouldHandleNullInput() //not for empty string, but for aa null valu 
        {
            Assert.AreEqual(0, scrabbles["English"].score(null));
        }

        [Test]
        public void shouldScore1ForA()
        {
            Assert.AreEqual(1, scrabbles["English"].score("a"));
        }

        [Test]
        public void shouldScore4ForF()
        {
            Assert.AreEqual(4, scrabbles["English"].score("f"));
        }

        [Test]
        public void shouldScore6ForStreet()
        {
            Assert.AreEqual(6, scrabbles["English"].score("street"));
        }

        [Test]
        public void shouldScore22ForQuirky()
        {
            Assert.AreEqual(22, scrabbles["English"].score("quirky"));
        }

        [Test]
        public void shouldScoreRussianLetters()
        {
            Assert.AreEqual(18, scrabbles["Russian"].score("дврфъ"));
        }

        [Test]
        public void shouldScore1ForRussianA()
        {
            Assert.AreEqual(1, scrabbles["Russian"].score("а"));
        }

        [Test]
        public void shouldScore2ForRussianE()
        {
            Assert.AreEqual(2, scrabbles["Russian"].score("е"));
        }

        [Test]
        public void shouldScore4ForRussianO()
        {
            Assert.AreEqual(4, scrabbles["Russian"].score("о"));
        }

        [Test]
        public void shouldScore10ForRussianYu()
        {
            Assert.AreEqual(10, scrabbles["Russian"].score("ю"));
        }

        [Test]
        public void shouldScoreGreekLetters()
        {
            Assert.AreEqual(16, scrabbles["Greek"].score("φεψω"));
        }

        [Test]
        public void shouldScore1ForGreekAlpha()
        {
            Assert.AreEqual(1, scrabbles["Greek"].score("α"));
        }

        [Test]
        public void shouldScore2ForGreekBeta()
        {
            Assert.AreEqual(2, scrabbles["Greek"].score("β"));
        }

        [Test]
        public void shouldScore4ForGreekZeta()
        {
            Assert.AreEqual(4, scrabbles["Greek"].score("ζ"));
        }

        [Test]
        public void shouldScore10ForGreekOmega()
        {
            Assert.AreEqual(10, scrabbles["Greek"].score("ω"));
        }
    }
}