using System;
class StudentMarks
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        double Subject1Marks = 0;
        double Subject2Marks = 0;
        double Subject3Marks = 0;

        Console.Write("Enter student name:");
        string StudentName = Console.ReadLine();
        try
        {
            Console.Write("Enter marks for Subject 1:");
            Subject1Marks = double.Parse(Console.ReadLine());
            Console.Write("Enter marks for Subject 2:");
            Subject2Marks = double.Parse(Console.ReadLine());
            Console.Write("Enter marks for Subject 3:");
            Subject3Marks = double.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Invalid Marks Enterd");
            return;
        }


        Console.WriteLine("===== STUDENT RESULTS =====");
        double TotalMarks = Subject1Marks + Subject2Marks + Subject3Marks;
        double average = TotalMarks / 3;
        string pass = "FAIL";
        if (average >= 50)
        {
            pass = "PASS";
        }
        Console.WriteLine("Student Name: " + StudentName);
        Console.WriteLine("Total Marks: " + TotalMarks);
        Console.WriteLine("Average Marks: " + average);
        Console.WriteLine("Results: " + pass);
        Console.WriteLine("Date Issued: " + now);
    }
}