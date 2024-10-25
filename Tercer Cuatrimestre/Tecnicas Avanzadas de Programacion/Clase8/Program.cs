using System;

namespace Baya_Walter
{

    class Animal
    {
        protected int edad;
        protected string nombre;
        protected string tipo;

        public string Tipo
        {
            get;
        }

        public int Edad
        {
            get;
        }

        public string Nombre
        {
            get; set;
        }

        public Animal(int edad, string nombre, string tipo)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public Animal(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public Animal(int edad)
        {
            this.edad = edad;
            this.nombre = "Sin nombre";
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("***** " + this.tipo + " *****");
            Console.WriteLine("Edad: " + this.edad);
            Console.WriteLine("Nombre: " + this.nombre);
        }

        public void Cumpleanios()
        {
            this.edad++;
        }
    }

    class Gato : Animal
    {
        protected int patas;
        protected string colorDePelo;

        public int Patas
        {
            get; set;
        }

        public string ColorDePelo
        {
            get;
        }

        public Gato(int edad, string nombre, string colorDePelo) : base(edad, nombre)
        {
            this.patas = 4;
            this.colorDePelo = colorDePelo;
            this.tipo = "Gato";
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Color de pelo: " + this.colorDePelo);
        }
    }

    class Perro : Animal
    {
        protected string raza;
        protected float peso;

        public string Raza
        {
            get;
        }

        public float Peso
        {
            get; set;
        }

        public Perro(int edad, string nombre, string raza, int peso) : base(edad, nombre)
        {
            this.raza = raza;
            this.peso = peso;
            this.tipo = "Perro";
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Raza: " + this.raza);
            Console.WriteLine("Peso: " + this.peso);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** NUEVO ANIMAL *****");
            Console.WriteLine("1. Nuevo gato");
            Console.WriteLine("2. Nuevo perro");
            Console.WriteLine("3. Mi animal no es gato ni perro");

            Console.WriteLine("Elegí una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("***** NUEVO GATO *****");
                    //... pedir nombre, edad, color de pelo
                    break;
                case 2:
                    Console.WriteLine("***** NUEVO PERRO *****");
                    //... pedir nombre, edad, raza, peso
                    break;
                case 3:
                    Console.WriteLine("***** NUEVO ANIMAL *****");
                    Console.WriteLine("¿Qué animal querés agregar?: ");
                    string tipo = Console.ReadLine();
                    Console.Clear();
                    //... pedir nombre, edad, llenar el constructor con todos los campos.
                    break;
            }
        }
    }
}
