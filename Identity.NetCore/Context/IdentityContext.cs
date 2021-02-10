using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.NetCore.Context
{
    public class IdentityContext : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-I0M32R9\\SQLEXPRESS; database=Identity.NetCore ; integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
