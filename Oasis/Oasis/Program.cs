using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> listado = new List<Estudiante>();
            Console.WriteLine(listado.Count);
            Estudiante est1 = new Estudiante();
            est1.setCodigo(1);
            est1.setNombre("Juan");
            Curso cursoEst1 = new Curso();
            cursoEst1.setCodigo(1);
            cursoEst1.setDescripcion("Primero");
            est1.setCurso(cursoEst1);

            Estudiante est2 = new Estudiante(2,"Pedro", cursoEst1);            

            listado.Add(est1);
            Console.WriteLine(listado.Count);
            listado.Add(est2);
            Console.WriteLine(listado.Count);

            Console.ReadLine();

        }
    }
}
