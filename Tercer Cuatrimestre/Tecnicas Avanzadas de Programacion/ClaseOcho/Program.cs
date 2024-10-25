using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WalterBaya
{

    class Program
    {
        static void Main(string[] args)
        {
            Jugador deyverson= new Jugador("Deyverson", 9, 87, 79, 0, 10);
            Arquero armani = new Arquero("Armani", 1, 37, 5, 0, 0);
            Console.WriteLine(deyverson.Getnombre());
            deyverson.patear(1);
            Console.WriteLine(armani.Getnombre());
            armani.agarrarConLaMano();
            Console.WriteLine(deyverson.Getnombre());
            deyverson.patear(9);
            armani.Sethabilidad(10);
            Console.WriteLine(armani.Gethabilidad());
            Console.WriteLine("Gol");
        }
    }
    
    class Jugador
    {
        protected string nombre;
        protected int numero;
        protected int habilidad;
        protected int velocidad;
        protected int x, y;

        public Jugador(string nombre, int numero, int habilidad, int velocidad, int x, int y) {
            this.nombre = nombre;
            this.numero = numero;
            this.habilidad = habilidad;
            this.velocidad = velocidad;
            this.x = x;
            this.y = y; 
        }

        public string Getnombre()
        {
            return nombre;
        }

        public void Setnombre(string value)
        {
            nombre = value;
        }

        public int Getnumero()
        {
            return numero;
        }

        public void Setnumero(int value)
        {
            numero = value;
        }

        public int Gethabilidad() { 
            return habilidad;
        }

        public void Sethabilidad(int value)
        {
            habilidad = value;
        }

        public int Getvelocidad()
        {
            return velocidad;
        }

        public void Setvelocidad(int value)
        {
            velocidad = value;
        }

        public void Setx(int value)
        {
            x = value;
        }

        public int Getx() {
            return x;
        }

        public void Sety(int value)
        {
            y = value;
        }

        public int Gety()
        {
            return y;
        }


        public void mover(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public void patear(int fuerza)
        {
            if (fuerza >= 1 && fuerza <= 3)
            {
                Console.WriteLine("Disparo débil");
            }
            else if (fuerza >= 4 && fuerza <= 8)
            {
                Console.WriteLine("Disparo medio");
            }
            else if (fuerza >= 9 && fuerza <= 10)
            {
                Console.WriteLine("Disparo potente");
            }
            else
            {
                Console.WriteLine("ERROR! Valor de Fuerza incorrecto");
            }
        }
    }

    class Arquero : Jugador
    {
        public Arquero(string nombre, int numero, int habilidad, int velocidad, int x, int y) : base(nombre, numero, habilidad, velocidad, x, y) { 
        
        }

        public void agarrarConLaMano() {
            Console.WriteLine("Agarrar con la mano.");
        }
    }
}
