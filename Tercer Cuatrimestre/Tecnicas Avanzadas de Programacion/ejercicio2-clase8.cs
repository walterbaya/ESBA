using System;

namespace GalagaGame
{
    // Definición de la estructura POINT
    public struct POINT
    {
        public int x;
        public int y;
    }

    // Clase abstracta CSpaceShip
    public abstract class CSpaceShip
    {
        protected POINT posicion;
        protected string parametroDisparo;
        protected int velocidad;

        //Aunque no se puede instanciar si tiene constructores
        public CSpaceShip(int x = 0, int y = 0, int velocidad = 0, parametroDisparo = "")
        {
            posicion.x = x;
            posicion.y = y;
            this.velocidad = velocidad;
            this.parametroDisparo = parametroDisparo;
            
        }

        public abstract void Volar(int dx, int dy);
        public void Disparar()
        {
            Console.WriteLine($"Dispara: | en posición ({posicion.x}, {posicion.y})");
        };
        public virtual POINT GetXYPos()
        {
            return posicion;
        }

        public abstract bool GetColision(POINT otherposicion);
        public virtual void Acelerar(int value) {}
    }

    // Clase derivada CHeroe
    public class CHeroe : CSpaceShip
    {
        public CHeroe(int x = 0, int y = 0, int velocidad = 0) : base(x, y, velocidad) {}

        public override void Volar(int dx, int dy)
        {
            posicion.x += dx * velocidad;
        }

        public override bool GetColision(POINT posicion)
        {
            return posicion.x == otraPosicion.x && posicion.y == otraPosicion.y;
        }
    }

    // Clase derivada CAlien
    public class CAlien : CSpaceShip
    {
        public CAlien(int x = 0, int y = 0, int velocidad = 0) : base(x, y, velocidad) {}

        public override void Volar(int dx, int dy)
        {
            posicion.x += dx * velocidad;
            posicion.y += dy * velocidad; // El alien se mueve en ambas direcciones
        }

        public override bool GetColision(POINT posicionDeOtro)
        {
            return posicion.x == posicionDeOtro.x && posicion.y == posicionDeOtro.y;
        }

        public override void Acelerar(int value)
        {
            if (value >= -5 && value <= 5)
            {
                velocidad += value;
                Console.WriteLine($"Alien acelera a velocidad {velocidad}");
            }
            else
            {
                Console.WriteLine("Valor de aceleración fuera de rango (-5 a 5)");
            }
        }
    }

    // Programa principal para ejemplificar el uso de las clases
    class Program
    {
        static void Main(string[] args)
        {
            CHeroe heroe = new CHeroe(0, 5);
            CAlien alien = new CAlien(10, 10);

            heroe.Volar(5, 5);
            heroe.Disparar();
            Console.WriteLine($"Posición del héroe: ({heroe.GetXYPos().x}, {heroe.GetXYPos().y})");

            alien.Volar(-3, -3);
            alien.Disparar();
            alien.Acelerar(3);
            Console.WriteLine($"Posición del alien: ({alien.GetXYPos().x}, {alien.GetXYPos().y})");

            POINT otraPosicion = new POINT { x = 5, y = 5 };
            Console.WriteLine($"¿Colisión del héroe en (5,5)?: {heroe.GetColision(otraPosicion)}");
        }
    }
}

