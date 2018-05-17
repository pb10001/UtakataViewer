using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace UtakataViewer
{
    public partial class viewer : Form
    {
        public viewer()
        {
            InitializeComponent();
        }
        string endPoint;
        Puzzle currentPuzzle;
        private void Viewer_Load(object sender, EventArgs e)
        {
            using (var reader = new System.IO.StreamReader(@"Config.txt"))
            {
                endPoint = reader.ReadLine();
            }
        }

        private void fetchButton_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            var res = client.DownloadString(string.Format("{0}?room={1}", endPoint,searchBox.Text));
            try
            {
                currentPuzzle = JsonConvert.DeserializeObject<Puzzle>(res);
                Update();
            }
            catch
            {
                MessageBox.Show("ルームが存在しません", "エラー");
            }
        }
        private new void Update()
        {
            questionList.Controls.Clear();
            chatList.Controls.Clear();
            puzzlePanel1.setContent(currentPuzzle.Content.Content);
            solutionPanel1.SetContent(currentPuzzle.Content.Solution);
            foreach (var item in currentPuzzle.Questions)
            {
                var row = new QuestionRow();
                row.SetConents(item.Questioner, item.Question, item.Answerer, item.Answer);
                row.Size = new Size(questionList.Size.Width, row.Size.Height);
                questionList.Controls.Add(row);
            }
            foreach (var item in currentPuzzle.Chats)
            {
                var panel = new ChatPanel();
                panel.SetContents(item.Name, item.Content);
                chatList.Controls.Add(panel);
            }
        }
        private void puzzlePanel1_Load(object sender, EventArgs e)
        {

        }

        private void 上書き保存SToolStripButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new System.IO.StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8))
                {
                    writer.Write(currentPuzzle);
                }
            }
        }

        private void ヘルプLToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/pb10001/utakata-umigame");
        }
    }
}
