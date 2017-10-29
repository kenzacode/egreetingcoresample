using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace halloween.Model
{
    public class bridgeDBContext : DbContext
    {
        //DEFAULT CONSTRUCTOR
        public bridgeDBContext () { }


        //CONSTRUCTOR
        public bridgeDBContext (DbContextOptions<bridgeDBContext> options) : base(options) { }

        //CUSTOMIZE BASE ON EXISTING MODEL(S)
       public DbSet<Greetings> Greetings { get; set; }
    }
}
