using System.Globalization;

namespace ExamGradingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateGrade_Button_Click(object sender, EventArgs e)
        {
            string[] correctAnswers = new string[] { };
            string[] examineeAnswers = new string[] { };

            string inputCorrectAnswers = correctAnswers_textBox.Text;
            string inputExamineeAnswers = examineeAnswers_textBox.Text;
            string examineeName = examineeName_textBox.Text;
            string date = examDate.Value.ToString();

            // Allow answers to be read from .txt file or entered manually
            if (inputCorrectAnswers.Contains(".txt"))
            {
                correctAnswers = FileIO.readFile(inputCorrectAnswers);
            }
            else { correctAnswers = inputCorrectAnswers.Split(","); }

            if (inputExamineeAnswers.Contains(".txt"))
            {
                examineeAnswers = FileIO.readFile(inputExamineeAnswers);
            }
            else { examineeAnswers = inputExamineeAnswers.Split(","); }

            // Calculate exam grade
            GradeHandler grader = new GradeHandler(correctAnswers, examineeAnswers);
            bool passed = grader.calculateGrade();
            string outcome;

            // Display messages based on the examinee's passing/failing
            if (passed) 
            { 
                MessageBox.Show(examineeName + " Passed the Exam!");
                outcome = "passed";
            }
            else 
            { 
                MessageBox.Show(examineeName + " Failed the Exam!");
                outcome = "failed";
            }
            string message = "Total Correctly Answered Questions: " + grader.getCorrectCount() + "\n" +
                             "Total Incorrectly Answered Questions: " + grader.getIncorrectCount() + "\n" +
                             "Questions Answered Incorrectly: " + "\n" + grader.getIncorrectNumbers();
            MessageBox.Show(message);

            // Store exam information in a .txt file
            string filename = examineeName + ".txt";
            string[] content = { examineeName, grader.getExamineeAnswers(), outcome, date };
            FileIO.createFile(filename, content);
        }

        /* Handles open file button click event for correct answers */
        private void correctAnswersFile_Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                correctAnswers_textBox.Text = openFileDialog1.FileName;
            }
        }

        /* Handles open file button click event for examinee's answers */
        private void examineeAnswersFile_Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                examineeAnswers_textBox.Text = openFileDialog1.FileName;
            }
        }
    }
}