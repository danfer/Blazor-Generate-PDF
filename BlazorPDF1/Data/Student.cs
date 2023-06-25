namespace BlazorPDF1.Data
{
    public class Student
    {
        public int StudentId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Role { get; set; } = "";
        public string Section { get; set; } = "";
        public string Group { get; set; } = "";
        public List<MarkSheet> MarkSheets { get; set; } = new List<MarkSheet>();
    }
}
