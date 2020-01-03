using Catalog.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public CatalogContext(DbContextOptions<CatalogContext> options)
            : base(options)
        {

        }
    }
}
