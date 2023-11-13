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
                Console.WriteLine("\nIngrese la cantidad de tiros a realizar en cada partida");
                Tiros = Convert.ToInt32(Console.ReadLine());

                if (Tiros%2 == 0)
                {
                    VTiros = true;
                }
                else
                {
                    VTiros = false;
                    Console.WriteLine("\nERROR. Por favor ingrese un numero par de tiros para usted y la casa.");
                }
            } while (VTiros == false);

            int[] XTiro = new int[Tiros];

            //Contadores
            double Contador = 0;
            double PrimerTiro;
            double PuntosJugador = 0;
            double TotalJugador = 0;
            double PuntosCasa = 0;
            double TotalCasa = 0;

            double JugadorGano = 0;
            double TirosPares = 0;
            double TirosImpares = 0;
            double TirosIguales = 0;

            //Comenzando las partidas...
            for (int XPartida = 1; XPartida <= Partidas; XPartida++)
            {
                Console.WriteLine("\nPartida No. " + XPartida);

                for (int TiroNum = 1; TiroNum <= Tiros; TiroNum++)
                {
                    Console.WriteLine("Tiro No. " + TiroNum);

                    Random dados = new Random();
                    int dado1 = dados.Next(1, 7);
                    Console.WriteLine("\nEl primer dado arrojo un resultado de: " + dado1);
                    int dado2 = dados.Next(1, 7);
                    Console.WriteLine("\nEl segundo dado arrojo un resultado de: " + dado2);

                    Contador = dado1 + dado2;
                    PrimerTiro = Contador;
                    Console.WriteLine("\nEl resultado del tiro es: " +Contador);

                    //Contar los tiros pares, impares e iguales
                    if (Contador%2 == 0)
                    {
                        TirosPares++;
                    }
                    else if (Contador%2 != 0)
                    {
                        TirosImpares++;
                    }
                    else if (dado1 == dado2)
                    {
                        TirosIguales++;
                    }

                    //Definir los puntos en los tiros

                    if (PrimerTiro%2 != 0) //Tiros del Jugador
                    {
                        //Condiciones del primer tiro por el jugador

                        if (Contador == 6 || Contador == 12)
                        {
                            Contador = XTiro[1];
                            PuntosJugador = 12;
                            TotalJugador += PuntosJugador;
                            
                            JugadorGano++;
                            
                            Console.WriteLine("\nSus probabilidades de ganar puntos fueron de " + (8/11));
                        }
                        else if (XTiro[1] == 4 || XTiro[1] == 10)
                        {
                            PuntosCasa = 12;
                            TotalCasa += PuntosCasa;
                            
                            Console.WriteLine("\nSus probabilidades de ganar puntos fueron de " + (8/11));
                        }

                        else if (Contador == 2 || Contador == 3 || Contador == 5 || Contador == 7 || Contador == 8 || Contador == 9)
                        {
                            PuntosJugador = Contador;
                            TotalJugador += PuntosJugador;

                            JugadorGano++;

                            Console.WriteLine("\nSus probabilidades de ganar puntos fueron de " + (6/11));
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
                    else if (XTiro[Tiros]%2 == 0) //Tiros de la casa
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
                    Console.WriteLine($"\nUsted ha ganado la partida No. {XPartida} con {TotalJugador} puntos.");
                }
                else
                {
                    Console.WriteLine($"\nLa casa ha ganado la partida No. {XPartida} con {TotalCasa} puntos");
                }

                //En cuantas partidas gano puntos el jugador
                Console.WriteLine($"\nUsted gano puntos en {JugadorGano} tiros.");

                //Tiros pares, impares e iguales
                Console.WriteLine($"\nDe los tiros que usted realizo usted obtuvo: \n{TirosPares} tiros pares. \n{TirosImpares} tiros impares. \n{TirosPares} tiros donde los dados salieron con numeros iguales.");
            }
        }
    }
}