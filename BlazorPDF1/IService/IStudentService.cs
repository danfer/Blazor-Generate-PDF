using BlazorPDF1.Data;

namespace BlazorPDF1.IService
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public Student GetStudent(int studentId);
    }
}
