
namespace EncodingWindowTool
{
    partial class CreateCharcodeToolWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Codes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Texts = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "表名称(不用自己加后缀)";
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(156, 10);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(100, 21);
            this.FName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "目标代码1(空格分隔代码)";
            // 
            // Codes
            // 
            this.Codes.Location = new System.Drawing.Point(15, 52);
            this.Codes.Name = "Codes";
            this.Codes.Size = new System.Drawing.Size(100, 21);
            this.Codes.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "目标字符1(空格分隔字符)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Texts
            // 
            this.Texts.Location = new System.Drawing.Point(156, 52);
            this.Texts.Name = "Texts";
            this.Texts.Size = new System.Drawing.Size(100, 21);
            this.Texts.TabIndex = 3;
            // 
            // OK
            // 
            this.OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.OK.Location = new System.Drawing.Point(235, 96);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "NO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateCharcodeToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(395, 123);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Texts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.Codes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "CreateCharcodeToolWindow";
            this.Text = "CreateCharcodeToolWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox Codes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Texts;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button button1;
    }
}