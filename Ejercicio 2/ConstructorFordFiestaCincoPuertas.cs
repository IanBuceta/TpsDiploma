﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class ConstructorFordFiestaCincoPuertas : ConstructorAuto
    {
        public ConstructorFordFiestaCincoPuertas()
        {
            Auto = new Auto(Auto.MarcaAuto.Ford, Auto.ModeloAuto.Fiesta);
        }
        public override void ConstruirMotor()
        {
            Auto.Motor = "1.6";
        }

        public override void ConstruirPuertas()
        {
            Auto.Puertas = "5";
        }
    }
}
