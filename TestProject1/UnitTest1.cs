using tdd_oop_interface_dependency_injection.CSharp.Main;
using tdd_oop_interface_dependency_injection.Main;

namespace TestProject1
{
    [TestFixture]
    public class ScrabbleTest
    {
        Scrabble scrabble;

        [SetUp]
        public void setup()
        {
            List<IAlphabetPack> alphabetPacks = new List<IAlphabetPack>();
            alphabetPacks.Add(new AlphabetEnglish());
            alphabetPacks.Add(new AlphabetRussian());
            alphabetPacks.Add(new AlphabetGreek());

            scrabble = new Scrabble(alphabetPacks);
        }

        [Test]
        public void shouldGive0ForEmptyWords()
        {
            
            Assert.That(0, Is.EqualTo(scrabble.score("")));
        }

        [Test]
        public void shouldGive0ForWhiteSpace()
        {
            Assert.That(0, Is.EqualTo(scrabble.score("\n\r\t\b\f")));
        }

        [Test]
        public void shouldScore1ForA()
        {
            Assert.That(1, Is.EqualTo(scrabble.score("a")));
        }

        [Test]
        public void shouldScore4ForF()
        {
            Assert.That(4, Is.EqualTo(scrabble.score("f")));
        }

        [Test]
        public void shouldScore6ForStreet()
        {
            Assert.That(6, Is.EqualTo(scrabble.score("street")));
        }

        [Test]
        public void shouldScore22ForQuirky()
        {
            Assert.That(22, Is.EqualTo(scrabble.score("quirky")));
        }

        [Test]
        public void shouldScoreRussianLetters()
        {
            Assert.That(18, Is.EqualTo(scrabble.score("дврфъ")));
        }

        [Test]
        public void shouldScoreGreekLetters()
        {
            Assert.That(20, Is.EqualTo(scrabble.score("φεψωλ")));
        }
    }
}