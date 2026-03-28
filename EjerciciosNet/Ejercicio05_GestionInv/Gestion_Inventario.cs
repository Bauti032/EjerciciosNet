namespace EjerciciosNet.Ejercicio05_GestionInv;
using EjerciciosNet.Ejercicio05_GestionInv;

public class Gestion_Inventario
{
    public List<Producto> productos = new List<Producto>();
    public List<Proovedor> proovedores = new List<Proovedor>();

    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);
    }
    public void AgregarProovedor (Proovedor proovedor)
    {
        proovedores.Add(proovedor);
    }

    public void AgregarStock(Producto producto, int cantidad)
    {
        try{
            producto.Stock += cantidad;
        } catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió una excepción: {ex}");
        }
    }
    public void RetirarStock (Producto producto, int cantidad)
    {
        try
        {
            producto.Stock -= cantidad;
        } catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex}");
        }
    }
    public int ConsultarStock(Producto producto)
    {
        return producto.Stock();
    }
}