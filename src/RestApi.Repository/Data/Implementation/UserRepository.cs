using RestApi.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private DataBaseContext _context;

        public UserRepository(DataBaseContext context) => _context = context;

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(User user) => _context.Users.Remove(user);


        public List<User> GetAllUser() => _context.Users.OrderBy(u => u.FirstName).ToList();

        public User GetByUsernameAndPassword(string username, string password) => _context.Users.Where(u => u.UserName == username && u.PassWord == password).FirstOrDefault();

        public User GetUserByEmail(string Email) => _context.Users.FirstOrDefault(u => u.Email == Email);
       

        public User GetUserById(int id) => _context.Users.FirstOrDefault(u => u.Id == id);


        public void UpdateUser(User user) => _context.Users.Update(user);




    }
}
