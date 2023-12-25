using blogtask25thdecember;
using blogtask25thdecember.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
	
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
	{
		
	}
	
	public DbSet<Cover> Covers { get; set; }
}