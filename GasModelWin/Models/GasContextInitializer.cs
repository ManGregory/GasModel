﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasModelWin.Models
{
    class GasContextInitializer : DropCreateDatabaseAlways<GasContext>
    {
        protected override void Seed(GasContext context)
        {
            base.Seed(context);
            context.Users.AddRange(new[]
            {
                new User {Id = 1, IsAdmin = true, Name = "Admin"},
                new User {Id = 2, IsAdmin = false, Name = "User"} 
            });
            context.UserLoginses.AddRange(new[]
            {
                new UserLogins {Login = "admin", Password = "admin", UserId = 1},
                new UserLogins {Login = "user", Password = "user", UserId = 2}
            });
        }
    }
}
