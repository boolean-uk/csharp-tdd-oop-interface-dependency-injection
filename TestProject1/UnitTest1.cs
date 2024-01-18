﻿using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace TestProject1
{
    [TestFixture]
    public class ScrabbleTest
    {
        [Test]
        public void shouldGive0ForEmptyWords()
        {
            Scrabble scrabble = new Scrabble();
            Assert.That(0, Is.EqualTo(scrabble.score("")));
        }

        [Test]
        public void shouldGive0ForWhiteSpace()
        {
            Scrabble scrabble = new Scrabble();
            Assert.That(0, Is.EqualTo(scrabble.score("\n\r\t\b\f")));
        }

        [Test]
        public void shouldScore1ForA()
        {
            Scrabble scrabble = new Scrabble();
            Assert.That(1, Is.EqualTo(scrabble.score("a")));
        }

        [Test]
        public void shouldScore4ForF()
        {
            Scrabble scrabble = new Scrabble();
            Assert.That(4, Is.EqualTo(scrabble.score("f")));
        }

        [Test]
        public void shouldScore6ForStreet()
        {
            Scrabble scrabble = new Scrabble();
            Assert.That(6, Is.EqualTo(scrabble.score("street")));
        }

        [Test]
        public void shouldScore22ForQuirky()
        {
            Scrabble scrabble = new Scrabble();
            Assert.That(22, Is.EqualTo(scrabble.score("quirky")));
        }

        [Test]
        public void shouldScoreRussianLetters()
        {
            Scrabble scrabble = new Scrabble();
            Assert.That(18, Is.EqualTo(scrabble.score("дврфъ")));
        }

        [Test]
        public void shouldScoreGreekLetters()
        {
            Scrabble scrabble = new Scrabble();
            Assert.That(20, Is.EqualTo(scrabble.score("φεψωλ")));
        }
    }
}