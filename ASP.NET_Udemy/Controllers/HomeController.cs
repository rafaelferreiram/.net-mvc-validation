using ASP.NET_Udemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Udemy.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/

        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                pessoaId = 1,
                nome = "Testing",
                tipo = "Null"
            };

            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {


            return View(pessoa);
        }
    }
}
