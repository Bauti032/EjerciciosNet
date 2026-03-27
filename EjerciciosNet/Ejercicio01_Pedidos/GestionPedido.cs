
namespace EjerciciosNet.Ejercicio01_Pedidos;
public class GestionPedido
{
    public static void AgregarProducto(Pedido pedido, Producto producto)
    {
        pedido.Productos.Add(producto);
        pedido.Total += producto.Precio;
    }
    public static void QuitarProducto(Pedido pedido, Producto producto)
    {
        if(pedido.Productos.Remove(producto))
        {
            pedido.Total -= producto.Precio;
        }
    }
    public static double CalcularTotal(Pedido pedido)
    {
        double total = 0;
        foreach (var producto in pedido.Productos)
        {
            total += producto.Precio;
        }
        pedido.Total = total;
        return total;
    }
}
