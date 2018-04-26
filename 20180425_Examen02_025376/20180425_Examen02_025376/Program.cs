using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _20180425_Examen02_025376
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarea tarea1 = new Tarea("Darle comida a los perros", 5);
            Tarea tarea2 = new Tarea("Lavar Ropa", 3);
            Tarea tarea3 = new Tarea("Lavar el carro", 4);
            Tarea tarea4 = new Tarea("Limpiar la casa", 8);

            SinTerminar sinTerminar = new SinTerminar();
            Terminadas terminadas = new Terminadas();
            sinTerminar.agregarTarea(tarea1);
            sinTerminar.agregarTarea(tarea2);
            sinTerminar.agregarTarea(tarea3);
            sinTerminar.agregarTarea(tarea4);
            Robot1 robot1 = new Robot1("1", "robot1", sinTerminar, terminadas);
            Robot2 robot2 = new Robot2("2", "robot2", sinTerminar, terminadas);
            Robot3 robot3 = new Robot3("3", "robot3", sinTerminar, terminadas);
            while (sinTerminar.tareasNoTerminadas.Count != 0)
            {
                //obtener tarea a realizar
                robot1.obtener_tarea();
                //Creamos el delegado 
                Thread.Sleep(robot1.miTarea.duracion * 1000);
                ThreadStart delegado = new ThreadStart(robot1.realizar_tarea);
                //Creamos la instancia del hilo 
                Thread hilo = new Thread(delegado);
                //Iniciamos el hilo 
           
                hilo.Start();
                
            }

            while (sinTerminar.tareasNoTerminadas.Count != 0)
            {
                //obtener tarea a realizar
                robot2.obtener_tarea();
                //Creamos el delegado 
                Thread.Sleep(robot2.miTarea.duracion * 1000);
                ThreadStart delegado2 = new ThreadStart(robot2.realizar_tarea);
                //Creamos la instancia del hilo 
                Thread hilo2 = new Thread(delegado2);
                //Iniciamos el hilo 

                hilo2.Start();

            }

            while (sinTerminar.tareasNoTerminadas.Count != 0)
            {
                //obtener tarea a realizar
                robot3.obtener_tarea();
                //Creamos el delegado 
                Thread.Sleep(robot3.miTarea.duracion * 1000);
                ThreadStart delegado3 = new ThreadStart(robot3.realizar_tarea);
                //Creamos la instancia del hilo 
                Thread hilo3 = new Thread(delegado3);
                //Iniciamos el hilo 

                hilo3.Start();

            }
            if (sinTerminar.tareasNoTerminadas.Count == 0)
            {
                Console.WriteLine("Tareas Terminadas");
                for(int i = 0; i < terminadas.tareasTerminadas.Count; i++)
                {
                    Console.WriteLine(terminadas.tareasTerminadas[i].tarea + " " + terminadas.tareasTerminadas[i].realizadaPor + " " + terminadas.tareasTerminadas[i].fecha);
                }
            }
            Console.ReadKey();
        }
    }
}
