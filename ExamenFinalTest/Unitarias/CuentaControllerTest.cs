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
    [TestFixture]
    class CuentaControllerTest
    {

        [Test]
        public void ReturnIndexTest()
        {

            var faker = new Mock<IServicioCuenta>();
            faker.Setup(a => a.ObtenerCuentas()).Returns(new List<Cuenta> {  new Cuenta{IdCuenta=1, Categoria="Credito", Nombre="Anais", SaldoInicial=1100} });

            var controller = new CuentaController(faker.Object);
            var view = controller.Index() as ViewResult;
            var model = view.Model as List<Cuenta>;

            Assert.AreEqual(1, model.Count);
        }
        [Test]
        public void IndexTest()
        {

            var faker = new Mock<IServicioCuenta>();
            faker.Setup(a => a.ObtenerCuentas()).Returns(new List<Cuenta>{ new Cuenta{IdCuenta=1, Categoria="Credito", Nombre="Anais", SaldoInicial=1100}});

            var controller = new CuentaController(faker.Object);
            var view = controller.Index();

            Assert.IsInstanceOf<ViewResult>(view);
        }
        [Test]
        public void CrearTest()
        {
            var faker = new Mock<IServicioCuenta>();
            var controller = new CuentaController(faker.Object);
            var view = controller.Crear() as ViewResult;

            Assert.IsInstanceOf<Cuenta>(view.Model);
        }
        [Test]
        public void NoCrear()
        {
            var cuenta = new Cuenta { IdCuenta = 1, Categoria = null, Nombre = "Anais", SaldoInicial = 1100 };
            var faker = new Mock<IServicioCuenta>();
            var controller = new CuentaController(faker.Object);
            var view = controller.Crear(cuenta);

            Assert.IsInstanceOf<ViewResult>(view);
        }
        [Test]
        public void ReCrearTest()
        {
            var cuenta = new Cuenta { IdCuenta = 1, Categoria = "Credito", Nombre = "Anais", SaldoInicial = 1100 };
            var faker = new Mock<IServicioCuenta>();
            var controller = new CuentaController(faker.Object);
            var view = controller.Crear(cuenta);

            Assert.IsInstanceOf<RedirectToRouteResult>(view);
        }
    }
}

