using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestApi.Model;
using RestApi.Model.DTO;
using RestApi.Model.Mapper;
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


        [HttpPost("ValidateUser")]
        public IActionResult ValidateUser([FromBody] User user)
        {

            var result = _userRepository.GetByUsernameAndPassword(user.UserName, user.PassWord);

            if (result != null)
            {
                return Ok();
            }
            return NotFound();
           
        }

        // POST api/values
        [HttpPost("CreateUser")]
        public IActionResult CreateUser([FromBody] UserDto user)
        {
            
             var userMapper = new Mapper();
             var mappedUser = userMapper.UserMap(user);

             _userRepository.CreateUser(mappedUser);

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
            _userRepository.DeleteUser(user);
        }
    }
}

