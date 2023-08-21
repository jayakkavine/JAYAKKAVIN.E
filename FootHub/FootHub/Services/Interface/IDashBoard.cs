using FootHub.Models;

namespace FootHub.Services.Interface
{
    public interface IDashBoard
    {
        Task<List<ProductTable>> GetListOfProduct(int c_id);
    }
}
