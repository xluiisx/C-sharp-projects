﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    public class Pago
    {
        double saldototal;
        public double calcular(double saldoini, double monto)
        {
            saldototal = saldoini - monto;
            return saldototal;
        }
    }
}
