﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class ConstructorFordFocusCincoPuertas : ConstructorAuto
    {

        public ConstructorFordFocusCincoPuertas()
        {
            Auto = new Auto(Auto.MarcaAuto.Ford, Auto.ModeloAuto.Focus);
        }

        public override void ConstruirMotor()
        {
            Auto.Motor = "2.0";
        }

        public override void ConstruirPuertas()
        {
            Auto.Puertas = "5";
        }
    }
}
