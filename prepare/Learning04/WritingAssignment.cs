class WritingAssignment : Assignment {
    private string title = "Insert title here";
    
    public WritingAssignment(string studentName, string topic, string Title) : base(studentName, topic){
        title = Title;
    }

    public string GetWritingInformation() {
        return $"{title} by {studentName}";
    }
}