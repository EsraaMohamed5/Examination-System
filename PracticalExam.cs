using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOPC_
{
    public class PracticalExam : Exam
    {
        public override void ShowExam()
        {
            for (int i = 0; i < numberOfQuestion; i++)
            {
                var q = question[i];    
                q.print();
                Console.WriteLine($"Correct Answer of Question {q} is {q.correctAnswer.answer_text}\n");
            }
        }
    }
}
