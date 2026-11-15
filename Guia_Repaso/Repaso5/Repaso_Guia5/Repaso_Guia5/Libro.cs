using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso_Guia5 // la "Carpeta del proyecto"
{
    public class Libro //El nombre del molde
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int Paginas { get; private set; }
        public bool Disponible { get; private set; } = true;

        //Constructor: Creador de un libro
        public Libro(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;

        }
        public Libro(string titulo, string autor) : this(titulo, autor, 100)
        {

        }

        // Lo que el libro sabe hacer
        public bool Prestar()
        {
            if (!Disponible) return false;
            Disponible = false;
            return true;
        }

        public void Devolver()
        {
            Disponible = true;
        }
        public override string ToString() =>
            $"{Titulo} .{Autor}. {(Disponible ? "Disponible" : "Prestado")}";

        private int _paginas


    }
}
