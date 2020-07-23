using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Interfaces
{
    public interface IServicioIngreso
    {
        List<Ingreso> ObtenerIngresos();
        Cuenta obtenerCuenta(int idCuenta);
        void GuardarCuenta();
        void GuardarIngreso(Ingreso gasto);
    }
}
