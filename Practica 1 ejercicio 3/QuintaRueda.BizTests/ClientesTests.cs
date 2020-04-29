using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica_1_ejercicio_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuintaRueda.Biz.Tests
{
    public class ClienteTests
    {
        [TestMethod()]

        public void HolaTest() 
        {
            Clientes cli = new Clientes();
            cli.Nombre = "Adrian";


            string expected = "Hola Adrian";
            string actual = cli.HolaCliente();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]

        public void HolaTest_Param()
        {
            Clientes cli = new Clientes("Adrian", "47408936W");



            string expected = "Hola Adrian";
            string actual = cli.HolaCliente();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]

        public void HolaDniTest()
        {
            Clientes cli = new Clientes();
            cli.Nombre = "Adrian";
            cli.Dni = "47408936W";


            string expected = "Hola Adrian con DNI 47408936W";
            string actual = cli.HolaCliente();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]

        public void HolaDniTest_Param()
        {
            Clientes cli = new Clientes("Adrian","47408936W");



            string expected = "Hola Adrian con DNI 47408936W";
            string actual = cli.HolaCliente();
            Assert.AreEqual(expected, actual);
        }
    }
}