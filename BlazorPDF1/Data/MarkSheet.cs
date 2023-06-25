namespace BlazorPDF1.Data
{
    public class MarkSheet
    {
        public int MarkSheetId { get; set; } = 0;
        public string Subject { get; set; } = "";
        public int Mark { get; set; } = 0;
        public string Grade => this.CalculateGrade(this.Mark);
        public int StudentId { get; set; } = 0;

        private string CalculateGrade(int markInt)
        {

            if (markInt >= 80)
            {
                return "A+";
            }
            else if (markInt >= 70)
            {
                return "A";
            }
            else if (markInt >= 60)
            {
                return "A-";
            }
            else if (markInt >= 50)
            {
                return "B";
            }
            else if (markInt >= 40)
            {
                return "C";
            }
            else if (markInt >= 33)
            {
                return "D";
            }
            else
            {
                return "F";
            }

        }
    }
}
