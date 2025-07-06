using MainProject.Modals;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MainProject.Controllers
{
    [Route("api/Products")]
    [ApiController]
    public class ProductController : Controller
    {
        Product[] products = new Product[]
        {
            new Product {Id = 1 , Name="Mechanical Keyboard", Category="Electronics",Price=60, Picture="https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/Keyboard_Construction.JPG/1200px-Keyboard_Construction.JPG"},
            new Product {Id = 2 , Name="Aesop's Fables", Category="Books",Price=29.99M , Picture="https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/Keyboard_Construction.JPG/1200px-Keyboard_Construction.JPG"},
            new Product {Id = 3 , Name="Stand Mixer", Category="Electronics",Price=49.99M , Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/Keyboard_Construction.JPG/1200px-Keyboard_Construction.JPG"},
        };
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }
        [HttpGet("{id}", Name ="GetProducts")]
        public IActionResult GetById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);
        }

    }
}
