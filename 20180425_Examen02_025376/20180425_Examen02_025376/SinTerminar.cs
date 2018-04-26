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
        public void agregarTarea(Tarea tarea)
        {
            tareasNoTerminadas.Add(tarea);
        }
        public Tarea delegarTarea()
        {
            return tareasNoTerminadas[0];
        }
        public void eliminarTarea(Tarea tareaE)
        {
            tareasNoTerminadas.Remove(tareaE);
        }
    }
}
