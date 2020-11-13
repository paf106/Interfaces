using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesAdicionales
{
    class Cliente
    {
        private string Nombre;
        private string Apellidos;
        private string FechaNacimiento;
        private string Nif;
        private string Direccion;
        private string CodigoPostal;

        public Cliente(string nombre, string apellidos, string fechaNacimiento, string nif, string direccion, string codigoPostal)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Nif = nif;
            Direccion = direccion;
            CodigoPostal = codigoPostal;
        }

        public Cliente()
        {
        }

        public void setNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public string getNombre()
        {
            return this.Nombre;
        }
        public void setApellidos(string Apellidos)
        {
            this.Apellidos = Apellidos;
        }
        public string getApellidos()
        {
            return this.Apellidos;
        }
        public void setFechaNacimiento(string FechaNacimiento)
        {
            this.FechaNacimiento = FechaNacimiento;
        }
        public string getFechaNacimiento()
        {
            return this.FechaNacimiento;
        }
        public void setNif(string Nif)
        {
            this.Nif = Nif;
        }
        public string getNif()
        {
            return this.Nif;
        }
        public void setDireccion(string Direccion)
        {
            this.Direccion = Direccion;
        }
        public string getDireccion()
        {
            return this.Direccion;
        }
        public void setCodigoPostal(string CodigoPostal)
        {
            this.CodigoPostal = CodigoPostal;
        }
        public string getCodigoPostal()
        {
            return this.CodigoPostal;
        }
    }
}
