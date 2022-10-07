using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero_Clase09
{
    class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }

        public string Detalle {
            
            get 
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Precio Auto: {this.precioAuto}");
                sb.AppendLine($"Precio Camion: {this.precioCamion}");
                sb.AppendLine($"Precio Moto: {this.precioMoto}");

                foreach (Vehiculo item in this.vehiculos)
                {
                    if(item is Moto moto)
                    {
                        sb.AppendLine(moto.MostrarMoto());
                    }
                    if(item is Camion camion)
                    {
                        sb.AppendLine(camion.MostrarCamion());
                    }
                    if (item is Auto auto)
                    {
                        sb.AppendLine(auto.MostrarAuto());
                    }
                }

                return sb.ToString();
            } 
        }

        public List<Vehiculo> Vehicul{ get{ return this.vehiculos;} }

    }
}
