using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTransportes.Models;
using LibTransportes.Models.Vehiculo;

namespace PresentaciónVehiculos.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCamion_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion(6, "Mercedez Benz", 10000.233 );

            MessageBox.Show( $"Ruedas: {camion.Ruedas}" +
                $"\nModelo: {camion.Modelo}" +
                $"\nCapacidad en Kg: {camion.Capacidad}" +
                $"\nAceleracion: {camion.Acelerar()}" +
                $"\nFrenar: {camion.Frenar()}" +
                $"Remolque: {camion.QuitarRemolque()}");
        }

        private void btnRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque() { 
            Carga = "Cerveza",
             };

            MessageBox.Show(
                $"Carga:{remolque.Carga}" 
                );
        }
    }
}
