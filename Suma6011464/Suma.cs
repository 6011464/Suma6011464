﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace Suma6011464
{
    public class Suma
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }


        public int RealizarSuma()
        {
            var resultado = Numero1 + Numero2;
            return resultado;

        }
    }
}
