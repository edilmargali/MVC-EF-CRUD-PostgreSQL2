﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_EF_CRUD_PostgreSQL2.Models
{


    [Table("emp", Schema = "public")]
    public class EmpClass
    {
        [Key]

        public int empid { get; set; }

        public string empnombre { get; set; }

        public string email { get; set; }

        public int salario { get; set; }
    }


}