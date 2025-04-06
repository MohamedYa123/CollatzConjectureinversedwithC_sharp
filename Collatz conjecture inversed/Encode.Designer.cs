namespace Collatz_conjecture_inversed
{
    partial class Encode
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
            components = new System.ComponentModel.Container();
            button1 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(623, 59);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(150, 27);
            button1.TabIndex = 0;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(41, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(576, 27);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(493, 333);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(164, 66);
            button2.TabIndex = 2;
            button2.Text = "Decode";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(41, 409);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 20);
            label1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(209, 333);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(164, 66);
            button3.TabIndex = 4;
            button3.Text = "Encode";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Encode
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "Encode";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Encode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}