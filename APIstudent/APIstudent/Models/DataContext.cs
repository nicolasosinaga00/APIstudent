using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APIstudent.Models
{
    public class DataContext:DbContext 
    {
        public DataContext():base("DefaultConecction")
        {

        }

        public System.Data.Entity.DbSet<APIstudent.Models.Student> Students { get; set; }
    }
}