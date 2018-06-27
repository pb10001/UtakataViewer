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
    public partial class QuestionRow : UserControl
    {
        public QuestionRow()
        {
            InitializeComponent();
        }
        public void SetConents(string questioner, string question, string answerer, string answer)
        {
            questionPanel.SetContents(questioner, "Q: " + question);
            answerPanel.SetContents(answerer, "A: "+answer);
        }
    }
}
