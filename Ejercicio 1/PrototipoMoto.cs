using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public abstract class PrototipoMoto : ICloneable
    {
        public enumRodado Rodado { get; protected set; }
        public enumMotor Motor { get; protected set; }
        public enumCarroceria Carroceria { get; protected set; }

        public enum enumRodado : int { Catorce = 14, Diecinueve = 19, Veintidos = 22 };
        public enum enumMotor : int { CincuentaCC = 50, DoscientoscincuentaCC = 250, QuinientosCC = 500 };
        public enum enumCarroceria : int { Hierro, Aluminio, Carbono };  
        public object Clone()
        {
            return MemberwiseClone();
        }
        public override string ToString()
        {
            return $"Motor: {Motor}, Rodado: {Rodado}, Carrocería: {Carroceria}";
        }
    }
}
