using JWTAuth.Models;
using JWTAuth.Services.Interface;
using Microsoft.EntityFrameworkCore;
using StudentDetails.GlobalExceptions;

namespace JWTAuth.Services.ServiceClass
{
    public class StudentService : IStudent
    {
        public StudentContext? _studentContext;

        public StudentService(StudentContext? studentContext)
        {
            _studentContext = studentContext;
        }

        public async Task<List<Student>> AddStudent(Student student)
        {
            _studentContext.Students.Add(student);
            await _studentContext.SaveChangesAsync();
            return await _studentContext.Students.ToListAsync();
        }

        public async Task<List<Student>> DeleteStudent(int Roll_No)
        {
            var response = await _studentContext.Students.FindAsync(Roll_No);//(x => x.Roll_No == Roll_No)

            if (response == null)
            {
                throw new Exception(StudentDetailsException.ExceptionMessage[0]);
            }
            else
            {
                _studentContext.Remove(response);
                await _studentContext.SaveChangesAsync();
                var responses = await _studentContext.Students.ToListAsync();
                return responses;
            }
        }

        public async Task<List<Student>> GetAllStudents()
        {
            var response = await _studentContext.Students.ToListAsync();
            return response;
        }

        public async Task<Student> GetStudentById(int Roll_No)
        {
            var response = await _studentContext.Students.FindAsync(Roll_No);//(x => x.Roll_No == Roll_No)

            if (response == null)
            {
                throw new Exception(StudentDetailsException.ExceptionMessage[0]);
            }
            else
            {
                return response;
            }
        }

        public async Task<Student> UpdateStudent(int Roll_No, Student student)
        {
            var response = await _studentContext.Students.FindAsync(Roll_No);//(x => x.Roll_No == Roll_No)

            if (response == null)
            {
                throw new Exception(StudentDetailsException.ExceptionMessage[0]);
            }
            else
            {
                response.StudentName = student.StudentName;
                response.Address = student.Address;
                response.Phone = student.Phone;
                await _studentContext.SaveChangesAsync();
                response = await _studentContext.Students.FindAsync(Roll_No);
                // response = await _studentContext.Students.FindAsync(Roll_No);
                return response;
            }
        }
    }
}
