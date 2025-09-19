namespace ASKBOT
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.Prompt_TextBox = new System.Windows.Forms.RichTextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.GenAnswer_TextBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASK QUESTION HERE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Prompt_TextBox
            // 
            this.Prompt_TextBox.Location = new System.Drawing.Point(162, 88);
            this.Prompt_TextBox.Name = "Prompt_TextBox";
            this.Prompt_TextBox.Size = new System.Drawing.Size(550, 105);
            this.Prompt_TextBox.TabIndex = 2;
            this.Prompt_TextBox.Text = "";
            this.Prompt_TextBox.TextChanged += new System.EventHandler(this.Prompt_TextBox_TextChanged);
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(350, 225);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(143, 33);
            this.submit_btn.TabIndex = 3;
            this.submit_btn.Text = "EXPLAIN";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // GenAnswer_TextBox
            // 
            this.GenAnswer_TextBox.Location = new System.Drawing.Point(162, 281);
            this.GenAnswer_TextBox.Name = "GenAnswer_TextBox";
            this.GenAnswer_TextBox.Size = new System.Drawing.Size(550, 136);
            this.GenAnswer_TextBox.TabIndex = 4;
            this.GenAnswer_TextBox.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GenAnswer_TextBox);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.Prompt_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Prompt_TextBox;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.RichTextBox GenAnswer_TextBox;
        private System.Windows.Forms.Button button2;
    }
}

