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
            this.answerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.answerPanel.Location = new System.Drawing.Point(3, 87);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(473, 72);
            this.answerPanel.TabIndex = 1;
            // 
            // questionPanel
            // 
            this.questionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.questionPanel.Location = new System.Drawing.Point(3, 3);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(473, 72);
            this.questionPanel.TabIndex = 0;
            // 
            // QuestionRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.answerPanel);
            this.Controls.Add(this.questionPanel);
            this.Name = "QuestionRow";
            this.Size = new System.Drawing.Size(476, 159);
            this.ResumeLayout(false);

        }

        #endregion

        private ChatPanel answerPanel;
        private ChatPanel questionPanel;
    }
}
