using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Datos;
using Capa_Datos.Orm;

namespace Presentacion.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        cls_Categorias objCat = new cls_Categorias();

        public ActionResult Index()
        {
            return View(objCat.Listar());
        }
    }
}