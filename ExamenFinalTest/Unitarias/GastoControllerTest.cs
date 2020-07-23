using ExamenFinal.Controllers;
using ExamenFinal.Interfaces;
using ExamenFinal.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ExamenFinalTest.Unitarias
{
    class GastoControllerTest
    {
        [Test]
        public void IndexTest()
        {

            var faker = new Mock<IServicioGasto>();
            faker.Setup(a => a.ObtenerGastos()).Returns(new List<Gasto>{new Gasto{IdGasto=1, FechaHora=DateTime.Now, Descripcion="Gasto ", IdCuenta=1, Monto=100} });

            var controller = new GastoController(faker.Object);
            var view = controller.Index(1) as ViewResult;
            var model = view.Model as List<Gasto>;

            Assert.AreEqual(1, model.Count);
        }
        [Test]
        public void GastosIndex()
        {

            var faker = new Mock<IServicioGasto>();
            faker.Setup(a => a.ObtenerGastos()).Returns(new List<Gasto>{new Gasto{IdGasto=1, FechaHora=DateTime.Now, Descripcion="Gasto", IdCuenta=1, Monto=100} });

            var controller = new GastoController(faker.Object);
            var view = controller.Index(1) as ViewResult;

            Assert.IsInstanceOf<ViewResult>(view);
        }

    }
}

