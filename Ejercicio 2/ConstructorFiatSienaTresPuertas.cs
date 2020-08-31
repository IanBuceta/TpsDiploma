using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class ConstructorFiatSienaTresPuertas : ConstructorAuto
    {
        public ConstructorFiatSienaTresPuertas()
        {
            Auto = new Auto(Auto.MarcaAuto.Fiat, Auto.ModeloAuto.Siena);
        }

        public override void ConstruirMotor()
        {
            Auto.Motor = "1.6";
        }

        public override void ConstruirPuertas()
        {
            Auto.Puertas = "3";
        }
    }
}
