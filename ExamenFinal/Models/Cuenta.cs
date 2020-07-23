using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFinal.Models
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public string Nombre { get; set; }
        public string Categoria  { get; set; }
        public decimal SaldoInicial { get; set; }
        public List<Ingreso>Ingresos { get; set; }
        public List<Gasto>Gastos { get; set; }



    }
}