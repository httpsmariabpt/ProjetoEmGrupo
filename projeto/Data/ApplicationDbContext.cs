using System.Reflection.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using projeto.Models;

namespace projeto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animais { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Consulta> Consultas { get; set; }

        public DbSet<Veterinario> Veterinarios { get; set; }

        public DbSet<Especialidade> Especialidades { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Aqui, nós dizemos como irá se chamar a tabela 
            //no banco de dados
            
            base.OnModelCreating(builder);
            // Exemplo de configuração sem cascata
            
            builder.Entity<Animal>().ToTable("Animais");
            builder.Entity<Cliente>().ToTable("Clientes");
            builder.Entity<Consulta>().ToTable("Consultas");
            builder.Entity<Veterinario>().ToTable("Veterinarios");
            builder.Entity<Especialidade>().ToTable("Especialidades");

            //Depois que você cria, vocE^pode adicionar ao banco de dados
            //Utilizando as migrations do Entity Framework
        }

    }
}
