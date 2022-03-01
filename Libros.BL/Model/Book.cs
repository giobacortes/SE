using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Libros.BL.Model
{
	[Table("Book", Schema = "dbo")]
	public class Book
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public Boolean Pagecount { get; set; }
		public string Excerpt { get; set; }
		public DateTime PublihDate { get; set; }

		public virtual ICollection<Author> Authors { get; set; }
		public virtual ICollection<CovertPhoto> CovertPhotos { get; set; }

	}

}
