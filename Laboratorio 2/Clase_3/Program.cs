using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clase_3
{
    class Program
    {
        const int LIMITEDERECHA = 80;

        const int DERECHA = 1;
        const int IZQUIERDA = 2;
        const int ABAJO = 3;
        const int ARRIBA = 4;

        public void metodo()
        {

        }
        static void Main(string[] args)
        {
           


                //Jugador gamer1 = new Jugador("Mich", true);
                //gamer1.mover();
                Jugador.numeroJugadores = 0;
                Jugador[] jugadores = new Jugador[4];
                //jugadores.SetValue(new Jugador("mich", true), 0);


                ConsoleKeyInfo consoleKeyInfo;
                #region
                for (int i = 0; i < 20; i++)
                {
                    Console.CursorLeft = 1;
                    Console.CursorTop = i;
                    Console.Write("█");
                    Console.CursorLeft = 80;
                    Console.CursorTop = i;
                    Console.Write("█");

                }
                for (int i = 1; i < 80; i++)
                {
                    Console.CursorLeft = i;
                    Console.CursorTop = 1;
                    Console.Write("█"); //alt+219
                    Console.CursorLeft = i;
                    Console.CursorTop = 20;
                    Console.Write("█");
                }
                #endregion
                do
                {

                    while (!Console.KeyAvailable)
                    {
                        foreach (Jugador jugador in jugadores)
                        {
                            if (jugador != null)
                            {
                                jugador.mover();
                            }

                        }

                        Thread.Sleep(100);
                    }
                    consoleKeyInfo = Console.ReadKey();
                    //contral k+ d para acomodar el codigo

                    if (consoleKeyInfo.Key == ConsoleKey.N)
                    {
                        if (Jugador.numeroJugadores < 4)
                        {
                            jugadores[Jugador.numeroJugadores] = new Jugador("jugador" + (Jugador.numeroJugadores + 1), false);
                        }

                    }

                    foreach (Jugador jugador in jugadores)
                    {
                        #region movimiento
                        if (jugador != null)
                        {
                            switch (consoleKeyInfo.Key)
                            {
                                case ConsoleKey.UpArrow:
                                    jugador.movimiento = ARRIBA;
                                    break;

                                case ConsoleKey.DownArrow:
                                    jugador.movimiento = ABAJO;
                                    break;

                                case ConsoleKey.LeftArrow:
                                    jugador.movimiento = IZQUIERDA;
                                    break;

                                case ConsoleKey.RightArrow:
                                    jugador.movimiento = DERECHA;
                                    break;
                            }
                        }
                        #endregion
                    }


                } while (consoleKeyInfo.KeyChar != 27);
            }
        } 
}
