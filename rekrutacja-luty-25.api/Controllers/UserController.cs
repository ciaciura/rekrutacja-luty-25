using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rekrutacja_luty_25.commons.Models;
using rekrutacja_luty_25.Data;
using Microsoft.AspNetCore.Mvc;

namespace rekrutacja_luty_25.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public User Get(int id)
        {
            var db = new DatabaseContext();
            var users = db.Users.ToList();
            User user = null; 
            foreach (var u in users)
            {
                if (u.Id == id)
                {
                    user = u;
                }
            }
            return user;
        }
    }
}