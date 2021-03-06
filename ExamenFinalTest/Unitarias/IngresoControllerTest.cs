﻿using ExamenFinal.Controllers;
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
    class IngresoControllerTest
    {
        [Test]
        public void IndexTest()
        {

            var faker = new Mock<IServicioIngreso>();
            faker.Setup(a => a.ObtenerIngresos()).Returns(new List<Ingreso> {new Ingreso{IdIngreso=1, FechaHora=DateTime.Now, Descripcion="Ingreso ", IdCuenta=1, Monto=100} });

            var controller = new IngresoController(faker.Object);
            var view = controller.Index(1) as ViewResult;
            var model = view.Model as List<Ingreso>;

            Assert.AreEqual(1, model.Count);
        }
        [Test]
        public void ReturnIndexTest()
        {

            var faker = new Mock<IServicioIngreso>();
            faker.Setup(a => a.ObtenerIngresos()).Returns(new List<Ingreso>{new Ingreso{IdIngreso=1, FechaHora=DateTime.Now, Descripcion="Ingreso ", IdCuenta=1, Monto=100}  });
             var controller = new IngresoController(faker.Object);
            var view = controller.Index(1) as ViewResult;

            Assert.IsInstanceOf<ViewResult>(view);
        }
    }
}
