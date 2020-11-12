using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesAdicionales
{
    class Pedido
    {
        private string Nif;
        private string Nombre;
        private string Apellidos;
        private ListBox.ObjectCollection pedidos;

        public Pedido(string nif, string nombre, string apellidos, ListBox.ObjectCollection pedidos)
        {
            Nif = nif;
            Nombre = nombre;
            Apellidos = apellidos;
            this.pedidos = pedidos;
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
        public void setNif(string Nif)
        {
            this.Nif = Nif;
        }
        public string getNif()
        {
            return this.Nif;
        }
        public ListBox.ObjectCollection getPedidos(ListBox.ObjectCollection pedidos)
        {
            return this.pedidos;
        }
        public void setPedido()
        {
            this.pedidos = pedidos;
        }
    }
}
