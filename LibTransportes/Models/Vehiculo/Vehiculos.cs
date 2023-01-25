using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models.Vehiculo
{
    public abstract class Vehiculos
    {
        public Vehiculos(int ruedas, string modelo)
        {
            Ruedas = ruedas;
            Modelo = modelo;
        }



        public int Ruedas { get; set; }
        public string Modelo { get; set; }

        public abstract string Acelerar();


        public abstract string Frenar();

        public virtual string Imprimir( Vehiculos vehiculos)
        {
            return vehiculos.ToString();
        }



    }
}
