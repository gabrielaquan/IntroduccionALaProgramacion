namespace Codigo_3_TS
{
    namespace Codigo_3
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Ejercicio 3: Jerarquia de operaciones");
                Console.WriteLine("Ingrese un numero A");
                string numero1 = Console.ReadLine();
                int num1 = Convert.ToInt32(numero1);

                Console.WriteLine("Ingrese un numero B");
                string numero2 = Console.ReadLine();
                int num2 = Convert.ToInt32(numero2);

                Console.WriteLine("Ingrese un numero C");
                string numero3 = Console.ReadLine();
                int num3 = Convert.ToInt32(numero3);

                int operacion1;
                int operacion2;

                operacion1 = (num1 * num2) + num3;
                operacion2 = num1 * (num2 + num3);

                Console.WriteLine("El resultado de la expresion (A*B)+C es " +operacion1);
                Console.ReadLine();

                Console.WriteLine("El resultado de la expresion A*(B+C) es " +operacion2);
                Console.ReadLine();
            }
        }
    }
}