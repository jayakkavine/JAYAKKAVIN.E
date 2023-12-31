﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Context;
using StudentDetails.GlobalExceptions;
using StudentDetails.Models;
using StudentDetails.Services.Interfaces;

namespace StudentDetails.Services.ServiceClasses
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

        public async Task<List<Student>> GetStudent(int[] student)
        { 

            var response = _studentContext.Students.Where(e => student.Contains(e.Roll_No)).ToList();

            if (response == null)
            {
                throw new Exception(StudentDetailsException.ExceptionMessage[0]);
            }
            else
            {
                return response;
            }
        }

        public async Task<Student> GetStudentById(int Roll_No)
        {
            var response = await _studentContext.Students.FindAsync(Roll_No);//(x => x.Roll_No == Roll_No)

            if(response == null)
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
                response.Student_name = student.Student_name;
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
