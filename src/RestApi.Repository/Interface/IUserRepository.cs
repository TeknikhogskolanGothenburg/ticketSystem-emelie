using RestApi.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApi.Repository
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User User);
        User GetUserById(int id);
        User GetUserByEmail(string Email);
        List<User> GetAllUser();
        User GetByUsernameAndPassword(string username, string password);
    }
}
