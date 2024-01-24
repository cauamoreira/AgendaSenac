using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSenac
{
    public class BancoDeDados : DbContext
    {
        public DbSet<AgendaCurso> AgendaCursos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Historico> Historicos { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlite("Data Source=BancoDeDados.db");



        }
    }
}

