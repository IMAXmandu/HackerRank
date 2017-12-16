class Student : Person
{
    private int[] testScores;

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string first, string last, int id, int[] scores)
        : base(first, last, id)
    {
        testScores = scores;
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    public string Calculate()
    {
        int sum = 0;
        foreach (var item in testScores)
        {
            sum += item;
        }
        int grade = sum / testScores.Length;

        if (90 <= grade && grade <= 100) return "O";
        else if (80 <= grade && grade < 90) return "E";
        else if (70 <= grade && grade < 80) return "A";
        else if (55 <= grade && grade < 70) return "P";
        else if (40 <= grade && grade < 55) return "D";
        else return "T";
    }
}