using System;
using System.ComponentModel.Design;

namespace Proyecto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cantidad de Partidas
            Console.WriteLine("Ingrese la cantidad de partidas que desea jugar.");
            int Partidas = Convert.ToInt32(Console.ReadLine());

            //Verificacion que la cantidad de tiros sea par
            int Tiros;
            bool VTiros = false;
            do
            {
                Console.WriteLine("\nIngrese la cantidad de tiros a realizar en cada partida. Por favor ingrese un numero impar, tomando en cuenta que el numero de tiros sera el numero que ingrese menos 1");
                Tiros = Convert.ToInt32(Console.ReadLine());

                if (Tiros % 2 == 0)
                {
                    VTiros = false;
                    Console.WriteLine("\nERROR. Por favor ingrese un numero impar de tiros para usted y la casa, tomando en cuenta que el numero de tiros sera el numero que ingrese menos 1.");
                }
                else
                {
                    VTiros = true;
                }
            } while (VTiros == false);

            //Contadores
            double Contador = 0;
            double PuntosJugador = 0;
            double TotalJugador = 0;
            double PuntosCasa = 0;
            double TotalCasa = 0;

            double JugadorGano = 0;
            double TirosPares = 0;
            double ParesTotales = 0;
            double TirosImpares = 0;
            double TirosIguales = 0;

            int[] XTiro = new int[Tiros];

            //Comenzando las partidas...
            for (int XPartida = 1; XPartida <= Partidas; XPartida++)
            {
                Console.WriteLine("\nPartida No. " + XPartida);

                for (int TiroNum = 1; TiroNum < Tiros; TiroNum++)
                {
                    Console.WriteLine("\nTiro No. " + TiroNum);

                    Random dados = new Random();
                    int dado1 = dados.Next(1, 7);
                    Console.WriteLine("\nEl primer dado arrojo un resultado de: " + dado1);
                    int dado2 = dados.Next(1, 7);
                    Console.WriteLine("\nEl segundo dado arrojo un resultado de: " + dado2);

                    Contador = dado1 + dado2;

                    Console.WriteLine("\nEl resultado del tiro es: " + Contador);

                    //Definir los puntos en los tiros
                    if (XTiro[TiroNum]%2 != 0) //Tiros del Jugador
                    {
                        //Contar los tiros pares, impares e iguales
                        if (Contador % 2 == 0)
                        {
                            TirosPares++;
                            TirosPares += TirosPares;
                        }
                        else if (Contador%2 != 0)
                        {
                            TirosImpares++;
                            TirosImpares += TirosImpares;
                        }
                        else if (dado1 == dado2)
                        {
                            TirosIguales++;
                            TirosIguales += TirosIguales;
                        }

                        //Condiciones del primer tiro por el jugador

                        if (XTiro[1] == 6 || XTiro[1] == 12)
                        {
                            PuntosJugador = 12;
                            TotalJugador += PuntosJugador;

                            JugadorGano++;

                            Console.WriteLine("\nSus probabilidades de ganar puntos fueron de 72.73%");
                        }
                        else if (XTiro[1] == 4 || XTiro[1] == 10)
                        {
                            PuntosCasa = 12;
                            TotalCasa += PuntosCasa;

                            Console.WriteLine("\nSus probabilidades de ganar puntos fueron de 72.73%");
                        }
                        else if (Contador == 2 || Contador == 3 || Contador == 5 || Contador == 7 || Contador == 8 || Contador == 9)
                        {
                            PuntosJugador = Contador;
                            TotalJugador += PuntosJugador;

                            JugadorGano++;

                            Console.WriteLine("\nSus probabilidades de ganar puntos fueron de 54.55%");
                        }
                        else if (Contador == 11)
                        {
                            if (TotalJugador == 0)
                            {
                                PuntosCasa = 6;
                                TotalCasa += PuntosCasa;
                            }
                        }
                    }

                    if (XTiro[TiroNum]%2 == 0) //Tiros de la casa
                    {
                        if (Contador == 2 || Contador == 3 || Contador == 5 || Contador == 7 || Contador == 8 || Contador == 9)
                        {
                            PuntosCasa = Contador;
                            TotalCasa += PuntosCasa;
                        }
                    }

                }

                //Ganador de la partida
                if (TotalJugador > TotalCasa)
                {
                    Console.WriteLine($"\nUsted ha ganado la partida No. {XPartida} con {TotalJugador} puntos. La casa obtuvo {TotalCasa} puntos.");
                }
                else if (TotalJugador < TotalCasa)
                {
                    Console.WriteLine($"\nLa casa ha ganado la partida No. {XPartida} con {TotalCasa} puntos. Usted obtuvo {TotalJugador} puntos.");
                }

                //En cuantas partidas gano puntos el jugador
                Console.WriteLine($"\nUsted gano puntos en {JugadorGano} tiros.");

                //Tiros pares, impares e iguales
                Console.WriteLine($"\nDe los tiros que usted realizo usted obtuvo: \n{TirosPares} tiros pares. \n{TirosImpares} tiros impares. \n{TirosIguales} tiros donde los dados salieron con numeros iguales.");
            }
        }
    }
}