﻿using csharp_scrabble_challenge.Main;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Test
{
    [TestFixture]
    public class ExtensionTests
    {

        [TestCase("{street}", 12)] //extension double word
        [TestCase("[street]", 18)] //extension triple word
        [TestCase("{quirky}", 44)] //extension double word
        [TestCase("[quirky]", 66)] //extension triple word
        [TestCase("{OXyPHEnBUTaZoNE}", 82)]
        [TestCase("[OXyPHEnBUTaZoNE]", 123)]

        // Added tests
        [TestCase("st{r}eet", 7)]
        [TestCase("st[r]eet", 8)]
        [TestCase("st{{r}}eet", 9)]
        [TestCase("s{t{r}e}et", 11)]

        [TestCase("d[o]{g}", 9)]
        [TestCase("d[[o]{g}]", 23)]
        [TestCase("{d[[o]{g}]}", 46)]

        public void ExtendedCriteriaTests(string word, int targetScore)
        {
            Assert.AreEqual(this.GetWordScore(word), targetScore);
        }

        private int GetWordScore(string word) => new Scrabble(word).score();
    }
}
