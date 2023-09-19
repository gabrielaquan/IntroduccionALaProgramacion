using System.ComponentModel.Design;

namespace Codigo_2
{
class Program
{
        static void Main(string[]args)
        {
            Console.WriteLine("Ejercicio 2: Operaciones booleanas");
            Console.WriteLine("Ingrese un numero");
            string numero1 = Console.ReadLine();
            int num1 = Convert.ToInt32(numero1);

            Console.WriteLine("Ingrese otro numero");
            string numero2 = Console.ReadLine();
            int num2 = Convert.ToInt32(numero2);

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " es mayor que " + num2);
            }
            else if(num1 < num2)
            {
                Console.WriteLine(num1 + " es menor que " + num2);
            }
            else
                Console.WriteLine("Los numeros son iguales");
        }
}
}