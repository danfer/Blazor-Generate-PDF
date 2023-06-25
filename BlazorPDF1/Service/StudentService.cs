using BlazorPDF1.Data;
using BlazorPDF1.DB;
using BlazorPDF1.IService;

namespace BlazorPDF1.Service
{
    public class StudentService : IStudentService
    {
        DatabaseClass database = new DatabaseClass();
        public Student GetStudent(int studentId)
        {
            return database.GetStudents().FirstOrDefault(x => x.StudentId == studentId);
        }

        public List<Student> GetStudents()
        {
            return database.GetStudents();
        }
    }
}
