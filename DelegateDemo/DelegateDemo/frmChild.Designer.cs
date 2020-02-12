namespace DelegateDemo
{
    partial class frmChild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 34);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(77, 12);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "收到的消息：";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(96, 34);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 12);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "label";
            // 
            // frmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblText);
            this.Name = "frmChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChild";
            this.Load += new System.EventHandler(this.frmChild_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblMessage;
    }
}