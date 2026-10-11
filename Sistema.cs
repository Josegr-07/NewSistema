using System;

namespace Sistema_de_ventas

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de ventas");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Mostrar productos");
            Console.WriteLine("3. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    AgregarProducto();
                    break;
                case 2:
                    MostrarProductos();
                    break;
                case 3:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
        static void AgregarProducto()
        {
            Console.WriteLine("Ingrese el nombre del producto:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto:");
            decimal precio = Convert.ToDecimal(Console.ReadLine());
            // Aquí puedes agregar lógica para guardar el producto en una base de datos o lista
            Console.WriteLine($"Producto {nombre} con precio {precio} agregado exitosamente.");
        }
        static void MostrarProductos()
        {
            // Aquí puedes agregar lógica para mostrar los productos desde una base de datos o lista
            Console.WriteLine("Mostrando productos...");
        }
    }
}

git pull --rebase origin master
git push