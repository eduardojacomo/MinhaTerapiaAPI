using Microsoft.EntityFrameworkCore;
using minhaterapia.Data.Map;
using minhaterapia.Models;

namespace minhaterapia.Data;

public class MinhaTerapiaDBContex : DbContext
{
	public MinhaTerapiaDBContex(DbContextOptions<MinhaTerapiaDBContex>options)
		:base(options)
	{
	}

	public DbSet<PacientesModel> Pacientes { get; set;}
	public DbSet<TerapiaModel> Terapia { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
		modelBuilder.ApplyConfiguration(new PacienteMap());
        modelBuilder.ApplyConfiguration(new TerapiaMap());
        base.OnModelCreating(modelBuilder);
    }
}
