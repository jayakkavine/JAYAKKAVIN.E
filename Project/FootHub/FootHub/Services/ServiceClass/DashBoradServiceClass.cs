using FootHub.Contexts;
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


        public async Task<List<ProductTable>> GetListOfProduct(int c_id)
        {
            var response = _context.ProductTables.Where(pr => _context.ProductLinkTables
                                                     .Where(category => category.CId == c_id)
                                                     .Select(category => category.PId)
                                                     .Contains(pr.PId)
                                                     ).ToList();
            return response;
        }
    }
}
