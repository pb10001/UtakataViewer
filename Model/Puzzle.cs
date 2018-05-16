using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace UtakataViewer
{
    public class Puzzle
    {
        [JsonProperty("mondai")]
        public Problem Content { get; set; }
        [JsonProperty("chat")]
        public List<Chat> Chats { get; set; }
        [JsonProperty("question")]
        public List<QAPair> Questions { get; set; }
        public override string ToString()
        {
            string res = "";
            res += Content.ToString();
            foreach (var item in Questions)
            {
                res += item.ToString();
            }
            foreach (var item in Chats)
            {
                res += item.ToString();
            }
            return res;
        }
    }
}
