using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOPC_
{
    public class TrueFalseQuestion:Question
    {
        public TrueFalseQuestion() {

            answerList = new Answer[]
            {
                new Answer(1,"true"),
                new Answer(2,"false")
            };        
        }
        public override void print()
        {
            Console.WriteLine($"mark of this Question is {mark}\nHeader of Question is {header}\nthe body is {body}");
            foreach (var ans in answerList)
            {
                Console.WriteLine($"Answer is {ans.answer_id},{ans.answer_text}");
            }
        }

    }
}
