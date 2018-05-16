namespace UtakataViewer
{
    partial class QuestionRow
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.answerPanel = new UtakataViewer.ChatPanel();
            this.questionPanel = new UtakataViewer.ChatPanel();
            this.SuspendLayout();
            // 
            // answerPanel
            // 
            this.answerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.answerPanel.Location = new System.Drawing.Point(278, 3);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(258, 72);
            this.answerPanel.TabIndex = 1;
            // 
            // questionPanel
            // 
            this.questionPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.questionPanel.Location = new System.Drawing.Point(3, 3);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(269, 72);
            this.questionPanel.TabIndex = 0;
            // 
            // QuestionRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.answerPanel);
            this.Controls.Add(this.questionPanel);
            this.Name = "QuestionRow";
            this.Size = new System.Drawing.Size(541, 79);
            this.ResumeLayout(false);

        }

        #endregion

        private ChatPanel questionPanel;
        private ChatPanel answerPanel;
    }
}
