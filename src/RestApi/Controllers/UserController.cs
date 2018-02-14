using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestApi.Model;
using RestApi.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET api/values
        [HttpGet]
        public List<User> Get()
        {
            return _userRepository.GetAllUser();

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userRepository.GetUserById(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {

            _userRepository.CreateUser(user);

            return Ok();
        }

        // PUT api/values/5
        [HttpPut()]
        public void Put([FromBody]User user)
        {
            _userRepository.UpdateUser(user);
        }

        // DELETE api/values/5
        [HttpDelete()]
        public void Delete(User user)
        {
            _userRepository.DelteUser(User);
        }
    }
}

