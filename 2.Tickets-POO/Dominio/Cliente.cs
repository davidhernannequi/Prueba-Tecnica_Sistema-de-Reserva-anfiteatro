using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Cliente
    {
        public int id { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set;}
        public List<Ticket> listaTicketsCliente { get; set; }

        public Cliente()
        { 
        }

        public Cliente(int id, string dni, string nombre, string apellido, List<Ticket> listaTicketsCliente)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.listaTicketsCliente = listaTicketsCliente;
        }
    }
}
