using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Fabricante
    {
        public static Auto ConstruirAuto(ConstructorAuto constructorAuto)
        {
            constructorAuto.ConstruirMotor();
            constructorAuto.ConstruirPuertas();
            return constructorAuto.Auto;
        }
    }
}
