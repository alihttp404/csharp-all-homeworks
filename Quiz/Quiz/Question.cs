using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Question
    {
        public string? Body { get; set; }
        public Answer[] Answers { get; set; } = new Answer[0];

        public Question() { }

        public Question(string? body) => Body = body;

        public Question(string? body, Answer[] answers)
        {
            Body = body;
            Answers = answers;
        }

        public void AddAnswer(Answer answer)
        {
            Answer[] newAnswers = new Answer[Answers.Length+1];
            
            for (int i = 0; i < Answers.Length; i++) 
                newAnswers[i] = Answers[i];
            newAnswers[Answers.Length] = answer;

            Answers = newAnswers;
        }

        public void ShuffleAnswers()
        {
            for (int i = 0; i < Answers.Length; i++)
            {
                int idx = new Random().Next(i + 1, Answers.Length - 1);

                Answer temp = Answers[idx];
                Answers[idx] = Answers[i];
                Answers[i] = temp;
            }
        }
    }
}
