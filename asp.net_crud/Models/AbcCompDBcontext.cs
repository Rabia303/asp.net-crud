using Microsoft.EntityFrameworkCore;

namespace asp.net_crud.Models
{
	public class AbcCompDBcontext : DbContext
	{
		public AbcCompDBcontext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Employee> Employees { get; set; }

	}
}
