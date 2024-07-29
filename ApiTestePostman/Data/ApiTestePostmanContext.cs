using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiTestePostman.Models;

namespace ApiTestePostman.Data
{
    public class ApiTestePostmanContext : DbContext
    {
        public ApiTestePostmanContext (DbContextOptions<ApiTestePostmanContext> options)
            : base(options)
        {
        }

        public DbSet<ApiTestePostman.Models.Produto> Produto { get; set; }
    }
}
