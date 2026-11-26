
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        // In-memory product list
        private static List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 50000,
                Stock = 10
            },
            new Product
            {
                Id = 2,
                Name = "Mobile",
                Price = 20000,
                Stock = 15
            }
        };

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            return Ok(products);
        }

        // GET: api/products/1
        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/products
        [HttpPost]
        public ActionResult<Product> AddProduct(Product product)
        {
            product.Id = products.Count == 0
                ? 1
                : products.Max(p => p.Id) + 1;

            products.Add(product);

            return CreatedAtAction(
                nameof(GetProductById),
                new { id = product.Id },
                product
            );
        }

        // PUT: api/products/1
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Stock = updatedProduct.Stock;

            return NoContent();
        }

        // DELETE: api/products/1
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            products.Remove(product);

            return NoContent();
        }
    }
}
