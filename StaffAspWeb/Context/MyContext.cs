using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StaffAspWeb.Context
{
    public class MyContext:DbContext
    {
        public MyContext(): base("Server=.;Database=OilStaff;Trusted_Connection=True;")
        {

        }
        public DbSet<StaffAspWeb.Models.Staffclass> staff { get; set; }
    }
}