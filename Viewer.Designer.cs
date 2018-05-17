namespace UtakataViewer
{
    partial class viewer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.上書き保存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ヘルプLToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.chatList = new System.Windows.Forms.FlowLayoutPanel();
            this.questionList = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.fetchButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.solutionPanel1 = new UtakataViewer.SolutionPanel();
            this.puzzlePanel1 = new UtakataViewer.PuzzlePanel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上書き保存SToolStripButton,
            this.ヘルプLToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1092, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 上書き保存SToolStripButton
            // 
            this.上書き保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.上書き保存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("上書き保存SToolStripButton.Image")));
            this.上書き保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.上書き保存SToolStripButton.Name = "上書き保存SToolStripButton";
            this.上書き保存SToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.上書き保存SToolStripButton.Text = "保存(&S)";
            this.上書き保存SToolStripButton.Click += new System.EventHandler(this.上書き保存SToolStripButton_Click);
            // 
            // ヘルプLToolStripButton
            // 
            this.ヘルプLToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ヘルプLToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ヘルプLToolStripButton.Image")));
            this.ヘルプLToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ヘルプLToolStripButton.Name = "ヘルプLToolStripButton";
            this.ヘルプLToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ヘルプLToolStripButton.Text = "ヘルプ(&L)";
            this.ヘルプLToolStripButton.Click += new System.EventHandler(this.ヘルプLToolStripButton_Click);
            // 
            // chatList
            // 
            this.chatList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatList.AutoScroll = true;
            this.chatList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatList.Location = new System.Drawing.Point(801, 68);
            this.chatList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chatList.Name = "chatList";
            this.chatList.Size = new System.Drawing.Size(290, 686);
            this.chatList.TabIndex = 2;
            // 
            // questionList
            // 
            this.questionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionList.AutoScroll = true;
            this.questionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionList.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.questionList.Location = new System.Drawing.Point(0, 231);
            this.questionList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.questionList.Name = "questionList";
            this.questionList.Size = new System.Drawing.Size(794, 332);
            this.questionList.TabIndex = 3;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(2, 35);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(171, 23);
            this.searchBox.TabIndex = 4;
            // 
            // fetchButton
            // 
            this.fetchButton.Location = new System.Drawing.Point(181, 32);
            this.fetchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(87, 29);
            this.fetchButton.TabIndex = 5;
            this.fetchButton.Text = "表示";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.fetchButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "csvファイル(*.csv)|*.csv";
            // 
            // solutionPanel1
            // 
            this.solutionPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solutionPanel1.AutoScroll = true;
            this.solutionPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.solutionPanel1.Location = new System.Drawing.Point(0, 571);
            this.solutionPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.solutionPanel1.Name = "solutionPanel1";
            this.solutionPanel1.Size = new System.Drawing.Size(794, 184);
            this.solutionPanel1.TabIndex = 7;
            // 
            // puzzlePanel1
            // 
            this.puzzlePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.puzzlePanel1.AutoScroll = true;
            this.puzzlePanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.puzzlePanel1.Location = new System.Drawing.Point(0, 68);
            this.puzzlePanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.puzzlePanel1.Name = "puzzlePanel1";
            this.puzzlePanel1.Size = new System.Drawing.Size(794, 155);
            this.puzzlePanel1.TabIndex = 6;
            this.puzzlePanel1.Load += new System.EventHandler(this.puzzlePanel1_Load);
            // 
            // viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1092, 766);
            this.Controls.Add(this.solutionPanel1);
            this.Controls.Add(this.puzzlePanel1);
            this.Controls.Add(this.fetchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.questionList);
            this.Controls.Add(this.chatList);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "viewer";
            this.Text = "うたかたビューワー";
            this.Load += new System.EventHandler(this.Viewer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 上書き保存SToolStripButton;
        private System.Windows.Forms.ToolStripButton ヘルプLToolStripButton;
        private System.Windows.Forms.FlowLayoutPanel chatList;
        private System.Windows.Forms.FlowLayoutPanel questionList;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button fetchButton;
        private PuzzlePanel puzzlePanel1;
        private SolutionPanel solutionPanel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

