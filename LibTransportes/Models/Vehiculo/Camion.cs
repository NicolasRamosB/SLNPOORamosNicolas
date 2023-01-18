using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models.Vehiculo
{
    public class Camion : Vehiculos

    {

        

        public Camion(int ruedas, string modelo, double capacidad) : base(ruedas, modelo)
        {

            Capacidad = capacidad;
           
        }

       
        public double Capacidad { get; set; }

        public Remolque Remolque { get; set; }



        public string QuitarRemolque()
        {
            Remolque = null;
            return "Se desacoplo el remolque";
        }

        public override string Acelerar()
        {
            return base.Acelerar();
        }

        public override string Frenar()
        {
            return base.Frenar();
        }

        public virtual string Imprimir(Camion camion)
        {
            return camion.ToString();
        }
    }
}
