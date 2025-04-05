namespace Collatz_conjecture_inversed
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            button4 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new System.Drawing.Point(15, 245);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(1029, 384);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(909, 205);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(135, 34);
            button1.TabIndex = 1;
            button1.Text = "Decode";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(81, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(960, 111);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.KeyPress += richTextBox1_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(45, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(858, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "1";
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 20);
            label1.TabIndex = 4;
            label1.Text = "Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 210);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(19, 20);
            label2.TabIndex = 5;
            label2.Text = "G";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(15, 652);
            textBox2.MaxLength = 5;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(1029, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(768, 471);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(135, 34);
            button2.TabIndex = 6;
            button2.Text = "Append";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(513, 691);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(135, 34);
            button3.TabIndex = 8;
            button3.Text = "Encode";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 691);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 20);
            label3.TabIndex = 9;
            label3.Text = "Sum:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(81, 126);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(27, 20);
            label4.TabIndex = 10;
            label4.Text = "2^";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(81, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(960, 27);
            textBox3.TabIndex = 11;
            textBox3.Text = "1";
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(15, 167);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 20);
            label5.TabIndex = 12;
            label5.Text = "length";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(768, 130);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(175, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Break in smaller value";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(954, 696);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "About";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1060, 729);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Collatz conjecture inverse";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
    }
}
