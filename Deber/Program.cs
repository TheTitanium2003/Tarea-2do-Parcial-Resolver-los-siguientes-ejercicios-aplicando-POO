using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber
{
    class Program
    {
        static void Main(string[] args)
        {
            GestorTareas gestor = new GestorTareas();

            gestor.AgregarTarea(new Tarea { Descripcion = "Comprar pan", FechaVencimiento = DateTime.Now.AddDays(1) });
            gestor.AgregarTarea(new Tarea { Descripcion = "Preparar cena", FechaVencimiento = DateTime.Now.AddDays(2) });
            gestor.AgregarTarea(new Tarea { Descripcion = "Lavar la ropa", FechaVencimiento = DateTime.Now.AddDays(3) });

            gestor.MarcarComoCompletada("Comprar pan");

            gestor.MostrarTareasPendientes();
        }
    }

}


