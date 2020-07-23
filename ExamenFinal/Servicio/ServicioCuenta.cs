using ExamenFinal.DB;
using ExamenFinal.Interfaces;
using ExamenFinal.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFinal.Servicio
{
    public class ServicioCuenta : IServicioCuenta
    {
        private ConexionDB conexion;

        public ServicioCuenta()
        {
            this.conexion = new ConexionDB();
        }

        public List<Cuenta> ObtenerCuentas()
        {
            return conexion.Cuentas.ToList();
        }

        public void GuardarCuenta(Cuenta cuenta)
        {
            conexion.Cuentas.Add(cuenta);
            conexion.SaveChanges();
        }
    }
}