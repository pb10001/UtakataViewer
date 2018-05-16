using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UtakataViewer
{
    public struct Problem
    {
        public Problem(string sender, string content, string solution)
        {
            Sender = sender;
            Content = content;
            Solution = solution;
        }
        public string Sender { get; set; }
        public string Content { get; set; }
        [JsonProperty("trueAns")]
        public string Solution { get; set; }
        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n", Sender, Content, Solution);
        }
    }
}
