using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaAlmacenes.Models;

namespace PracticaAlmacenes.Controllers
{
    public class ProductoController : Controller
    {
        mitienda02Entities db=new mitienda02Entities();
       
        public ActionResult Index()
        {
            var data = db.Producto;
            return View(data);
        }

        public ActionResult Detalle(int id)
        {
            var data = db.Producto.Find(id);
            return View(data);
        }

        public ActionResult Alta()
        {
            return View(new Producto());
        }

        
        [HttpPost]
        public ActionResult Alta(Producto model)
        {
            if (ModelState.IsValid)
            {
                db.Producto.Add(model);
                db.SaveChanges();
                return View(new Producto());
            }
            return View(model);

        }
       

    }
}