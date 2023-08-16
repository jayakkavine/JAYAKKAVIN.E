using JWTAuth.Models;

namespace JWTAuth.Services.Interface
{
    public interface IStudent
    {
            Task<List<Student>> GetAllStudents();

            Task<Student> GetStudentById(int Roll_No);
            Task<List<Student>> AddStudent(Student student);

            Task<Student> UpdateStudent(int Roll_No, Student student);

            Task<List<Student>> DeleteStudent(int Roll_No);
        
    

    }
}
