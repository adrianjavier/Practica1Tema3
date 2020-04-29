using System;
using System.Collections.Generic;
using System.Text;

namespace QuintaRueda.Common
{
    public class Plazas
    {
        /// <summary>
        /// Acciones sobre las plazas del parking
        /// </summary>
        private static int plazas = 90;

        public static int AñadirPlazas(int n)
        {
            plazas = plazas - n;
            return plazas;
        }

    }
}
