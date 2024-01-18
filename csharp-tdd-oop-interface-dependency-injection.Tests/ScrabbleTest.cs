﻿using Alphabets;
using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Test
{

        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void shouldGive0ForEmptyWords() {
            IAlphabet englishAlphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(englishAlphabet);
            Assert.That(0, Is.EqualTo(scrabble.score("")));
        }

        [Test]
        public void shouldGive0ForWhiteSpace() {
            IAlphabet englishAlphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(englishAlphabet);
            Assert.That(0, Is.EqualTo(scrabble.score("\n\r\t\b\f")));
        }

        [Test]
        public void shouldScore1ForA() {
            IAlphabet englishAlphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(englishAlphabet);
            Assert.That(1, Is.EqualTo(scrabble.score("a")));
        }

        [Test]
        public void shouldScore4ForF() {
            IAlphabet englishAlphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(englishAlphabet);
            Assert.That(4, Is.EqualTo(scrabble.score("f")));
        }

        [Test]
        public void shouldScore6ForStreet() {
            IAlphabet englishAlphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(englishAlphabet);
            Assert.That(6, Is.EqualTo(scrabble.score("street")));
        }

        [Test]
        public void shouldScore22ForQuirky() {
            IAlphabet englishAlphabet = new EnglishAlphabet();
            Scrabble scrabble = new Scrabble(englishAlphabet);
            Assert.That(22, Is.EqualTo(scrabble.score("quirky")));
        }

        [Test]
        public void shouldScoreRussianLetters() {
            IAlphabet russianAlphabet = new RussianAlphabet();
            Scrabble scrabble = new Scrabble(russianAlphabet);
            Assert.That(18, Is.EqualTo(scrabble.score("дврфъ")));
        }

        [Test]
        public void shouldScoreGreekLetters() {
            IAlphabet greekAlphabet = new GreekAlphabet();
            Scrabble scrabble = new Scrabble(greekAlphabet);
            Assert.That(20, Is.EqualTo(scrabble.score("φεψωλ")));
        }
    }
}