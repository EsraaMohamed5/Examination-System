using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOPC_
{
    public class Subject
    {
        public int subject_id {  get; set; }
        public string subject_name { get; set; }
        public Exam subject_exam { get; set; }
        public void CreateExam(Exam exam)
        {
            subject_exam = exam;
        }
    }
}
