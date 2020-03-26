using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalCtrlMedico.Models
{
    public class ClassIngresos
    {
        [Key]
        public int ID_Ingresos { get; set; }

        [Required]
        public int ID_Habitacion { get; set; }
        [ForeignKey("ID_Habitacion")]
        public ClassHabitaciones Habitaciones { get; set; }

        [Required]
        public int ID_Paciente { get; set; }
        [ForeignKey("ID_Paciente")]
        public ClassPaciente Paciente { get; set; }

        [Required]
        public string Fecha_Ingreso { get; set; }

    }
}