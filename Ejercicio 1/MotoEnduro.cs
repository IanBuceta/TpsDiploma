using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class MotoEnduro : PrototipoMoto
    {
        public MotoEnduro()
        {
            Motor = enumMotor.DoscientoscincuentaCC;
            Rodado = enumRodado.Veintidos;
            Carroceria = enumCarroceria.Aluminio;
        }
    }
}
