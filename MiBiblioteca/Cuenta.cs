using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Cuenta
    {

        public string titular;
        public float cantidad;

        public Cuenta(float cantidad, string titular)
        {
            this.cantidad = cantidad;
            this.titular = titular;
        }

        public string Titular { get { return this.titular; } }

        public float Cantidad { get { return this.cantidad; } }

        public string Mostrar()
        {
            return $"Titular: {this.Titular} \nCantidad: {this.Cantidad}";
        }

        public float Ingresar(float montoAcreditar)
        {
            float retorno = 0;

            if(montoAcreditar > 0)
            {
                this.cantidad += montoAcreditar;
            }

            return retorno;

        }


        public void Retirar(float montoDescuento)
        {
            this.cantidad -= montoDescuento;
        }


    }
}
