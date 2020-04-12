using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClothingStore.Models
{
    public class UserEntity
    {
        [Key]
        public String UserName { get; set; }
        public String Password { get; set; }

        public UserEntity()
        {
        }

        public UserEntity(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}