using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Libros.BL.Model
{
	[Table("Author", Schema = "dbo")]
	public class Author
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int Id { get; set; }

		[ForeignKey("Book")]
		public int IdBook { get; set; }
		public string FirtName { get; set; }
		public string LastName { get; set; }

		public Book Book { get; set; }
	}
}
