using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_025376
{
    class Terminadas:Colas
    {
        public List<Tarea> tareasTerminadas = new List<Tarea>();
        public Tarea delegarTarea()
        {
            return tareasTerminadas[0];
        }
        public void eliminarTarea(Tarea tareaE)
        {

        }

        public void agregarTarea(Tarea tarea)
        {
            tareasTerminadas.Add(tarea);

        }
    }
}
