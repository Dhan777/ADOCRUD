using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MvcApplication2.Models
{
    public class DataContext:DbContext
    {
        public DbSet<C_Student> students { get; set; }
    }
}