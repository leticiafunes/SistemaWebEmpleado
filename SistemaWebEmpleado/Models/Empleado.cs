using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using WebEscuelaMVC.Validation;

namespace SistemaWebEmpleado.Models
{
   

        [Table("Empleado")]
        public class Empleado
        {
            [Key]
            public int EmpleadoId { get; set; }

           
            [Required(ErrorMessage = "Ingrese Nombre por favor")]

            public string Nombre { get; set; }

            [Required(ErrorMessage = "Ingrese Apellido por favor")]

            public string Apellido { get; set; }

            [Required(ErrorMessage = "Ingrese DNI por favor")]
            public string DNI { get; set; }

            [Required(ErrorMessage = "Ingrese Legajo por favor")]
            [CheckValidLegajo]
            public string Legajo { get; set; }

            [Required(ErrorMessage = "Ingrese Titulo por favor")]
            public string Titulo { get; set; }








        
    }
}
