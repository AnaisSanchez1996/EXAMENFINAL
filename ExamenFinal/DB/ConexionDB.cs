using ExamenFinal.DB.Map;
using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamenFinal.DB
{
    public class ConexionDB : DbContext
    {
        public IDbSet<Cuenta> Cuentas { get; set; }

        public IDbSet<Gasto> Gastos { get; set; }
        public IDbSet<Ingreso> Ingresos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CuentaMap());
            modelBuilder.Configurations.Add(new GastoMap());
            modelBuilder.Configurations.Add(new IngresoMap());

        }
    }
}