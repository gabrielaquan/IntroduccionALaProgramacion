namespace T4_Gabriela_Quan_1326223_E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar 3 variables de la ecuacion Vf=Vo+at para despejar la faltante");
            Console.WriteLine("Para la variable faltante escriba <0>, representando variable faltante");

            Console.WriteLine("Ingrese los datos");
            Console.WriteLine("Velocidad final: ");
            string variable1 = Console.ReadLine();
            int num1 = Convert.ToInt32(variable1);

            Console.WriteLine("Velocidad incial: ");
            string variable2 = Console.ReadLine();
            int num2 = Convert.ToInt32(variable2);

            Console.WriteLine("Aceleración: ");
            string variable3 = Console.ReadLine();
            int num3 = Convert.ToInt32(variable3);

            Console.WriteLine("Tiempo: ");
            string variable4 = Console.ReadLine();
            int num4 = Convert.ToInt32(variable4);

            if (num1 == 0 && num2 == 0 || num1 == 0 && num3 == 0 || num1 == 0 && num4 == 0 || num2 == 0 && num3 == 0 || num2 == 0 && num4 == 0 || num3 == 0 && num4 == 0)
            {
                Console.WriteLine("ERROR: Ingrese la cantidad correcta de variables");
            }
            else if (num1 == 0)
            {
                Console.WriteLine("La velocidad final es igual a " + (num1 + (num3 * num4)));
            }
            else if (num2 == 0)
            {
                Console.WriteLine("La velocidad inicial es igual a " + (num1 - (num3 * num4)));
            }
            else if (num3 == 0)
            {
                Console.WriteLine("La aceleración es igual a " + (num1 - (num3 * num4)));
            }
            else if (num4 == 0)
            {
                Console.WriteLine("El tiempo es igual a " + (num1-num2)/num3);
            }
        }
    }
}