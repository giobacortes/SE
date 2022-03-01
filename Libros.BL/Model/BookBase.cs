using System.ComponentModel.DataAnnotations.Schema;

namespace Libros.BL.Model
{
    [Table("Book", Schema = "dbo")]
    public class BookBase
    {

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}