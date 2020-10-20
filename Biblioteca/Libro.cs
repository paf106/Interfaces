using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;
        private bool nuevo;
        private string foto;

        public Libro(string titulo, string autor, string editorial, bool nuevo, string foto)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.nuevo = nuevo;
            this.foto = foto;

        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public void setAutor(string autor)
        {
            this.autor = autor;
        }
        public string getAutor()
        {
            return this.autor;
        }
        public void setEditorial(string editorial)
        {
            this.editorial = editorial;
        }
        public string getEditorial()
        {
            return this.editorial;
        }
        public void setNuevo(bool nuevo)
        {
            this.nuevo = nuevo;
        }
        public bool getNuevo()
        {
            return this.nuevo;
        }
        public void setFoto(string foto)
        {
            this.foto = foto;
        }
        public string getFoto()
        {
            return this.foto;
        }

        public override bool Equals(object obj)
        {
            return obj is Libro libro &&
                   titulo == libro.titulo &&
                   autor == libro.autor &&
                   editorial == libro.editorial;
        }

        public override int GetHashCode()
        {
            int hashCode = -1883106910;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(titulo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(autor);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(editorial);
            return hashCode;
        }
    }
}
