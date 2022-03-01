using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros.BL.Services.Implements
{
    class BookService
    {
        private readonly Data.LibrosContext bookDBContext;
        public BookService(Data.LibrosContext bookDBContext)
        {
            this.bookDBContext = bookDBContext;
        }

        public List<Model.Book> GetBooks()
        {
            return bookDBContext.Book.Select(
                b => new Model.Book
                {
                    Id = b.Id,
                    Title = b.Title,
                    Description = b.Description,
                    Pagecount = b.Pagecount,
                    Excerpt = b.Excerpt,
                    PublihDate = b.PublihDate
                }).ToList();
        }

        public Model.Book GetBookbyId(int id)
        {
            return bookDBContext.Book.Select(
                b => new Model.Book
                {
                    Id = b.Id,
                    Title = b.Title,
                    Description = b.Description,
                    Pagecount = b.Pagecount,
                    Excerpt = b.Excerpt,
                    PublihDate = b.PublihDate
                }).FirstOrDefault(a => a.Id == id);
        }
    }
}
