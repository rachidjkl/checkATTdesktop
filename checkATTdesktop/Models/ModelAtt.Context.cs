﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace checkATTdesktop.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CheckAttEntities : DbContext
    {
        public CheckAttEntities()
            : base("name=CheckAttEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Clase> Clase { get; set; }
        public virtual DbSet<Clase_Modulo> Clase_Modulo { get; set; }
        public virtual DbSet<Falta> Falta { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Matricula> Matricula { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<Pasar_Lista> Pasar_Lista { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<UF> UF { get; set; }
    }
}