namespace timer
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(646, 141);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "5 minutes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 3;
            label1.Text = "Alarm Application";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(351, 38);
            label2.Name = "label2";
            label2.Size = new Size(125, 40);
            label2.TabIndex = 4;
            label2.Text = "00:00:00";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(356, 109);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Start timer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(549, 141);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "3 Minutes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(549, 179);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "10 Minutes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(646, 179);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 8;
            button5.Text = "15 Minutes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(305, 80);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 9;
            button6.Text = "Pause";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(405, 80);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 10;
            button7.Text = "Reset";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 249);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 11;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label3;
    }
}
