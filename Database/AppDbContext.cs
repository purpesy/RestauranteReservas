using Microsoft.EntityFrameworkCore;
using teste_vs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_vs.Database;

internal class AppDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Mesa> Mesas { get; set; }
    public DbSet<Reserva> Reservas { get; set; } // isso faz com que o database(ultimo nome do codigo) entre no modelo(classe) que estra dentro das <> 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "Server=localhost;Database=db_restaurante;User=root;Password= ;",
            new MySqlServerVersion(new Version(8, 0, 23))
        );
    }
}