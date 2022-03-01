using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Libros.BL.Services;
using Libros.BL.Model;
using Libros.BL.Data;
namespace Libros.API.Controllers
{
    [Route("api/{https://fakerestapi.azurewebsites.net/index.html}")]
    public class authorController : ApiController
    {
        public readonly LibrosContext authorDBContext;

        //[HttpGet("{id}")]
        public List<Author> GetAuthors()
        {
            return authorDBContext.Author.Select(
                a => new Author
                {
                    Id = a.Id,
                    IdBook = a.IdBook,
                    FirtName = a.FirtName,
                    LastName = a.LastName
                }).ToList();
        }

    }
}
