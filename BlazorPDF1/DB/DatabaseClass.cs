using BlazorPDF1.Data;

namespace BlazorPDF1.DB
{
    public class DatabaseClass
    {
        List<Student> _oStudents = new List<Student>();
        List<MarkSheet> _oMarkSheets = new List<MarkSheet>();

        public DatabaseClass()
        {
            _oStudents = new List<Student>();
            for (int i = 1; i <= 10; i++)
            {
                Student oStudent = new Student();
                oStudent.StudentId = i;
                oStudent.Name = "Stu" + i.ToString();
                oStudent.Role = "100" + i.ToString();
                oStudent.Section = "S" + i.ToString();
                oStudent.Group = "G" + i.ToString();
                oStudent.MarkSheets = this.GetMarkSheets(i);
                _oStudents.Add(oStudent);
            }
        }

        private List<MarkSheet> GetMarkSheets(int studentId)
        {
            Random rnd = new Random();

            _oMarkSheets = new List<MarkSheet>();

            for (int i = 1; i <= 5; i++)
            {
                _oMarkSheets.Add(new MarkSheet()
                {
                    MarkSheetId = i,
                    Subject = "Sub" + rnd.Next(1, 100),
                    Mark = rnd.Next(1, 100),
                    StudentId = studentId
                });                
            }
            return _oMarkSheets;
        }

        public List<Student> GetStudents()
        {
            return _oStudents;
        }
    }
}
