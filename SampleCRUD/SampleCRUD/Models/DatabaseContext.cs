using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleCRUD.Models
{
    public class DatabaseContext :DbContext
    {
        public DbSet<Users> users { get; set; }
    }
}