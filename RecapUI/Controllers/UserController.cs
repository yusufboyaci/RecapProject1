using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recap.Business.Abstract;
using Recap.Entities;

namespace RecapUI.Controllers
{

    public class UserController : Controller
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [Authorize]
        [HttpGet("[controller]/List")]
        public IActionResult List()
        {
            try
            {
                return Json(_userService.GetActives());
            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [Authorize]
        [HttpGet("[controller]/Get")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return Json(_userService.GetById(id));
            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [HttpPost("[controller]/Add")]
        public IActionResult Add([FromBody] User user)
        {
            try
            {
                if (_userService.CheckCredential(user.Username))
                {
                    return Json(false);
                }
                else
                {
                    _userService.Add(user);
                    return Json(true);
                }
            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [Authorize]
        [HttpPut("[controller]/Update")]
        public IActionResult Update([FromBody] User user)
        {
            try
            {
                _userService.Update(user);
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [Authorize]
        [HttpDelete("[controller]/Delete")]
        public IActionResult Delete([FromBody] User user)
        {
            try
            {
                _userService.Delete(user);
                return NoContent();
            }
            catch (Exception)
            {
                return BadRequest("Beklenmedik bir hata oluştu");
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
