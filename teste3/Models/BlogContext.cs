using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
//using Mysql.

namespace teste3.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base()
        {
            
            Database.Connection.ConnectionString =
            "server=127.0.0.1;uid=dev2;" +
            "pwd=@@dev2##;database=c_sharp";
        }

        public DbSet<Posts> Posts { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
    }
}