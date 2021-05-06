using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballPool.Data.Db;

namespace FootballPool.Data
{
    public class WebDbContext : IdentityDbContext<ApplicationUser>
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) : base (options) 
        {
        }
    }
}
