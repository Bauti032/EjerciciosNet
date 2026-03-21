using System;
using EjerciciosNet;

class Program
{
    static void Main(string[] args)
    {
        Pedido pedido = new Pedido();

        Console.Write("¿Cuántos productos querés ingresar?: ");
        int cantidad = int.Parse(Console.ReadLine());

        // 👉 Cargar productos
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"\nProducto {i + 1}");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine());

            Producto producto = new Producto(nombre, precio);

            GestionPedido.AgregarProducto(pedido, producto);
        }

        // 👉 Mostrar total
        double total = GestionPedido.CalcularTotal(pedido);
        Console.WriteLine($"\nTotal del pedido: {total}");

        // 👉 Mostrar productos actuales
        Console.WriteLine("\nProductos en el pedido:");
        foreach (var p in pedido.Productos)
        {
            Console.WriteLine($"- {p.Nombre} (${p.Precio})");
        }

        // 👉 Pedir producto a quitar
        Console.Write("\n¿Qué producto querés quitar?: ");
        string nombreAQuitar = Console.ReadLine();

        Producto productoAQuitar = null;

        // Buscar producto
        foreach (var p in pedido.Productos)
        {
            if (p.Nombre.ToLower() == nombreAQuitar.ToLower())
            {
                productoAQuitar = p;
                break;
            }
        }

        if (productoAQuitar != null)
        {
            GestionPedido.QuitarProducto(pedido, productoAQuitar);
            Console.WriteLine("Producto eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }

        // 👉 Nuevo total
        double nuevoTotal = GestionPedido.CalcularTotal(pedido);
        Console.WriteLine($"\nNuevo total: {nuevoTotal}");
    }
}