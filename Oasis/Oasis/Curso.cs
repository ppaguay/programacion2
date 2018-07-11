using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis
{
    class Curso
    {
        int codigo;
        string descripcion;
        public Curso() { }
        public Curso(int pcodigo, string pdescripcion)
        {
            codigo = pcodigo;
            descripcion = pdescripcion;
        }
        public int getCodigo()
        {
            return codigo;
        }
        public void setCodigo(int pcodigo)
        {
            codigo = pcodigo;
        }
        public string getDescripcion()
        {
            return descripcion;
        }
        public void setDescripcion(string pdescripcion)
        {
            descripcion = pdescripcion;
        }
        public void leer()
        {
            Console.WriteLine("\nIngrese los datos del Curso");
            Console.Write("Código:");
            codigo = Convert.ToInt16(Console.ReadLine());
            Console.Write("Descripcion:");
            descripcion = Console.ReadLine();
        }
        public void imprimir()
        {
            Console.WriteLine("\nDatos del Curso");
            Console.Write("Código:" + codigo);
            Console.Write("Descripcion:" + descripcion);
        }
    }
}
