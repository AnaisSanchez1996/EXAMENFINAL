using ExamenFinal.DB;
using ExamenFinal.Interfaces;
using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFinal.Servicio
{
    public class ServicioGasto : IServicioGasto
    {
        private ConexionDB conexion;

        public ServicioGasto()
        {
            this.conexion = new ConexionDB();
        }
        public List<Gasto> ObtenerGastos()
        {
            return conexion.Gastos.ToList();
        }

        public void GuardarGasto(Gasto gasto)
        {
            conexion.Gastos.Add(gasto);
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