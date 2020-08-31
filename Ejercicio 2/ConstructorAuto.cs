using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public abstract class ConstructorAuto
    {
        public Auto Auto { get; protected set; }
        public abstract void ConstruirMotor();
        public abstract void ConstruirPuertas();
    }
}
