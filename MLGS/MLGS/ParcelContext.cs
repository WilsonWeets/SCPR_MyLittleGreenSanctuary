using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MLGS
{
    public class ParcelContext : DbContext
    {
        public ParcelContext(DbContextOptions<ParcelContext> options) : base(options)
        {

        }

        public DbSet<ParcelData> ParcelsData { get; set;}

    }
}
