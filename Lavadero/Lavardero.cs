using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Lavadero
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
            this.precioMoto = precioMoto;
            this.precioCamion = precioCamion;
            this.precioAuto = precioAuto;
        }

        public string Detalle
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Precio Moto: {this.precioMoto}");
                sb.AppendLine($"Precio Camion: {this.precioCamion}");
                sb.AppendLine($"Precio Auto: {this.precioAuto}");

                foreach (Vehiculo item in this.vehiculos)
                {
                    if (item is Auto auto)
                    {
                        sb.AppendLine(auto.MostrarAuto());
                    }
                    else if (item is Moto moto)
                    {
                        sb.AppendLine(moto.MostrarMoto());
                    }
                    else if (item is Camion camion)
                    {
                        sb.AppendLine(camion.MostrarCamion());
                    }
                }

                return sb.ToString();
            }
        }

        public List<Vehiculo> Vehiculos
        { 
            get {  return this.vehiculos;} 
        }

        public double MostrarTotalFacturado()
        {
            double gancia = 0;  

            foreach (Vehiculo item in this.vehiculos )
            {
                if (item is Auto)
                {
                    gancia += this.precioAuto;
                }
                else if (item is Moto)
                {
                    gancia += this.precioMoto;
                }
                else if (item is Camion)
                {
                    gancia += this.precioCamion;
                }
            }

            return gancia;
        }

        public double MostrarTotalFacturado(EVehiculo vehiculo)
        {
            double ganancia = 0;
            int contador = 0;

            switch(vehiculo)
            {
                case EVehiculo.Auto:

                    foreach (Auto item in this.vehiculos)
                    {
                        contador++;
                    }
                    ganancia = this.precioAuto * contador;
                    break;

                case EVehiculo.Camion:

                    foreach (Camion item in this.vehiculos)
                    {
                        contador++;
                    }
                    ganancia = this.precioCamion * contador;
                    break;

                case EVehiculo.Moto:

                    foreach (Moto item in this.vehiculos)
                    {
                        contador++;
                    }
                    ganancia = this.precioMoto * contador;
                    break;
            }

            return ganancia;

        }

        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool retorno = false; 
            
            for (int i = 0; i < lavadero.Vehiculos.Count; i++)
            {
                if(lavadero.Vehiculos[i] == vehiculo)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if(lavadero != vehiculo)
            {
                lavadero.vehiculos.Add(vehiculo);
            }

            return lavadero;
        }

        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero == vehiculo)
            {
                lavadero.vehiculos.Remove(vehiculo);
            }

            return lavadero;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is not null && obj is Vehiculo)
            {
                retorno =  this == ((Vehiculo)obj) ;
            }

            return retorno;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente.CompareTo(v2.Patente);
        }

        public static int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return v1.Marca.CompareTo(v2.Marca);
        }
    }
}
