namespace Semana_14_Laboratorio_1326223_Gabriela_Quan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 7 numeros enteros para indicar el mayor y el menor, ademas de la cantidad de positivos y negativos");
            bool OtraSecuencia = false;
            do
            {
                int num1, num2, num3, num4, num5, num6, num7;
                Console.ReadKey();
                int NumMayor;
                int NumMenor;
                int Positivos;
                int Negativos;

                Console.WriteLine("El numero mayor es: ");
                Console.WriteLine("El numero menor es: ");
                Console.WriteLine("La cantidad de numeros positivos es: ");
                Console.WriteLine("La cantidad de numeros negativos es: ");

                Console.WriteLine("Desea ingresar otra secuencia de numeros?");
                string RespSecuencia = "";
                Console.ReadKey();
                
                if (RespSecuencia == "si") ;
                OtraSecuencia = true;


                Console.ReadKey();
            } while (OtraSecuencia = true);
        }
    }
}