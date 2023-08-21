using FootHub.Context;
using FootHub.Models;
using FootHub.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace FootHub.Services.ServiceClass
{
    public class DashBoradServiceClass : IDashBoard
    {
        private FootHubContext _context;

        public DashBoradServiceClass(FootHubContext context)
        {
            _context = context;
        }

        public Task<List<ProductTable>> GetListOfProduct(int c_id)
        {
            throw new NotImplementedException();
        }
    }
}
