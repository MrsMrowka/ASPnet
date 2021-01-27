using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ViewResult ListAll() => View(productRepository.Products);
        public ViewResult GetById(int id) => View(productRepository.Products.Single(p => p.ProductID == id));
        public ViewResult List(string category) => View(productRepository.Products.Where(p => p.Category == category));

       
    }
}
