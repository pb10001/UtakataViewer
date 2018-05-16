using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtakataViewer
{
    public partial class ChatPanel : UserControl
    {
        public ChatPanel()
        {
            InitializeComponent();
        }
        public void SetContents(string name , string content)
        {
            nameLabel.Text = name;
            contentLabel.Text = content;
        }
    }
}
