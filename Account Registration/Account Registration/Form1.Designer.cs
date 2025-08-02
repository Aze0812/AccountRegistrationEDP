namespace Account_Registration
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ComboBox1 = new ComboBox();
            NextBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(37, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(37, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(201, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(376, 125);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(202, 27);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(37, 187);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(158, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(213, 187);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 5;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // ComboBox1
            // 
            ComboBox1.Anchor = AnchorStyles.None;
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Location = new Point(201, 60);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(275, 28);
            ComboBox1.TabIndex = 7;
            ComboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // NextBtn
            // 
            NextBtn.Anchor = AnchorStyles.None;
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.ForeColor = SystemColors.ActiveCaptionText;
            NextBtn.Location = new Point(244, 533);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(94, 29);
            NextBtn.TabIndex = 9;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += NextBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(37, 38);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 10;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(201, 37);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 11;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(37, 102);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 12;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(201, 102);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 13;
            label4.Text = "Last Name";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(376, 102);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 14;
            label5.Text = "Middle Name";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(37, 164);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 15;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(213, 164);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 16;
            label7.Text = "Contact No.:";
            label7.Click += label7_Click;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.Location = new Point(37, 265);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(541, 251);
            textBox7.TabIndex = 18;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(37, 242);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 19;
            label8.Text = "Address:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 563);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NextBtn);
            Controls.Add(ComboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistration";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox ComboBox1;
        private Button NextBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
    }
}
