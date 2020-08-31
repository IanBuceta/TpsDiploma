using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Auto
    {
        public Auto(MarcaAuto marca, ModeloAuto modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public MarcaAuto Marca { get; }
        public ModeloAuto Modelo { get; }
        public enum MarcaAuto { Ford, Fiat };
        public enum ModeloAuto { Fiesta, Focus, Palio, Siena };
        public string Motor { get; set; }
        public string Puertas { get; set; }
        public override string ToString()
        {
            return $"Motor: {Motor}, Marca: {Marca}, Modelo: {Modelo}, Puertas {Puertas}";
        }
    }
}
