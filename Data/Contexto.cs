﻿using Microsoft.EntityFrameworkCore;
using NovaClimeti.Models;

namespace NovaClimeti.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<EspecialidadeMedica> EspecialidadeMedica { get; set; }
        public DbSet<Medicos> Medicos { get; set; }
        public DbSet<Planos> Planos { get; set; }
        public DbSet<Vaga> Vaga { get; set; }
        public DbSet<Curriculum> Curriculum{ get; set; }
         
    }
}
