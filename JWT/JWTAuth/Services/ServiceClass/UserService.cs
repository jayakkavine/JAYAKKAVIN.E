using JWTAuth.Models;
using JWTAuth.Services.Interface;
using Microsoft.EntityFrameworkCore;
using StudentDetails.GlobalExceptions;
using System.Linq;

namespace JWTAuth.Services.ServiceClass
{
    public class UserService : IUser
    {
        public StudentContext _context;

        public UserService(StudentContext context)
        {
            _context = context;
        }

        public async Task<List<User>> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByName(string username)
        {
            return await _context.Users.FindAsync(username);
        }

        public async Task<List<User>> RemoveUser(string userName)
        {
            var responce = await _context.Users.FindAsync(userName);
            if(responce != null)
            {
                _context.Users.Remove(responce);
                _context.SaveChanges();
                return await _context.Users.ToListAsync();
            }
            else
            {
                throw new Exception(StudentDetailsException.ExceptionMessage[1]);
            }
        }

        public async Task<User> UpdateUser(string userName, User user)
        {
            var responce =  await _context.Users.FindAsync(userName);
            if(responce != null)
            {
                responce.Password = user.Password;
                responce.Role = user.Role;
                await _context.SaveChangesAsync();
                return await _context.Users.FindAsync(userName);
            }
            else
            {
                throw new Exception(StudentDetailsException.ExceptionMessage[0]);
            }
            
        }
    }
}
