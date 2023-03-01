using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recap.Business.Abstract;
using Recap.Entities;

namespace RecapUI.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("[controller]/List")]
        public IActionResult List()
        {
            try
            {
                return Ok(_categoryService.GetActives());
            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [HttpGet("[controller]/Get")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return Ok(_categoryService.GetById(id));
            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [HttpPost("[controller]/Add")]
        public IActionResult Add([FromBody] Category category)
        {
            try
            {
                _categoryService.Add(category);
                return NoContent();
            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [HttpPut("[controller]/Update")]
        public IActionResult Update([FromBody] Category category)
        {
            try
            {
                _categoryService.Update(category);
                return NoContent();
            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [HttpDelete("[controller]/Delete")]
        public IActionResult Delete([FromBody] Category category)
        {
            try
            {
                _categoryService.Delete(category);
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
