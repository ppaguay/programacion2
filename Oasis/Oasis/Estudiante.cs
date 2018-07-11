using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis
{
    class Estudiante
    {
        int codigo;
        string nombre;
        Curso curso;
        public Estudiante()
        {
        }
        public Estudiante(int pcodigo, string pnombre, Curso pcurso)
        {
            codigo = pcodigo;
            nombre = pnombre;
            curso = pcurso;
        }
        public int getCodigo()
        {
            return codigo;
        }
        public void setCodigo(int pcodigo)
        {
            codigo = pcodigo;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string pnombre)
        {
            nombre = pnombre;
        }
        public Curso getCurso()
        {
            return curso;
        }
        public void setCurso(Curso pcurso)
        {
            curso = pcurso;
        }

        public void leer()
        {
            Console.WriteLine("\nIngrese los datos del Estudiante");
            Console.Write("Código:");
            codigo = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nombre:");
            nombre = Console.ReadLine();
            Curso objCurso = new Curso();
            objCurso.leer();
            curso = objCurso;
        }
        public void imprimir()
        {
            Console.WriteLine("\nDatos del Estudiante");
            Console.Write("Código:" + codigo);
            Console.Write("Nombre:" + nombre);
            curso.imprimir();
        }

    }
}
