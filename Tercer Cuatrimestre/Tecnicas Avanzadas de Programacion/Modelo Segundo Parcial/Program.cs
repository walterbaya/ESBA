using static Baya_Walter.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Baya_Walter
{
    internal class Program
    {
        private static void Menu(ref List<Producto> productos)
        {
            int opcionElegida = 0;

            do
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("0 - Agregar Producto");
                Console.WriteLine("1 - Modificar Producto");
                Console.WriteLine("2 - Eliminar Producto");
                Console.WriteLine("3 - Listar Productos");
                Console.WriteLine("4 - Aplicar Descuento");
                Console.WriteLine("5 - Calcular Precio Por Página (Libros)");
                Console.WriteLine("6 - Calcular Precio Promedio");
                Console.WriteLine("7 - Generar Compra");
                Console.WriteLine("8 - Salir");
                Console.Write("Ingrese una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcionElegida) || opcionElegida < 0 || opcionElegida > 8)
                {
                    Console.WriteLine("Error: Ingresa un número entre 0 y 8.");
                    continue;
                }


                switch (opcionElegida)
                {
                        
                    case 0:
                        Console.Clear();
                        AgregarProducto(ref productos);
                        break;
                    case 1:
                        Console.Clear();
                        ModificarProducto(ref productos);
                        break;
                    case 2:
                        Console.Clear();
                        EliminarProducto(ref productos);
                        break;
                    case 3:
                        Console.Clear();
                        ListarProductos(ref productos);
                        break;
                    case 4:
                        Console.Clear();
                        AplicarDescuento(ref productos);
                        break;
                    case 5:
                        Console.Clear();
                        CalcularPrecioPorPagina(productos);
                        break;
                    case 6:
                        Console.Clear();
                        CalcularPrecioPromedio(productos);
                        break;
                    case 7:
                        Console.Clear();
                        GenerarCompra(productos);
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa, Nos Vemos!!!...");
                        break;
                }

            } while (opcionElegida != 8);
        }

        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();


            Producto coca = new Producto("Coca Cola Light", 1500);
            Electrodomestico aire = new Electrodomestico("Aire Split", 3000000, "Bangho");
            Libro metamorfosis = new Libro("La Metamorfosis", 50, "Franz Kafka", 280);

            productos.Add(coca);
            productos.Add(aire);
            productos.Add(metamorfosis);

            Menu(ref productos);
        }

        private static void AgregarProducto(ref List<Producto> productos)
        {
            //Nombre y precio se agrega a todos por igual

            Console.Write("Ingrese el tipo de producto (1 - Producto generico, 2 - Electrodoméstico, 3 - Libro): ");
            if (!int.TryParse(Console.ReadLine(), out int tipo) || tipo < 1 || tipo > 3)
            {
                Console.WriteLine("Error: Tipo de producto no válido, ingresá alguna de las opciones posibles.");
                return;
            }

            Console.Write("Ingresá el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresá el precio: ");
            if (!double.TryParse(Console.ReadLine(), out double precio) || precio < 0)
            {
                Console.WriteLine("Error: Ingresá un precio válido.");
                return;
            }

            switch (tipo)
            {
                case 1:
                    productos.Add(new Producto(nombre, precio));
                    break;
                case 2:
                    Console.Write("Ingresá la marca del electrodoméstico: ");
                    string marca = Console.ReadLine();
                    productos.Add(new Electrodomestico(nombre, precio, marca));
                    break;
                case 3:
                    Console.Write("Ingresá el autor del libro: ");
                    string autor = Console.ReadLine();

                    Console.Write("Ingresá la cantidad de páginas que tiene el libro: ");
                    if (!int.TryParse(Console.ReadLine(), out int paginas) || paginas <= 0)
                    {
                        Console.WriteLine("Error: Ingrese una cantidad de páginas válida.");
                        return;
                    }

                    productos.Add(new Libro(nombre, precio, autor, paginas));
                    break;
            }
        }

        //En este metodo y en otros varios estoy usando is, para no modificar la logica interna de la clase producto agregandole metodos extra
        private static void ModificarProducto(ref List<Producto> productos)
        {
            Console.Write("Ingrese el nombre del producto a modificar: ");
            string nombreProducto = Console.ReadLine();

            Producto productoAModificar = null;

            // Buscar el producto por nombre
            foreach (Producto producto in productos)
            {
                if (producto.Nombre == nombreProducto)
                {
                    productoAModificar = producto;
                    break;
                }
            }

            if (productoAModificar == null)
            {
                Console.WriteLine("Error: No se encontró producto con ese nombre.");
                return;
            }

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nSeleccione la propiedad a modificar:");
                Console.WriteLine("1. Nombre: " + productoAModificar.Nombre);
                Console.WriteLine("2. Precio: " + productoAModificar.Precio);

                if (productoAModificar is Electrodomestico electrodomestico)
                {
                    Console.WriteLine("3. Marca: " + electrodomestico.Marca);
                }
                else if (productoAModificar is Libro libro)
                {
                    Console.WriteLine("3. Autor: " + libro.Autor);
                    Console.WriteLine("4. Páginas: " + libro.Paginas);
                }

                Console.WriteLine("0. Finalizar modificación");

                Console.Write("Ingrese el número de la propiedad que desea modificar: ");
                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine("Error: Opción no válida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nuevo nombre: ");
                        productoAModificar.Nombre = Console.ReadLine();
                        Console.WriteLine("Nombre actualizado.");
                        break;

                    case 2:
                        Console.Write("Ingrese el nuevo precio: ");
                        if (double.TryParse(Console.ReadLine(), out double precio) && precio >= 0)
                        {
                            productoAModificar.Precio = precio;
                            Console.WriteLine("Precio actualizado.");
                        }
                        else
                        {
                            Console.WriteLine("Error: Ingrese un precio válido.");
                        }
                        break;

                    case 3:
                        if (productoAModificar is Electrodomestico electrodomesticoAModificar)
                        {
                            Console.Write("Ingrese la nueva marca: ");
                            electrodomesticoAModificar.Marca = Console.ReadLine();
                            Console.WriteLine("Marca actualizada.");
                        }
                        else if (productoAModificar is Libro libroAModificar)
                        {
                            Console.Write("Ingrese el nuevo autor: ");
                            libroAModificar.Autor = Console.ReadLine();
                            Console.WriteLine("Autor actualizado.");
                        }
                        break;

                    case 4:
                        if (productoAModificar is Libro libroAModificar1)
                        {
                            Console.Write("Ingrese el nuevo número de páginas: ");
                            if (int.TryParse(Console.ReadLine(), out int paginas) && paginas > 0)
                            {
                                libroAModificar1.Paginas = paginas;
                                Console.WriteLine("Número de páginas actualizado.");
                            }
                            else
                            {
                                Console.WriteLine("Error: Ingrese un número de páginas válido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida.");
                        }
                        break;

                    case 0:
                        continuar = false;
                        Console.WriteLine("Modificación finalizada.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }



        private static void EliminarProducto(ref List<Producto> productos)
        {
            Console.Write("Ingrese el nombre del producto a eliminar: ");
            string nombre = Console.ReadLine();

            Producto productoAEliminar = null;

            foreach (Producto producto in productos)
            {
                if (producto.Nombre.Equals(nombre))
                {
                    productoAEliminar = producto;
                    break; // Salir del bucle una vez que encontramos el producto
                }
            }

            if (productoAEliminar == null)
            {
                Console.WriteLine("Error: No se encontró un producto con ese nombre.");
                return;
            }

            try
            {
                productos.Remove(productoAEliminar);
                Console.WriteLine($"Producto '{nombre}' eliminado.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se ha producido un error al eliminar el producto: {ex.Message}");
            }
        }


        private static void ListarProductos(ref List<Producto> productos)
        {
            foreach (var producto in productos)
            {
                producto.Mostrar();
                Console.WriteLine();
            }
        }

        private static void AplicarDescuento(ref List<Producto> productos)
        {
            Console.Write("Ingrese el nombre del electrodoméstico para aplicar descuento: ");
            string nombreProducto = Console.ReadLine();

            Producto productoEncontrado = null;

            foreach (Producto producto in productos)
            {
                if (producto.Nombre == nombreProducto)
                {
                    productoEncontrado = producto;
                    break;
                }
            }

            if (productoEncontrado == null)
            {
                Console.WriteLine("Error: Producto no encontrado.");
                return;
            }

            //Solo los electrodomesticos tienen el metodo para aplicar descuento, por lo tanto supongo que unicamente
            //se va a aplicar descuento a este tipo de producto

            if (productoEncontrado is Electrodomestico electrodomestico)
            {
                Console.Write("Ingrese el porcentaje de descuento: ");
                if (!double.TryParse(Console.ReadLine(), out double porcentaje) || porcentaje < 0 || porcentaje > 100)
                {
                    Console.WriteLine("Error: Ingrese un porcentaje de descuento válido.");
                    return;
                }

                electrodomestico.AplicarDescuento(porcentaje);
                Console.WriteLine("Descuento aplicado.");
            }
        }


        private static void CalcularPrecioPorPagina(List<Producto> productos)
        {
            Console.Write("Ingrese el nombre del libro para calcular el precio por página: ");
            string nombreLibro = Console.ReadLine();

            Libro libroEncontrado = null;

            foreach (var producto in productos)
            {
                if (producto is Libro libro && libro.Nombre == nombreLibro)
                {
                    libroEncontrado = libro;
                    break;
                }
            }

            if (libroEncontrado == null)
            {
                Console.WriteLine("Error: No se encontró un libro con ese nombre.");
                return;
            }

            double precioPorPagina = libroEncontrado.CalcularPrecioPorPagina();
            Console.WriteLine($"El precio por página de '{libroEncontrado.Nombre}' es: {precioPorPagina:C}");
        }


        private static void CalcularPrecioPromedio(List<Producto> productos)
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos para calcular el precio promedio.");
                return;
            }

            double totalPrecio = 0;
            foreach (var producto in productos)
            {
                totalPrecio += producto.Precio;
            }

            double promedio = totalPrecio / productos.Count;
            Console.WriteLine($"El precio promedio de los productos es: {promedio:C}");
        }

        private static void GenerarCompra(List<Producto> productos)
        {
            double total = 0;

            while (true)
            {
                Console.Write("Ingrese el nombre del producto (o escriba 'fin' para finalizar): ");
                string nombre = Console.ReadLine();

                // Opción para finalizar la compra
                if (nombre.Equals("fin", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Finalizando la compra...");
                    break;
                }

                bool productoEncontrado = false;

                // Búsqueda del producto por nombre
                foreach (var producto in productos)
                {
                    if (producto.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        total += producto.Precio;
                        Console.WriteLine($"Producto '{producto.Nombre}' con precio {producto.Precio:C} agregado al total.");
                        productoEncontrado = true;
                        break;
                    }
                }

                if (!productoEncontrado)
                {
                    Console.WriteLine("Producto no encontrado. Intente nuevamente.");
                }
            }

            Console.WriteLine($"El total de la compra es: {total:C}");
        }

        public class Producto
        {
            protected string nombre;
            protected double precio;

            public string Nombre { get { return nombre; } set { nombre = value; } }
            public double Precio { get { return precio; } set { precio = value; } }

            public Producto(string nombre, double precio)
            {
                this.nombre = nombre;
                this.precio = precio;
            }

            public virtual void Mostrar()
            {
                Console.WriteLine("Producto: " + nombre);
                Console.WriteLine("Precio: " + precio);
            }
        }

        public class Electrodomestico : Producto
        {
            protected string marca;
            public string Marca { get { return marca; } set { marca = value; } }

            public Electrodomestico(string nombre, double precio, string marca) : base(nombre, precio)
            {
                this.marca = marca;
            }

            public override void Mostrar()
            {
                base.Mostrar();
                Console.WriteLine("Marca: " + marca);
            }

            public void AplicarDescuento(double porcentaje)
            {
                precio -= precio * (porcentaje / 100);
            }
        }

        public class Libro : Producto
        {
            protected string autor;
            protected int paginas;

            public string Autor { get { return autor; } set { autor = value; } }
            public int Paginas { get { return paginas; } set { paginas = value; } }

            public Libro(string nombre, double precio, string autor, int paginas) : base(nombre, precio)
            {
                this.autor = autor;
                this.paginas = paginas;
            }

            public override void Mostrar()
            {
                base.Mostrar();
                Console.WriteLine("Autor: " + autor);
                Console.WriteLine("Páginas: " + paginas);
            }

            public double CalcularPrecioPorPagina()
            {
                return precio / paginas;
            }
        }
    }
}
