using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ProductInfoViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? UnitPrice { get; set; }
    }

    public class ProductDetailInfoViewModel : ProductInfoViewModel
    {
        public int? UnitsInStock { get; set; }
        public int? CategoryId { get; set; }
    }
}