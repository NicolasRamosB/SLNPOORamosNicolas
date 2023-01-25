using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models.Vehiculo
{
    public class AutoElectrico : Vehiculos
    {
        public AutoElectrico(int ruedas, string modelo, string bateria, string puertas, int velocidad) : base(ruedas, modelo)
        {
            Bateria = bateria;
            Puertas = puertas;
            Velocidad = velocidad;
        }

        public string Bateria { get; set; }
        public string Puertas { get; set; }

        public int Velocidad { get; set; }

        public override string Acelerar()
        {
            return "Acelera";
        }

        public override string Frenar()
        {
            return "Frenar"; ;
        }
        public virtual string Imprimir()
        {
            return base.Imprimir() + $"Bateria: {Bateria}\n" +
                $"Puertas: {Puertas}\n" +
                $"Velocidad: {Velocidad}";
        }
    }
}
