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
            public void shouldGive0ForEmptyWords() {
                Assert.AreEqual(0, scrabbles["English"].score(""));
            }

            [Test]
            public void shouldGive0ForWhiteSpace() {
                Assert.AreEqual(0, scrabbles["English"].score("\n\r\t\b\f"));
            }

            [Test]
            public void shouldScore1ForA() {
                Assert.AreEqual(1, scrabbles["English"].score("a"));
            }

            [Test]
            public void shouldScore4ForF() {
                Assert.AreEqual(4, scrabbles["English"].score("f"));
            }

            [Test]
            public void shouldScore6ForStreet() {
                Assert.AreEqual(6, scrabbles["English"].score("street"));

            }

            [Test]
            public void shouldScore22ForQuirky() {
                Assert.AreEqual(22, scrabbles["English"].score("quirky"));

            }

            [Test]
            public void shouldScoreRussianLetters() {
                Assert.AreEqual(18, scrabbles["Russian"].score("дврфъ"));

            }

            [Test]
            public void shouldScoreGreekLetters() {
                Assert.AreEqual(16, scrabbles["Greek"].score("φεψω"));


            }
        }
    } 