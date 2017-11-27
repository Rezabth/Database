using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Models
{
   public  class ZooContext:DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        public DbSet<Keeper> Keepers { get; set; }
    }
}
