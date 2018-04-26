using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _20180425_Examen02_025376
{
    class Robot2:Robots
    {
        public bool ocupado { get; set; }
        SinTerminar miSinTerminar;
        Terminadas miTerminadas;
        public Tarea miTarea;
        string fecha;
        public string id { get; set; }
        public string nombre { get; set; }
        public Robot2(string id, string nombre, SinTerminar miSinTerminar, Terminadas miTerminadas)
        {

            this.id = id;
            this.nombre = nombre;
            this.miSinTerminar = miSinTerminar;
            this.miTerminadas = miTerminadas;
            ocupado = false;
        }
        public void realizar_tarea()
        {
            Thread.Sleep(miTarea.duracion * 1000);
            miTarea.realizarTarea();
            fecha = DateTime.Now.ToString();
            miTarea.realizadaPor = nombre;
            miTarea.fecha = fecha;
            miSinTerminar.eliminarTarea(miTarea);
            miTerminadas.agregarTarea(miTarea);
            ocupado = false;
        }

        public void obtener_tarea()
        {
            miTarea = miSinTerminar.delegarTarea();

        }
    }
}
