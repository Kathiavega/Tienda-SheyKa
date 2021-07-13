using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda_Online_SheyKa.BL;

namespace Tienda_Online_SheyKa.Web.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            var clientesBL = new ClientesBL();
            var listadeClientes = clientesBL.ObtenerClientes();


           return View(listadeClientes);
        }
    }
}