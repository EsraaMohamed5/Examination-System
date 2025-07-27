using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOPC_
{
    public abstract class Exam
    {
        public int numberOfQuestion {  get; set; }
        public int time {  get; set; }
        public Question[] question { get; set; }
        public abstract void ShowExam();
    }
}
