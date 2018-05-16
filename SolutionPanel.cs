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
    public partial class SolutionPanel : UserControl
    {
        public SolutionPanel()
        {
            InitializeComponent();
        }
        public void SetContent(string content)
        {
            contentLabel.Text = content;
        }
    }
}
