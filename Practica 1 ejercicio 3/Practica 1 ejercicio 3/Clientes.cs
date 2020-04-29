using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_1_ejercicio_3
{
    public class Clientes
    {
        /// <summary>
        /// Gestiona los clientes del parking
        /// </summary>
        private string nombre;
        private string dni;

        public Clientes()
        {
            Console.WriteLine("Creado nuevo cliente");
        }

        public Clientes(string n, string d)
        {
            this.nombre = n;
            this.dni = d;
        }

        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; } 
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string HolaCliente()
        {
            return "Hola " + nombre;
        }

        public string HolaClienteDni()
        {
            return "Hola " + nombre + " con DNI " + dni;
        }
    }
}
