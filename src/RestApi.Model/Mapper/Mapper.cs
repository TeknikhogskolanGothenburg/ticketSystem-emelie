using RestApi.Model.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApi.Model.Mapper
{
    public class Mapper
    {

       
        public Product ProductMap(ProductDto productDto)
        {
            var product = new Product
            {
                ProductName = productDto.ProductName,
                Price = productDto.Price,
                ImageName = productDto.ImageName
            };

            return product; 
        }


        public User UserMap(UserDto userDto)
        {
            var user = new User
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                UserName = userDto.UserName,
                PassWord = userDto.PassWord,
                Email = userDto.Email,
            };

            return user;
        }



    }
}
