using System.ComponentModel.DataAnnotations.Schema;

namespace L9_GMQL_1326223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero mayor a 0 <N>");
            int numero = Convert.ToInt32(Console.ReadLine()); 
            int contador = 1;
            int sumatoria = 0;

            do
            {
                sumatoria = sumatoria + contador;
                contador++;
            } while (contador <= numero);

            Console.WriteLine("La suma desde 1 hasta el numero ingresado es: " + sumatoria);
            Console.ReadKey();
        }
    }
}