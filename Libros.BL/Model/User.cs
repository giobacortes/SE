
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Libros.BL.Model
{
	[Table("User", Schema = "dbo")]
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }

	}
}
