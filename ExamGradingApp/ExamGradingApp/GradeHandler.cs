using System;
using System.Runtime.CompilerServices;

public class GradeHandler
{
	private string[] correctAnswers;
	private string[] examineeAnswers;
	private int correctCount = 0;
    private int incorrectCount = 0;
	private string incorrectQuestions = "";

    public GradeHandler(string[] correctAnswers, string[] examineeAnswers)
	{
		this.correctAnswers = correctAnswers;
		this.examineeAnswers = examineeAnswers;
	}

	/* Calculates examinee grade and returns a bool value to represent passing/failing */
	public bool calculateGrade()
	{
		bool passed;
		float grade = 0;

		adjustAnswerLength();

        for (int i = 0; i < this.correctAnswers.Length; i++)
		{
			if (this.correctAnswers[i] == this.examineeAnswers[i])
			{
				correctCount++;
				grade++;
            }
			else
			{
				incorrectQuestions += "#" + (i + 1).ToString() + ", ";
                incorrectCount++;
			}
		};
        grade = grade / this.correctAnswers.Length;

		if (grade >= 0.75)
		{
			passed = true;
		}
		else { passed = false; }

        return passed;
    }

    /* 
     * Checks if length of examineeAnswers matches length of correctAnswers.
     * If lengths do not match, examineeAnswers is filled with dummy values to match length of correctAnswers.
	*/
    public void adjustAnswerLength()
	{
        if (this.correctAnswers.Length != this.examineeAnswers.Length)
        {
            List<string> sizeAdjustedAnswers = new List<string>();

            int lengthDifference = this.correctAnswers.Length - this.examineeAnswers.Length;
            for (int i = 0; i < this.correctAnswers.Length; i++)
            {
                if (i >= this.examineeAnswers.Length)
                {
                    sizeAdjustedAnswers.Add("");
                }
                else
                {
                    sizeAdjustedAnswers.Add(this.examineeAnswers[i]);
                }
            }
            this.examineeAnswers = sizeAdjustedAnswers.ToArray();
        }
    }

    /* Returns the numbers of questions that were answered incorrectly */
    public string getIncorrectNumbers()
	{
		try { return incorrectQuestions.Remove(incorrectQuestions.Length - 2, 2); }
		catch { return incorrectQuestions; }
	}

    /* Returns the number of correctly answered questions */
    public int getCorrectCount()
	{
        return correctCount;
    }

	/* Returns the number of incorrectly answered questions */
	public int getIncorrectCount()
	{
        return incorrectCount;
    }

	/* Returns a string version (comma separated) of the examinee's answers*/
	public string getExamineeAnswers()
	{
		string str_answers = "";
		int counter = 0;
		foreach (string answer in this.examineeAnswers)
		{
			if (counter == this.examineeAnswers.Length - 1)
			{
                str_answers += answer;
            }
			else { str_answers += answer + ","; }

			counter++;
		}
		return str_answers;
	}
}
