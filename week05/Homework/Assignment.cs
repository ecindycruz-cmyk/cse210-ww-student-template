using System;

public class Assignment
{
    private string _nameStudent;
    private string _topic;

    public Assignment(string nameStudent, string topic)
    {
        _nameStudent = nameStudent;
        _topic = topic;
    }

    public string GetNameStudent()
    {
        return _nameStudent;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _nameStudent + "-" + _topic;
    }
}