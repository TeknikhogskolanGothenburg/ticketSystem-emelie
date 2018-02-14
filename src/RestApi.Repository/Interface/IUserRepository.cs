using RestApi.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApi.Repository.Interface
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User User);
        User GetUserrById(int id);
        User GetUserByEmail(string Email);
        List<User> GetAllUser();
    }
}
