using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class MotoScooter : PrototipoMoto
    {
        public MotoScooter()
        {
            Motor = enumMotor.CincuentaCC;
            Rodado = enumRodado.Catorce;
            Carroceria = enumCarroceria.Hierro;
        }
    }
}
