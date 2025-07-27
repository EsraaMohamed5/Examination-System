using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOPC_
{
    public abstract class Question
    {
        public string header { get; set; }
        public string body { get; set; }
        public int mark {  get; set; }
        public Answer[] answerList {  get; set; }
        public Answer correctAnswer { get; set; }
        public abstract void print();
    }
}
