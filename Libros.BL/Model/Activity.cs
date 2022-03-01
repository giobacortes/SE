using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Libros.BL.Model
{
	[Table("Activity", Schema = "dbo")]
	public class Activity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime DueDate { get; set; }
		public Boolean Completed { get; set; }
	}
}
