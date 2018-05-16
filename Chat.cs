using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UtakataViewer
{
    public struct Chat
    {
        public Chat(string name, string content)
        {
            Name = name;
            Content = content;
        }
        [JsonProperty("sent_from")]
        public string Name { get; set; }
        public string Content { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1}\n", Name, Content);
        }
    }
}
