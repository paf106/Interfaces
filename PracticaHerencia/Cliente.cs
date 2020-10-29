using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    class Cliente
    {
        private string nombre;
        private string apellidos;
        private string ciudad;
        private string email;
        private string comentario;
        private bool vip;
        private string imagen;

        public Cliente(string nombre, string apellidos, string ciudad, string email, string comentario, bool vip, string imagen)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.ciudad = ciudad;
            this.email = email;
            this.comentario = comentario;
            this.vip = vip;
            this.imagen = imagen;
        }
        public Cliente()
        {

        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        public void setImagen(string imagen)
        {
            this.imagen = imagen;
        }
        public string getImagen()
        {
            return this.imagen;
        }

        public void setApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        public string getApellidos()
        {
            return this.apellidos;
        }

        public void setCiudad(string ciudad)
        {
            this.ciudad = ciudad;
        }
        public string getCiudad()
        {
            return this.ciudad;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return this.email;
        }

        public void setComentario(string comentario)
        {
            this.comentario = comentario;
        }
        public string getComentario()
        {
            return this.comentario;
        }

        public void setVip(bool vip)
        {
            this.vip = vip;
        }
        public bool getVip()
        {
            return this.vip;
        }


    }
}
