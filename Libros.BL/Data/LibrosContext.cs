using System.Data.Entity;
using Libros.BL.Model;

namespace Libros.BL.Data
{
	public class LibrosContext : DbContext
	{
		public LibrosContext() : base ("LibrosContext")
		{
				
		}
		public DbSet<User> User { get; set; }
		public DbSet<Book> Book { get; set; }
		public DbSet<Author> Author { get; set; }
		public DbSet<Activity> Activity { get; set; }
		public DbSet<CovertPhoto> CovertPhoto { get; set; }

		/*Singleton*/
		public static LibrosContext Create()
		{
			return new LibrosContext();
		}

	}
}
