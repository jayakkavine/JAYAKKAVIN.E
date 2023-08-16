using JWTAuth.Models;

namespace JWTAuth.Services.Interface
{
    public interface IUser
    {
        Task<User> GetUserByName(string username);
        Task<List<User>> AddUser(User user);
        Task<User> UpdateUser(string userName, User user);
        Task<List<User>> RemoveUser(string userName);
    }
}
