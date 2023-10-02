namespace Ejercicio_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero para mostrar su tabla de multiplicar: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine($"Tabla de multiplicar de {numero}:");

                for (int i = 1; i <= 10; i++)
                {
                    int total = numero * i;
                    Console.WriteLine($"{numero} x {i} = {total}");
                }
            }
            else
            {
                Console.WriteLine("ERROR. Ingrese un numero entre el 1 al 10.");
            }
            Console.ReadKey();
        }
    }
}