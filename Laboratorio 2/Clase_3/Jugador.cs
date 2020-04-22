using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    public class Jugador
    {
        const int DERECHA = 1;
        const int IZQUIERDA = 2;
        const int ABAJO = 3;
        const int ARRIBA = 4;

        public string nombre;
        public static int numeroJugadores;
        private int posicionX;
        private int posicionY;
        public int vida;
        public int movimiento;
        public bool isAlive;

        static Jugador()
        {
            numeroJugadores = 0;
        }
        public Jugador(string nombre, bool posicionDerecha)
        {
            Jugador.numeroJugadores++;
            this.vida = 100;
            this.nombre = nombre;
            this.isAlive = true;
            posicionX = 10;
            posicionY = 10;
            movimiento = DERECHA;

            if (posicionDerecha)
            {
                posicionX = 70;
                movimiento = IZQUIERDA;

            }

            pintar();

        }
        private void pintar()
        {
            Console.CursorLeft = posicionX;
            Console.CursorTop = posicionY;
            Console.WriteLine("█");


        }
        public void mover()
        {
            Console.CursorLeft = posicionX;
            Console.CursorTop = posicionY;
            Console.Write(" ");

            switch (movimiento)
            {
                case DERECHA:
                    posicionX++;
                    break;
                case IZQUIERDA:
                    posicionX--;
                    break;
                case ARRIBA:
                    posicionY--;
                    break;
                case ABAJO:
                    posicionY++;
                    break;

            }
            pintar();
        }
    }
}
