
internal class Program
{
    private static void Main(string[] args)
    {

        try
        {
            int fila, asiento;
            char respuesta, mostrarAsientos;
            bool bandera = false;
            char[,] asientos = new char[10, 10];

            for (int f = 0; f < 10; f++)
            {
                for (int a = 0; a < 10; a++)
                {
                    asientos[f, a] = 'L';
                }
            }

            Console.WriteLine("----Bienvenido al Sistema de Reserva----");

            while (bandera != true)
            {
                Console.Write("(s = si, cualquier otra tecla = no) Querrias ver asientos disponibles?: ");
                mostrarAsientos = char.Parse(Console.ReadLine());

                if (mostrarAsientos == 's')

                {
                    AsientosDisponibles(asientos);
                }


                Console.WriteLine("Ingresa la fila y el asiento que queres reservar");

                Console.Write("(Entre 0 y 9) La fila elegida es: ");
                fila = int.Parse(Console.ReadLine());

                Console.Write("(Entre 0 y 9) El asiento elegido es: ");
                asiento = int.Parse(Console.ReadLine());

                if (asientos[fila, asiento] == 'L')
                {
                    asientos[fila, asiento] = 'X';
                    Console.WriteLine("Asiento reservado con exito!");
                }
                else
                {
                    Console.WriteLine("Asiento ocupado!");
                }

                Console.Write("¿Deseas terminar la reserva? (s = si, cualquier otra tecla = no)");
                respuesta = char.Parse(Console.ReadLine());

                if (respuesta == 's')
                {
                    bandera = true;
                }
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine("Ingresa datos validos!");
        }

        finally {  Console.WriteLine("Gracias por usar el sistema de reserva!"); }
        

        void AsientosDisponibles(char[,] asientos)
        {
            for (int f = 0; f < 10; f++)
            {
                Console.Write(f + " ");
                for (int a = 0; a < 10; a++)
                {
                    Console.Write(" [ " + asientos[f, a] + "] ");
                }
                Console.WriteLine("");
            }
        }
    }
}