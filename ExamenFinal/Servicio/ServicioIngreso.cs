using ExamenFinal.DB;
using ExamenFinal.Interfaces;
using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFinal.Servicio
{
    public class ServicioIngreso : IServicioIngreso
    {
        private ConexionDB conexion;

        public ServicioIngreso()
        {
            this.conexion = new ConexionDB();
        }
        public List<Ingreso> ObtenerIngresos()
        {
            return conexion.Ingresos.ToList();
        }

        public void GuardarIngreso(Ingreso ingreso)
        {
            conexion.Ingresos.Add(ingreso);
            conexion.SaveChanges();
        }

        public Cuenta obtenerCuenta(int idCuenta)
        {
            return conexion.Cuentas.Find(idCuenta);
        }
        public void GuardarCuenta()
        {
            conexion.SaveChanges();
        }
    }
}