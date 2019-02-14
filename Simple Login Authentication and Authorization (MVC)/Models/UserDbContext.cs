using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Simple_Login_Authentication_and_Authorization__MVC_.Models
{
    public class UserDbContext :DbContext
    {
        public UserDbContext ()  : base("name = objcon"){ }
        public DbSet <Users> Users { get ;set;}
    }
}