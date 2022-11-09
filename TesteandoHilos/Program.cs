using System;
using System.Threading;
using System.Threading.Tasks;

namespace TesteandoHilos
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Un solo Hilo, como se usa siempre
            /*
            Console.WriteLine("Proceso 1 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 2 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 3 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 4 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 5 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 6 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 7 Hilo 1");

            Proceso2Hilo2();*/

            #endregion

            #region 2 Hilos, esto provoca que se ejecuten los 2 hilos en simultaneo
            /*
            //Genero el segundo hilo
            Task tarea2 = new Task(Proceso2Hilo2);

            //Le doy comienzo al segundo hilo
            tarea2.Start();

            Console.WriteLine("Proceso 1 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 2 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 3 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 4 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 5 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 6 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 7 Hilo 1");*/

            #endregion

            #region 3 Hilos, esto provoca que se ejecuten los 3 hilos en simultaneo
            /*
            //Genero el segundo hilo
            Task tarea2 = new Task(Proceso2Hilo2);
            Task tarea3 = new Task(Proceso2Hilo2);

            //Le doy comienzo al segundo hilo
            tarea2.Start();

            //Le doy comienzo al tercer hilo
            tarea3.Start();

            Console.WriteLine("Proceso 1 Hilo 1 id: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 2 Hilo 1 id: " + tarea2.Id);
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 3 Hilo 1 id: " + tarea3.Id);
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 4 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 5 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 6 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 7 Hilo 1");*/

            #endregion

            #region 2 Hilos en simultaneo con Task.Run()

            //Genero el segundo hilo
            Task tarea2 = Task.Run(Proceso2Hilo2);

            //Le doy comienzo al segundo hilo
            tarea2.Start();

            Console.WriteLine("Proceso 1 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 2 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 3 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 4 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 5 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 6 Hilo 1");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 7 Hilo 1");

            #endregion
        }

        public static void Proceso2Hilo2()
        {
            Console.WriteLine("Proceso 1 Hilo 2");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 2 Hilo 2");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 3 Hilo 2");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 4 Hilo 2");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 5 Hilo 2");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 6 Hilo 2");
            Thread.Sleep(3000);
            Console.WriteLine("Proceso 7 Hilo 2");

        }
    }
}
