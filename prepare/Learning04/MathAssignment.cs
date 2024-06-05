class MathAssignment : Assignment {
    private string textbookSection = "Textbook Section";
    private string problems = "Problems here";

    public MathAssignment (string studentName, string topic, string TextbookSection, string Problems) : base(studentName, topic) {
        textbookSection = TextbookSection;
        problems = Problems;
    }
    public string GetHomeWorkList() {
        return $"Section {textbookSection} Problems {problems}";
        
    }
}