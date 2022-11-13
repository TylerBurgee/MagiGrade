namespace ExamGradingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.correctAnswers_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.examineeAnswers_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calculateGrade_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.correctAnswersFile_Button = new System.Windows.Forms.Button();
            this.examineeAnswersFile_Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.examineeName_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.examDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // correctAnswers_textBox
            // 
            this.correctAnswers_textBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correctAnswers_textBox.Location = new System.Drawing.Point(320, 208);
            this.correctAnswers_textBox.Name = "correctAnswers_textBox";
            this.correctAnswers_textBox.PlaceholderText = "Ex: A,B,B,C,A,...";
            this.correctAnswers_textBox.Size = new System.Drawing.Size(192, 25);
            this.correctAnswers_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Examinee Answers:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // examineeAnswers_textBox
            // 
            this.examineeAnswers_textBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.examineeAnswers_textBox.Location = new System.Drawing.Point(320, 256);
            this.examineeAnswers_textBox.Name = "examineeAnswers_textBox";
            this.examineeAnswers_textBox.PlaceholderText = "Ex: A,B,B,C,A,...";
            this.examineeAnswers_textBox.Size = new System.Drawing.Size(192, 25);
            this.examineeAnswers_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(272, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "MagiGrade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(216, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Automated Exam Grading Application";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(120, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(500, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select a file or Enter list of grades to begin!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(120, 192);
            this.label6.MinimumSize = new System.Drawing.Size(0, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 7;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateGrade_Button
            // 
            this.calculateGrade_Button.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateGrade_Button.Location = new System.Drawing.Point(464, 400);
            this.calculateGrade_Button.Name = "calculateGrade_Button";
            this.calculateGrade_Button.Size = new System.Drawing.Size(152, 32);
            this.calculateGrade_Button.TabIndex = 8;
            this.calculateGrade_Button.Text = "Calculate Grade";
            this.calculateGrade_Button.UseVisualStyleBackColor = true;
            this.calculateGrade_Button.Click += new System.EventHandler(this.calculateGrade_Button_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(120, 208);
            this.label7.MinimumSize = new System.Drawing.Size(172, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Correct Answers:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "@\"D:\\\"";
            this.openFileDialog1.Title = "Browse Text Files";
            // 
            // correctAnswersFile_Button
            // 
            this.correctAnswersFile_Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correctAnswersFile_Button.Location = new System.Drawing.Point(528, 208);
            this.correctAnswersFile_Button.Name = "correctAnswersFile_Button";
            this.correctAnswersFile_Button.Size = new System.Drawing.Size(88, 32);
            this.correctAnswersFile_Button.TabIndex = 10;
            this.correctAnswersFile_Button.Text = "Open File";
            this.correctAnswersFile_Button.UseVisualStyleBackColor = true;
            this.correctAnswersFile_Button.Click += new System.EventHandler(this.correctAnswersFile_Button_Click);
            // 
            // examineeAnswersFile_Button
            // 
            this.examineeAnswersFile_Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.examineeAnswersFile_Button.Location = new System.Drawing.Point(528, 256);
            this.examineeAnswersFile_Button.Name = "examineeAnswersFile_Button";
            this.examineeAnswersFile_Button.Size = new System.Drawing.Size(88, 32);
            this.examineeAnswersFile_Button.TabIndex = 11;
            this.examineeAnswersFile_Button.Text = "Open File";
            this.examineeAnswersFile_Button.UseVisualStyleBackColor = true;
            this.examineeAnswersFile_Button.Click += new System.EventHandler(this.examineeAnswersFile_Button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(120, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 23);
            this.label8.TabIndex = 12;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(120, 304);
            this.label9.MinimumSize = new System.Drawing.Size(172, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Examinee Name:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // examineeName_textBox
            // 
            this.examineeName_textBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.examineeName_textBox.Location = new System.Drawing.Point(320, 304);
            this.examineeName_textBox.Name = "examineeName_textBox";
            this.examineeName_textBox.PlaceholderText = "Ex: John Doe";
            this.examineeName_textBox.Size = new System.Drawing.Size(192, 25);
            this.examineeName_textBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(120, 352);
            this.label10.MinimumSize = new System.Drawing.Size(172, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Date Exam Taken:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // examDate
            // 
            this.examDate.Location = new System.Drawing.Point(320, 352);
            this.examDate.Name = "examDate";
            this.examDate.Size = new System.Drawing.Size(192, 23);
            this.examDate.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.examDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.examineeName_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.examineeAnswersFile_Button);
            this.Controls.Add(this.correctAnswersFile_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calculateGrade_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.examineeAnswers_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.correctAnswers_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox correctAnswers_textBox;
        private Label label1;
        private Label label2;
        private TextBox examineeAnswers_textBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button calculateGrade_Button;
        private Label label7;
        private OpenFileDialog openFileDialog1;
        private Button correctAnswersFile_Button;
        private Button examineeAnswersFile_Button;
        private Label label8;
        private Label label9;
        private TextBox examineeName_textBox;
        private Label label10;
        private DateTimePicker examDate;
    }
}