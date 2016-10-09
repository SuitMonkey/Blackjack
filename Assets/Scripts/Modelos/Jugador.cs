using System;
using System.Collections;


namespace Modelos
{
    public class Jugador
    {
        private int dinero;
        private int apuesta;

        private string nombre;
        public object mano;

        public Jugador(string nombre, int dinero)
        {
            this.dinero = dinero;
            this.apuesta = 0;
            this.nombre = nombre;
           
        }

        public void limpiarApuesta()
        {
            this.apuesta = 0;
        }

        public void apostar(int cantidad)
        {
            this.apuesta += cantidad;
            this.dinero -= cantidad;
        }

        public int Dinero
        {
            get { return dinero; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Cantidad invalida" + value);
                }
                else
                {
                    dinero = value;
                }
            }
        }

    }


}

