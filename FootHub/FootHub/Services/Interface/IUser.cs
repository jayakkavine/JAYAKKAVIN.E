using FootHub.Models;

namespace FootHub.Services.Interface
{
    public interface IUser
    {

        Task<List<UserTable>> AddUser(UserTable user);

        Task<UserTable> UpdateUser(int u_id, UserTable user);

        Task<UserTable> GetUserById(int u_id);

        Task<List<UserTable>> GetUsers();

        Task<List<UserTable>> RemoveUser(int u_id);

    }
}
