using System;

class Assignment {
    protected string studentName = "John Doe";
    private string topic = "Insert topic here";

    public Assignment(string StudentName, string Topic) {
        studentName = StudentName;
        topic = Topic;
    }   

    public string GetSummary() {
        return $"{studentName} - {topic}";
    }
}