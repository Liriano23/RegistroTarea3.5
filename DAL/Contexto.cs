using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using RegistroInscripcion.Entidades;
using Microsoft.EntityFrameworkCore;
namespace RegistroInscripcion.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Inscripciones> Inscripciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-C14UJCF; Database = InscripcionesDB1; Trusted_Connection = True;");
        }
    }
}
