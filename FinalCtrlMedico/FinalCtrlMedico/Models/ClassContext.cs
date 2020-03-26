using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalCtrlMedico.Models
{
    public class ClassContext: DbContext
    {
        public DbSet<ClassPaciente> Pacientes { get; set; }
        public DbSet<ClassMedico> Medicos { get; set; }
        public DbSet<ClassHabitaciones> Habitaciones { get; set; }
        public DbSet<ClassIngresos> Ingresos { get; set; }
        public DbSet<ClassCitas> Citas { get; set; }
        public DbSet<ClassAltas> Altas { get; set; }
    }
}