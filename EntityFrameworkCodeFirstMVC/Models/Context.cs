using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeFirstMVC.Models
{
    public class Context:DbContext
    {
        public DbSet<Category> Categories { get; set; } 
    }
}