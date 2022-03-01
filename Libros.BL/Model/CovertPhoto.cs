using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Libros.BL.Model
{
	[Table("CovertPhoto", Schema = "dbo")]
	public class CovertPhoto
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int Id { get; set; }

		[ForeignKey	("Book")]
		public int IdBook { get; set; }
		public string Url { get; set; }
		public Book Book { get; set; }
	}
}
