
using FootHub.Context;
using FootHub.Models;
using FootHub.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FootHub.Services.ServiceClass
{
    public class CRUDServiceClass : ICrud
    {
        public FootHubContext _context;

        public CRUDServiceClass(FootHubContext context)
        {
            _context = context;
        }
        /*
        public async Task<List<OcassionTable>> AddOcassion(OcassionTable ocassion)
        {
            _context.OcassionTables.Add(ocassion);
            await _context.SaveChangesAsync();
            return await _context.OcassionTables.ToListAsync();
        }
        */
        public async Task<List<OcassionTable>> GetOcassions()
        {
            var response = await _context.OcassionTables.Where(o => o.IsAvailable == 1).ToListAsync();
            return response;
        }
        /*
        public async Task<List<OcassionTable>> UpdateOcassion(int o_id, OcassionTable ocassion)
        {
            var response = await _context.OcassionTables.FindAsync(o_id);
            response.OName = ocassion.OName;
            await _context.SaveChangesAsync();
            return await _context.OcassionTables.ToListAsync();
        }


        public async Task<List<OcassionTable>> RemoveOcassion(int o_id)
        {
            var response = await _context.OcassionTables.FindAsync(o_id);
            response.IsAvailable = 0;
            await _context.SaveChangesAsync();
            return await _context.OcassionTables.ToListAsync();
            
        }

        public async Task<List<BrandTable>> AddBrand(BrandTable brand)
        {
            _context.BrandTables.Add(brand);
            await _context.SaveChangesAsync();
            return await _context.BrandTables.ToListAsync();
        }
        */
        public async Task<List<BrandTable>> GetBrand()
        {
            return await _context.BrandTables.ToListAsync();
        }
        /*
        public async Task<List<BrandTable>> UpdateBrand(int b_id, BrandTable brand)
        {
            var response = await _context.BrandTables.FindAsync(b_id);
            response.BName = brand.BName;
            await _context.SaveChangesAsync();
            return await _context.BrandTables.ToListAsync();
        }


        public async Task<List<BrandTable>> RemoveBrand(int b_id)
        {
            var response = await _context.BrandTables.FindAsync(b_id);
            _context.Remove(response);
            await _context.SaveChangesAsync();
            return await _context.BrandTables.ToListAsync();

        }

        public async Task<List<ProductTable>> AddProduct(ProductTable product)
        {
            _context.ProductTables.Add(product);
            await _context.SaveChangesAsync();
            return await _context.ProductTables.ToListAsync();
        }
        */
        public async Task<List<ProductTable>> GetProduct()
        {
            return await _context.ProductTables.ToListAsync();
        }



        //public async Task<List<ProductTable>> GetProductById(int id)
        //{
        //    var query = await _context.ProductTables
        //        .Include(p => p.OccasionTable)
        //        .Include(p => p.Brand)
        //        .Include(p => p.ProductType)
        //        .Select(p => new
        //        {
        //            p.PId,
        //            p.PName,
        //            p.PDisc,
        //            p.Size,
        //            p.Price,
        //            p.TotalStock,
        //            p.PImage,
        //            OccasionName = p.Occasion.OName,
        //            BrandName = p.Brand.BName,
        //            TypeName = p.ProductType.TName
        //        })
        //        .ToListAsync();

        //    return query;
        //}
        public async Task<LinkModel> GetProductById(int id)
        {
                var query = await _context.ProductTables.Include(p => p.PId == id)
                    .Select(p => new LinkModel
                    {
                        PId=p.PId,
                        PName=p.PName,
                        PDisc = p.PDisc,
                        Size = p.Size,
                        Price = p.Price,
                        TotalStock = p.TotalStock,
                        PImage = p.PImage,
                        OName = _context.OcassionTables.Where(id => id.OId == p.OId).Select(id=>id.OName).FirstOrDefault(),
                        TName = _context.ProductTypes.Where(id => id.TId == p.TId).Select(id => id.TName).FirstOrDefault(),
                        BName = _context.BrandTables.Where(id => id.BId == p.BId).Select(id => id.BName).FirstOrDefault(),
                    }).FirstOrDefaultAsync();

            return query;
        }


        /*
        public async Task<List<ProductTable>> UpdateProduct(int p_id, ProductTable product)
        {
            var response = await _context.ProductTables.FindAsync(p_id);
            response.PName = product.PName;
            await _context.SaveChangesAsync();
            return await _context.ProductTables.ToListAsync();
        }


        public async Task<List<ProductTable>> RemoveProduct(int p_id)
        {
            var response = await _context.ProductTables.FindAsync(p_id);
            _context.Remove(response);
            await _context.SaveChangesAsync();
            return await _context.ProductTables.ToListAsync();

        }


        public async Task<List<ProductType>> AddProductType(ProductType productType)
        {
            _context.ProductTypes.Add(productType);
            await _context.SaveChangesAsync();
            return await _context.ProductTypes.ToListAsync();
        }
        */
        public async Task<List<ProductType>> GetProductType()
        {
            return await _context.ProductTypes.ToListAsync();
        }
        /*
        public async Task<List<ProductType>> UpdateProductType(int p_id, ProductType productType)
        {
            var response = await _context.ProductTypes.FindAsync(p_id);
            response.TName = productType.TName;
            await _context.SaveChangesAsync();
            return await _context.ProductTypes.ToListAsync();
        }


        public async Task<List<ProductType>> RemoveProductType(int b_id)
        {
            var response = await _context.ProductTypes.FindAsync(b_id);
            _context.Remove(response);
            await _context.SaveChangesAsync();
            return await _context.ProductTypes.ToListAsync();

        }
        */
        

    }
}
