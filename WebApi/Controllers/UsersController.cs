using Business.Abstract;
using Business.Concrete;
using Entities;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var users = _userService.GelAll();
            if (users == null) return BadRequest("hata");
            return Ok(users);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var user = _userService.Get(id);
            if (user == null) return BadRequest("hata");
            return Ok(user);
        }

        [HttpGet("getbyemailandpassword")]
        public IActionResult GetByEmailAndPassword(string email, string password)
        {
            var user = _userService.GetByEmailAndPassword(email,password);
            if (user == null) return BadRequest("hata");
            return Ok(user);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            user = _userService.Add(user);
            if (user == null) return BadRequest("hata");
            return Ok(user);
        }


        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var user = _userService.Get(id);
            user = _userService.Delete(user);
            if (user == null) return BadRequest("hata");
            return Ok(user);
        }

        [HttpPut("update")]
        public IActionResult Update(User user)
        {
            user = _userService.Update(user);
            if (user == null) return BadRequest("hata");
            return Ok(user);
        }

    }
}