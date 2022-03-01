using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Libros.BL.Data;
using System.Configuration;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.DataProtection;
using Microsoft.Owin.Security.OAuth;


/*Permite obtener una unica instancia por request*/
namespace Libros.API
{
    public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			//Configura el db Context para usarlo como una unica instancia por request
			app.CreatePerOwinContext(LibrosContext.Create);
		}

	}
}
