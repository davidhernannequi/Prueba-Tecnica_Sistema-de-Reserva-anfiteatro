using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dominio
{
    public class Ticket
    {
        public int Numero { get; set; }

        public int Fila { get; set; }

        public int Asiento { get; set; }

        public DateTime FechaCompra { get; set; }

        public DateTime FechaValidez { get; set; }

        public decimal Precio { get; set; }

        public Ticket ()
        {
        }

        public  Ticket(int numero, int fila, int asiento, DateTime fechaCompra, DateTime fechaValidez, decimal precio)
        {
            Numero = numero;
            Fila = fila;
            Asiento = asiento;
            FechaCompra = fechaCompra;
            FechaValidez = fechaValidez;
            Precio = precio;
        }

        public override string ToString()
        {
            return "Ticket{ " + "Numero: " + Numero + ", fila: " + Fila + ", asiento: " + Asiento + ", fecha de Compra: " + FechaCompra + " , fecha de Validez: " + FechaValidez + " , precio: " + Precio + " }";
        }
    }
}