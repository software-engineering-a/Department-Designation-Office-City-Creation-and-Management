using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SEPROJECT.Models;
using System.Data.Entity;

namespace SEPROJECT.Context
{
   
        public class dataContext : DbContext
        {
            public dataContext() : base("conn")
            {

            }
            public DbSet<department> departments { get; set; }
            public DbSet<designation> designations { get; set; }
            public DbSet<office> offices { get; set; }
        }
    
}