
namespace WinFormHellowWorld
{
    partial class Form1
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
            this.textBoxShowHellow = new System.Windows.Forms.TextBox();
            this.buttonSayHellow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxShowHellow
            // 
            this.textBoxShowHellow.Location = new System.Drawing.Point(128, 26);
            this.textBoxShowHellow.Name = "textBoxShowHellow";
            this.textBoxShowHellow.Size = new System.Drawing.Size(547, 28);
            this.textBoxShowHellow.TabIndex = 0;
            // 
            // buttonSayHellow
            // 
            this.buttonSayHellow.Location = new System.Drawing.Point(309, 105);
            this.buttonSayHellow.Name = "buttonSayHellow";
            this.buttonSayHellow.Size = new System.Drawing.Size(190, 53);
            this.buttonSayHellow.TabIndex = 1;
            this.buttonSayHellow.Text = "Click Here";
            this.buttonSayHellow.UseVisualStyleBackColor = true;
            this.buttonSayHellow.Click += new System.EventHandler(this.buttonSayHellow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSayHellow);
            this.Controls.Add(this.textBoxShowHellow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxShowHellow;
        private System.Windows.Forms.Button buttonSayHellow;
    }
}

