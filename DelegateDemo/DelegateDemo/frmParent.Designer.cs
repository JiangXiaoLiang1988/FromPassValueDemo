namespace DelegateDemo
{
    partial class frmParent
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btn_Value = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 24);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(226, 21);
            this.txtMessage.TabIndex = 0;
            // 
            // btn_Value
            // 
            this.btn_Value.Location = new System.Drawing.Point(12, 72);
            this.btn_Value.Name = "btn_Value";
            this.btn_Value.Size = new System.Drawing.Size(131, 25);
            this.btn_Value.TabIndex = 1;
            this.btn_Value.Text = "给子窗体传值";
            this.btn_Value.UseVisualStyleBackColor = true;
            this.btn_Value.Click += new System.EventHandler(this.btn_Value_Click);
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 206);
            this.Controls.Add(this.btn_Value);
            this.Controls.Add(this.txtMessage);
            this.Name = "frmParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "父窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btn_Value;
    }
}

