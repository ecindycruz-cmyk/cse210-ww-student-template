using System;
using System.Collections.Generic;

public class Comment

{
    private string _namePerson;
    private string _textComment;

    public Comment(string NamePerson, string TextComment)
    {
        _namePerson = NamePerson;
        _textComment = TextComment;
    }

    //Getters: name of the person and text of the comments.
    public string GetNamePerson()
    {
        return _namePerson;
    }

    public string GetTextComment()
    {
        return _textComment;
    }

    //Setters: name of the person and text of the comments.
    public void SetNamePerson(string NamePerson)
    {
        _namePerson = NamePerson;
    }

    public void SetTextComment(string TextComment)
    {
        _textComment = TextComment;
    }
}
