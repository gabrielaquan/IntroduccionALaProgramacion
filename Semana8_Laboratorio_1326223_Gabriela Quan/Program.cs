using System.ComponentModel.Design;

namespace L7_GMQL_1326223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero positivo");
            int N = Convert.ToInt32(Console.ReadLine());
            int A = 0, B = 1, C = 0, i = 2;
            string resultado = "";

            if (N == 0)
            {
                resultado = A.ToString();
                if (N > 1)
                {
                    resultado += B.ToString();
                    while (i < N)
                    {
                        C = A + B;
                        resultado += C.ToString();
                        A = B;
                        B = C;
                        i++;
                    }
                    Console.WriteLine("Resultado: " + resultado);
                }

                else
                {
                    Console.WriteLine("Resultado: " + resultado);
                }
            }
            else
            {
                Console.WriteLine("Resultado: " + resultado);
            }
        }
    }
}


