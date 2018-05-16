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
    public partial class PuzzlePanel : UserControl
    {
        public PuzzlePanel()
        {
            InitializeComponent();
        }
        public void setContent(string content)
        {
            contentLabel.Text = content;
        }
    }
}
