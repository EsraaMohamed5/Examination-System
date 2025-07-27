using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOPC_
{
    public class Answer
    {
        public int answer_id {  get; set; }
        public string answer_text { get; set; }
        public Answer(int id,string text) {
            answer_id = id;
            answer_text = text;
        }
    }
}
