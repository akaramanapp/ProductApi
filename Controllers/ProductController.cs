using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/product
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            List<Product> productList = new List<Product>(){
                new Product(){
                    Name="Klavye",
                    Category="Donanım",
                    Price= 120
                },
                new Product(){
                    Name="Kulaklık",
                    Category="Donanım",
                    Price= 20
                },
                new Product(){
                    Name="Microsoft Windows 95",
                    Category="Lisans",
                    Price= 499
                }
            };
            return productList;
        }
    }

    public class Product {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
