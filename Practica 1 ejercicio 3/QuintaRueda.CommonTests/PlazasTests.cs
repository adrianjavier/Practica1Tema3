using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuintaRueda.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuintaRueda.Common.Tests
{
    [TestClass()]
    public class PlazasTests
    {
        [TestMethod()]
        public void AñadirPlazasTest()
        {
            int actual = Plazas.AñadirPlazas(10);

            int expected = 100;

            Assert.AreEqual(expected, actual);S
        }
    }
}