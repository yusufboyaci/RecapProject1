using Microsoft.AspNetCore.Mvc;
using Recap.Business.Abstract;
using Recap.Entities;

namespace RecapUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("[controller]/List")]
        public IActionResult List()
        {
            try
            {
                return Ok(_productService.GetActives());
            }
            catch(Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [HttpGet("[controller]/Get")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return Ok(_productService.GetById(id));
            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [HttpPost("[controller]/Add")]
        public IActionResult Add([FromBody] Product product)
        {
            try
            {
                _productService.Add(product);
                return NoContent();
            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [HttpPut("[controller]/Update")]
        public IActionResult Update([FromBody] Product product)
        {
            try
            {
                _productService.Update(product);
                return NoContent();
            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [HttpDelete("[controller]/Delete")]
        public IActionResult Delete([FromBody] Product product)
        {
            try
            {
                _productService.Delete(product);
                return NoContent();
            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
