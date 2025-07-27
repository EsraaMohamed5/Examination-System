using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace projectOOPC_
{
    public class FinalExam:Exam
    {
        public override void ShowExam()
        {
            int totalGrade = 0;
            int obtain = 0;
            for (int i = 0; i < numberOfQuestion; i++)
            {
                var q = question[i];
                q.print();
                int userAns = ReadAnswerOfUser();
                Console.WriteLine($"the Question is : {q}\n the Answer of the user for this Question is {userAns}\n");
                totalGrade += q.mark;
                if (q.correctAnswer.answer_id == userAns && q.correctAnswer != null)
                {
                    obtain += q.mark;
                }
            }
            Console.WriteLine($"Your total Grade is {obtain}/{totalGrade}");

        }
        private int ReadAnswerOfUser()
        {
            while (true) {
                Console.WriteLine("Enter your answer: ");
                String input= Console.ReadLine();
                try
                {
                    return int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Enter a valid input");
                }
            }

        }
    }
}
