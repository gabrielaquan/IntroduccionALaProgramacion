namespace Semana_7_Laboratorio_1326223_Gabriela_Quan
{
    internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 1: operaciones aritmeticas");
        Console.WriteLine("Ingrese un numero: ");
        string numero1 = Console.ReadLine();
        int num1 = Convert.ToInt32(numero1);
        
        Console.WriteLine("Ingrese otro numero entero");
        string numero2 = Console.ReadLine();
        int num2 = Convert.ToInt32(numero2);

        Console.WriteLine("suma"+num1 + "+" + num2 +"="+ (num1 + num2));
        Console.ReadLine();
        Console.WriteLine("resta"+num1 + "-" + num2 +"="+ (num1 - num2));
        Console.ReadLine();
        Console.WriteLine("muliplicacion"+num1 + "*" + num2 +"="+ (num1 * num2));
        Console.ReadLine();
        Console.WriteLine("division"+num1 + "/" + num2 +"="+(num1/num2));
        Console.ReadLine();
    }
}
}
