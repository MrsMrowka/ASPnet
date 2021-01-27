using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Consumes("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ApiProductController : Controller
    {

        private IProductRepository repository;
        public ApiProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        // Pobranie listy produktów 
        [HttpGet]
        public IEnumerable<Product> Get() => repository.Products;

        // pobranie pojedynczego produktu po ID 
        [HttpGet("{ProductId}")]
        public ActionResult<Product> Get(int ProductId)
        {
         var product = repository.Products.FirstOrDefault(p => p.ProductID == ProductId);
            if (product == null)
                return NotFound();
            return Ok(product);
        }


        // Dodanie produktu
       [HttpPost]
        public void Post([FromBody] Product product) =>
        repository.SaveProduct(product);
       
        // Edycja produktu 
        [HttpPut]
        public void Put([FromBody] Product product) =>
            repository.SaveProduct(product);

        // Usunięcie produktu 
        [HttpDelete("{ProductId}")]
        public ActionResult<Product> Delete(int ProductId)
        {
            var product = repository.DeleteProduct(ProductId);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}
