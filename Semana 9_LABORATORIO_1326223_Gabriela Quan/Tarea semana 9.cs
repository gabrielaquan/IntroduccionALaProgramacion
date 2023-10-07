namespace Tarea_Semana_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero mayor a 0:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int contador = 1;

            int operacionA;
            int operacionB;

            if (contador <= numero) ;
            {
                operacionA = (1 / contador++);
                operacionB = (1 / 2^contador++);
                contador++;

            }
                Console.WriteLine($"La suma de los reciprocos desde 1 hasta el numero ingresado es {operacionA}");
                Console.WriteLine($"La suma de uno sobre dos elevado a la primera potencia hasta el numero ingresado es {operacionB}");
        }
    }
}