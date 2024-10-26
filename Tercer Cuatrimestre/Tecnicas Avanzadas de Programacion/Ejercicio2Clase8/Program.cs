using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WalterBaya
{

    public struct POINT
    {
        public int x;
        public int y;

        public POINT(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            cHeroe cHeroe = new cHeroe(5, new POINT(0,0));
            cAlien cAlien = new cAlien(5, new POINT(0, 0));

        }
        //List<cAlien> alienList = new List<cAlien>();
        //List<cHeroe> heroesList = new List<cHeroe>();
    }

    class CSpaceship
    {
        protected string parametroDisparo;
        protected int velocidad;
        protected POINT p;

        public CSpaceship(string parametroDisparo, int velocidad, POINT p) 
        {
            this.parametroDisparo = parametroDisparo;
            this.velocidad = velocidad;
            this.p = p;
        }

        public virtual void acelerar(int a)
        {
        }

        public virtual void volar(int x, int y)
        {
            p.x = p.x + x;
            p.y = p.y = y;
        }

        public void disparar()
        {
            for (int j = 0; j < (p.y) - 1; j++)
            {
                for (int i = 0; i < p.x; i++)
                {
                    Console.Write("");
                }
                Console.Write("\n");
            }
            Console.Write(parametroDisparo);
        }

        public POINT getXYPos()
        {
            return p;
        }
    
        public int getColission(POINT p) {
            int res = 0;
            //List<cAlien> aliensInColission = alienList.FindAll(alien => (alien.getXYPos().x == p.x && alien.getXYPos().y == p.y));
            //List<cHeroe> heroesInColission = heroesList.FindAll(alien => (alien.getXYPos().x == p.x && alien.getXYPos().y == p.y));
            //if (aliensInColission.Count >= 1 || heroesInColission.Count >= 1) {
            //    res = 1;
            //}

            return res;
        }


    }

    class cHeroe : CSpaceship {

        public cHeroe(int velocidad, POINT p) : base("|", velocidad, p) 
        { 
        }

        public override void volar(int x, int y) {
            p.x = x;
        }
    }

    class cAlien : CSpaceship
    {
        public cAlien(int velocidad, POINT p) :base("*", velocidad, p) { 
        }
 
        public override void volar(int x, int y)
        {
            p.x = x;
            p.y = y;
        }
        public override void acelerar(int velocidad)
        {
            if (velocidad <= 5 && velocidad >= -5) {
                this.velocidad = velocidad;
            }
            else {
                Console.WriteLine("Error, la velocidad debe estar entre -5 y 5");
            }
        }
    }
}
