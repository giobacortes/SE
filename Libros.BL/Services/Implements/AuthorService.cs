using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros.BL.Services.Implements
{
    public class AuthorService
    {
        private readonly Data.LibrosContext authorDBContext;
        public AuthorService(Data.LibrosContext authorDBContext)
        {
            this.authorDBContext = authorDBContext;
        }

        public List<Model.Author> GetAuthors()
        {
            return authorDBContext.Author.Select(
                a => new Model.Author
                {
                    Id = a.Id,
                    IdBook = a.IdBook,
                    FirtName = a.FirtName,
                    LastName = a.LastName
                }).ToList();
        }

        public Model.Author GetAuthor(int idBook)
        {
            return authorDBContext.Author.Select(
                a => new Model.Author
                {
                    Id = a.Id,
                    IdBook = a.IdBook,
                    FirtName = a.FirtName,
                    LastName = a.LastName
                }).FirstOrDefault(a => a.IdBook == idBook);
        }

        public Model.Author GetAuthorbyId(int id)
        {
            return authorDBContext.Author.Select(
                a => new Model.Author
                {
                    Id = a.Id,
                    IdBook = a.IdBook,
                    FirtName = a.FirtName,
                    LastName = a.LastName
                }).FirstOrDefault(a => a.Id == id);
        }
    }
}
