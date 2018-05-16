using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UtakataViewer
{
    public class QAPair
    {
        public QAPair(string qName, string qContent, string aName, string aContent)
        {
            Questioner = qName;
            Question = qContent;
            Answerer = aName;
            Answer = aContent;
        }
        [JsonProperty("name")]
        public string Questioner { get; set; }
        [JsonProperty("text")]
        public string Question { get; set; }
        public string Answerer { get; set; }
        public string Answer { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}\n", Questioner, Question, Answerer, Answer);
        }
    }
}
