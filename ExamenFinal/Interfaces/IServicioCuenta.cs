using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Interfaces
{
   public interface IServicioCuenta
    {
        List<Cuenta> ObtenerCuentas();
        void GuardarCuenta(Cuenta cuenta);
    }
}
