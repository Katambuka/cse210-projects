using System;

public class Assignment
{
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // We will provide Getters for our private member variables so they can be accessed
    // later both outside the class as well is in derived classes.
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
public class Assignment
{
    private readonly string _studentName;
        private readonly string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // We will provide Getters for our private member variables so they can be accessed
    // later both outside the class as well is in derived classes.
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Learning04 World!");
            // Create a base "Assignment" object
            Assignment a1 = new("Samuel Bennett", "Multiplication");
            Console.WriteLine(a1.GetSummary());

            // Now create the derived class assignments
            MathAssignment a2 = new("Roberto Rodriguez","Fractions","7.3", "8-19");
            Console.WriteLine(a2.GetSummary());
            Console.WriteLine(a2.GetHomeworkList());

            WritingAssignment a3 = new("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine(a3.GetSummary());
            Console.WriteLine(a3.GetWritingInformation());
        }
    }
}
public class WritingAssignment : Assignment
{
    private readonly string _title;

    // Notice the syntax here that the WritingAssignment constructor has 3 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        // Here we set any variables specific to the WritingAssignment class
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}