using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class MotoPistero : PrototipoMoto
    {
        public MotoPistero()
        {
            Motor = enumMotor.QuinientosCC;
            Rodado = enumRodado.Diecinueve;
            Carroceria = enumCarroceria.Carbono;
        }
    }
}
