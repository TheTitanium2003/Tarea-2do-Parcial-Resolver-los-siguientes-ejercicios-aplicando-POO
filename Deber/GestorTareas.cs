using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber
{
    public class GestorTareas
    {
        public List<Tarea> ListaTareas { get; set; }

        public GestorTareas()
        {
            ListaTareas = new List<Tarea>();
        }

        public void AgregarTarea(Tarea tarea)
        {
            ListaTareas.Add(tarea);
        }

        public void MarcarComoCompletada(string descripcion)
        {
            foreach (var tarea in ListaTareas)
            {
                if (tarea.Descripcion == descripcion)
                {
                    tarea.Completada = true;
                    break;
                }
            }
        }

        public void MostrarTareasPendientes()
        {
            Console.WriteLine("Tareas pendientes:");
            foreach (var tarea in ListaTareas)
            {
                if (!tarea.Completada)
                {
                    Console.WriteLine($"{tarea.Descripcion} - {tarea.FechaVencimiento.ToShortDateString()}");
                }
                else
                {
                    Console.WriteLine($"{tarea.Descripcion} - {tarea.FechaVencimiento.ToShortDateString()} - Completada");
                }
            }
        }
    }

}
