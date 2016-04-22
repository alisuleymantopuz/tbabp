using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.DataContext;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/Products")]
    public class ProductsController : ApiController
    {
        public readonly NorthwindDWHEntities NorthwindDWHContext;

        public ProductsController()
        {
            NorthwindDWHContext = new NorthwindDWHEntities();
        }

        [Route("All")]
        public IEnumerable<ProductInfoViewModel> GetAll()
        {
            var resultQuery = NorthwindDWHContext.Products.Select(x => new ProductInfoViewModel()
            {
                Id = x.ProductID,
                Name = x.ProductName,
                UnitPrice = x.UnitPrice
            });

            return resultQuery.ToList();
        }
    }
}
