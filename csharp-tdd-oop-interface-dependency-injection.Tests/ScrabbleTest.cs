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
            //   OR Scrabble scrabble = new Scrabble(new EnglishLetterScores());
            Assert.That(scrabbles["English"].score(""), Is.EqualTo(0));
        }

        [Test]
        public void shouldGive0ForWhiteSpace()
        {
            Assert.That(scrabbles["English"].score("\n\r\t\b\f"), Is.EqualTo(0));
        }

        [Test]
        public void shouldScoreBeCaseInsensitively()
        {
            Assert.That(scrabbles["English"].score("A"), Is.EqualTo(scrabbles["English"].score("a")));
        }

        [Test]
        public void shouldIgnoreNonAlphabetCharacters()
        {
            Assert.That(scrabbles["English"].score("a1sdfsd!"), Is.EqualTo(11));
        }

        [Test]
        public void shouldIgnoreNonExistentLetter()
        {
            Assert.That(scrabbles["English"].score("å"), Is.EqualTo(0));
        }

        [Test]
        public void shouldHandleNullInput() //not for empty string, but for aa null valu 
        {
            Assert.That(scrabbles["English"].score(null), Is.EqualTo(0));
        }

        [Test]
        public void shouldScore1ForA()
        {
            Assert.That(scrabbles["English"].score("a"), Is.EqualTo(1));
        }

        [Test]
        public void shouldScore4ForF()
        {
            Assert.That(scrabbles["English"].score("f"), Is.EqualTo(4));
        }

        [Test]
        public void shouldScore6ForStreet()
        {
            Assert.That(scrabbles["English"].score("street"), Is.EqualTo(6));
        }

        [Test]
        public void shouldScore22ForQuirky()
        {
            Assert.That(scrabbles["English"].score("quirky"), Is.EqualTo(22));
        }

        [Test]
        public void shouldScoreRussianLetters()
        {
            Assert.That(scrabbles["Russian"].score("дврфъ"), Is.EqualTo(18));
        }

        [Test]
        public void shouldScore1ForRussianA()
        {
            Assert.That(scrabbles["Russian"].score("а"), Is.EqualTo(1));
        }

        [Test]
        public void shouldScore2ForRussianE()
        {
            Assert.That(scrabbles["Russian"].score("е"), Is.EqualTo(2));
        }

        [Test]
        public void shouldScore4ForRussianO()
        {
            Assert.That(scrabbles["Russian"].score("о"), Is.EqualTo(4));
        }

        [Test]
        public void shouldScore10ForRussianYu()
        {
            Assert.That(scrabbles["Russian"].score("ю"), Is.EqualTo(10));
        }

        [Test]
        public void shouldScoreGreekLetters()
        {
            Assert.That(scrabbles["Greek"].score("φεψω"), Is.EqualTo(16));
        }

        [Test]
        public void shouldScore1ForGreekAlpha()
        {
            Assert.That(scrabbles["Greek"].score("α"), Is.EqualTo(1));
        }

        [Test]
        public void shouldScore2ForGreekBeta()
        {
            Assert.That(scrabbles["Greek"].score("β"), Is.EqualTo(2));
        }

        [Test]
        public void shouldScore4ForGreekZeta()
        {
            Assert.That(scrabbles["Greek"].score("ζ"), Is.EqualTo(4));
        }

        [Test]
        public void shouldScore10ForGreekOmega()
        {
            Assert.That(scrabbles["Greek"].score("ω"), Is.EqualTo(10));
        }
    }
}