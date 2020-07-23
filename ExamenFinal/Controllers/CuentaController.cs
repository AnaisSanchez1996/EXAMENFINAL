using ExamenFinal.DB;
using ExamenFinal.Interfaces;
using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenFinal.Controllers
{
    public class CuentaController : Controller
    {
        private readonly IServicioCuenta service;
        public CuentaController(IServicioCuenta service)
        {
            this.service = service;
        }
        private ConexionDB conexion = new ConexionDB();
        // GET: Cuenta
        public ActionResult Index()
        {
            return View(service.ObtenerCuentas().ToList());
        }
        [HttpGet]
        public ActionResult Crear()
        {
            return View(new Cuenta());
        }
        [HttpPost]
        public ActionResult Crear(Cuenta cuenta)
        {
            if (cuenta.Categoria != null && cuenta.Nombre != null && cuenta.SaldoInicial != 0)
            {
                service.GuardarCuenta(cuenta);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}