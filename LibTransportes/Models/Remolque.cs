using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibTransportes.Models.Vehiculo;

namespace LibTransportes.Models
{
    public class Remolque
    {
        public string Carga { get; set; }

        public Camion camion { get; set; }

        
    }
}
