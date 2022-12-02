using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;




namespace WebPasajero.Context
{
    namespace EntityFrameworkExample.Data
    {

        public class SistemaWebEmpleadoContext : DbContext
        {
            public SistemaWebEmpleadoContext(DbContextOptions<SistemaWebEmpleadoContext> options)
             : base(options)
            {
            }

            public DbSet<Empleado> Empleados { get; set; }
        }
    }
}
