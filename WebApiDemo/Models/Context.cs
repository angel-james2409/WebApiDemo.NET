using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApiDemo.Models
{
    public class Context: DbContext
    {
        public Context() : base("cs") { }


        public DbSet<Customer> customer { get; set; }
    
}
}