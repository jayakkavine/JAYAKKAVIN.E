﻿using FootHub.Contexts;
using FootHub.Models;
using FootHub.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace FootHub.Services.ServiceClass
{
    public class UserService : IUser
    {
        public FootHubContext _context;

        public UserService(FootHubContext context)
        {
            _context = context;
        }

        public async Task<List<UserTable>> AddUser(UserTable student)
        {
            _context.UserTables.Add(student);
            await _context.SaveChangesAsync();
            return await _context.UserTables.ToListAsync();
        }

        public async Task<List<UserTable>> RemoveUser(int Roll_No)
        {
            var response = await _context.UserTables.FindAsync(Roll_No);//(x => x.Roll_No == Roll_No)

                _context.UserTables.Remove(response);
                await _context.SaveChangesAsync();
                var responses = await _context.UserTables.ToListAsync();
                return responses;
            
        }

        public async Task<List<UserTable>> GetUsers()
        {
            var response = await _context.UserTables.ToListAsync();
            return response;
        }

        public async Task<UserTable> GetUserById(int Roll_No)
        {
            var response = await _context.UserTables.FindAsync(Roll_No);//(x => x.Roll_No == Roll_No)

                return response;
            
        }

        public async Task<UserTable> UpdateUser(int Roll_No, UserTable student)
        {
            var response = await _context.UserTables.FindAsync(Roll_No);//(x => x.Roll_No == Roll_No)

                response.UName = student.UName;
                await _context.SaveChangesAsync();
                response = await _context.UserTables.FindAsync(Roll_No);
                // response = await _studentContext.Students.FindAsync(Roll_No);
                return response;
        }

    }
}