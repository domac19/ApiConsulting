using ApiConsulting.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiConsulting.Context
{
    public class ApiContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public ApiContext()
            :base("name = DefaultConnection")
        {
        }
    }
}