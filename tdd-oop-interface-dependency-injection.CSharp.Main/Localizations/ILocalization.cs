﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localizations
{
    public interface ILocalization
    {
        public Dictionary<char, int> GetLetterScores();
    }
}
