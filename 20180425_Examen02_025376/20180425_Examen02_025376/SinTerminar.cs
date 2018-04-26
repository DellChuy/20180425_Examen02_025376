using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_025376
{
    class SinTerminar:Colas
    {
        
        public List<Tarea> tareasNoTerminadas = new List<Tarea>();
        Tarea tarea2;
        public void agregarTarea(Tarea tarea)
        {
            tareasNoTerminadas.Add(tarea);
        }
        public Tarea delegarTarea()
        {
            tarea2 = tareasNoTerminadas[0];
            tareasNoTerminadas.Remove(tarea2);
            return tarea2;
        }
        public void eliminarTarea(Tarea tareaE)
        {
            tareasNoTerminadas.Remove(tareaE);
        }
    }
}
