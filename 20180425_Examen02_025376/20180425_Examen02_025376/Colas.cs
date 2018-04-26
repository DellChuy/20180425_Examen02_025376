using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_025376
{
    interface Colas
    {
        Tarea delegarTarea();
        void eliminarTarea(Tarea tareaE);
        void agregarTarea(Tarea tarea);
        //void llenarLista();
    }
}
