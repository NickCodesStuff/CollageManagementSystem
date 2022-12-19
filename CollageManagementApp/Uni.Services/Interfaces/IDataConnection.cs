
using UniManagement.Library;

namespace Uni.Services.Interfaces
{
    public interface IDataConnection
    {
        List<Admin> GetAllAdmins();
        List<Courses> GetAllCourses();
        List<Student> GetAllStudents();
        List<Take> GetAllTakes();
        List<Teacher> GetAllLecturers();

    }
}
