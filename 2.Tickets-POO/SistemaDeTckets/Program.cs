using dominio;

namespace negocio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //estructura y tipo de dato
            List<Ticket> listaTicket = new List<Ticket>();


            //creacion de tickets mediante paso por parametros al constructor
            Ticket ticket1 = new Ticket(1, 1, 1, new DateTime(), new DateTime(), 2300);

            Ticket ticket2 = new Ticket(2, 1, 2, new DateTime(), new DateTime(), 2300);

            //creacion de ticket mediante constructor vacio usando setters (POO-Encapsulamiento)
            Ticket ticket3 = new Ticket();
            ticket3.Numero = 3;
            ticket3.Fila = 4;
            ticket3.Asiento = 5;
            ticket3.FechaCompra = new DateTime();
            ticket3.FechaValidez = new DateTime();
            ticket3.Precio = 2500;

            //agrego los elementos a la lista
            listaTicket.Add(ticket1);
            listaTicket.Add(ticket2);
            listaTicket.Add(ticket3);

            //suma del total de los precios de los tickets


            decimal suma = 0;
            
            foreach(Ticket ticket in listaTicket)
            {
                suma += ticket.Precio;
            }

            Console.WriteLine("El total de la suma de precio es: $" + suma);

            //punto 4 solicitar ingreso de una fila y mostrar datos de esos asientos
            bool banderaFila = false;

            Console.Write("(del 0 al 9) Ingrese la Fila: ");
            int fila = int.Parse(Console.ReadLine());

            foreach (var ticket in listaTicket)
            {
                if(ticket.Fila == fila)
                {
                    Console.WriteLine(ticket.ToString());
                    banderaFila = true;
                }
            }

            if(banderaFila == false)
            {
                Console.WriteLine("No hay datos de esa fila!");
            }


            //prueba de cliente 
            Cliente cliente = new Cliente();
            cliente.listaTicketsCliente = new List<Ticket>();
            cliente.id = 1;
            cliente.dni = "123456789";
            cliente.nombre = "nombre";
            cliente.apellido = "apellido";
            cliente.listaTicketsCliente.Add(ticket1);

            Ticket ticket4 = new Ticket(4, 8, 6, new DateTime(2020-09-12), new DateTime(2021-09-12), 2000);
            cliente.listaTicketsCliente.Add(ticket4);
        }

    }
}
