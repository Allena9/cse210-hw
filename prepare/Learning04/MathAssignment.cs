using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string studentName, string title, string textbookSections, string problems) : base(studentName, title)
    {
        _textbookSection = textbookSections;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}