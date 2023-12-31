﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Answer
    {
        public string? Body { get; set; }
        public bool IsCorrect { get; set; }

        public Answer() { }

        public Answer(string? body, bool isCorrect)
        {
            Body = body;
            IsCorrect = isCorrect;
        }

        public override string ToString() => Body ?? "";
    }
}
