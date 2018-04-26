using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_025376
{
    class Tarea
    {
        public string tarea { get; set; }
        public int duracion { get; set; }
        public string realizadaPor { get; set; }
        public string fecha { get; set; }
        public Tarea (string tarea,int duracion)
        {
            this.tarea = tarea;
            this.duracion = duracion;
        }

        public void realizarTarea()
        {
            Console.WriteLine("Se realizo la tarea: " + tarea);
        }
    }
}
