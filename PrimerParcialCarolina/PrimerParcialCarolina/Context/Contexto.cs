using Microsoft.EntityFrameworkCore;
using PrimerParcialCarolina.Models;

namespace PrimerParcialCarolina.Context;

    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options){}

        public virtual DbSet<Autores> Autores { get; set; }
    }
