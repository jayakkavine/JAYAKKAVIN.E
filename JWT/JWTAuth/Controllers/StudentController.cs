using JWTAuth.Models;
using JWTAuth.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudent _student;

        public StudentController(IStudent student)
        {
            _student = student;
        }


        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            var students = await _student.GetAllStudents();
            if (students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }


        [HttpGet("{Roll_No}")]

        public async Task<ActionResult<Student>> GetStudentById(int Roll_No)
        {

            try
            {
                Student student = await _student.GetStudentById(Roll_No);
                return Ok(student);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddStudent(Student student)
        {
            var students = await _student.AddStudent(student);
            if (students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }

        [HttpPut]
        public async Task<ActionResult<Student>> UpdateStudent(int Roll_No, Student student)
        {

            try
            {
                var students = await _student.UpdateStudent(Roll_No, student);

                return Ok(students);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpDelete]

        public async Task<ActionResult<List<Student>>> DeleteStudent(int Roll_No)
        {

            try
            {
                var students = await _student.DeleteStudent(Roll_No);

                return Ok(students);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}
