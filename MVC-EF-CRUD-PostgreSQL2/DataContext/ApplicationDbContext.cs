using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_EF_CRUD_PostgreSQL2.Models;


namespace MVC_EF_CRUD_PostgreSQL2.DataContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base(nameOrConnectionString: "Myconnection")
        {

        }
        public virtual DbSet<EmpClass> Empobj { get; set; }
    }
}