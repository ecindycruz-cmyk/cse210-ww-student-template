using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string nameStudent, string topic, string title)
        : base(nameStudent, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string nameStudent = GetNameStudent();
        return $"{_title} by {nameStudent}";
    }
        
}