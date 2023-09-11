using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Quiz
    {
        public string? Title { get; set; }
        public Question[] Questions { get; set; } = new Question[0];

        public Quiz() { }

        public Quiz(string? title) => Title = title;

        public Quiz(string? title, Question[] questions)
        {
            Title = title;
            Questions = questions;
        }

        public void AddQuestion(Question question)
        {
            Question[] newQuestions = new Question[Questions.Length + 1];
            newQuestions[Questions.Length] = question;

            for (int i = 0; i < Questions.Length; i++) 
                newQuestions[i] = Questions[i];

            Questions = newQuestions;
        }

        public void Play()
        {

        }
    }
}
