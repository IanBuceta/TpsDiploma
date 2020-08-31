using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class ConstructorFiatPalioTresPuertas : ConstructorAuto
    {
        public ConstructorFiatPalioTresPuertas()
        {
            Auto = new Auto(Auto.MarcaAuto.Fiat, Auto.ModeloAuto.Palio);
        }
        public override void ConstruirMotor()
        {
            Auto.Motor = "1.3";
        }

        public override void ConstruirPuertas()
        {
            Auto.Puertas = "3";
        }
    }
}
