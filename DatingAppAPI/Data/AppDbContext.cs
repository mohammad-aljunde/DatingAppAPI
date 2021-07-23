using DatingAppAPI.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppAPI.Data
{
    public class AppDbContext:IdentityDbContext<AppUser,AppRole,string>
    {
        
    }
}
