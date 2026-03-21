namespace EjerciciosNet;

public class Pedido
{
    public List<Producto> Productos {get; set;}
    public double Total {get; set;}

    public Pedido()
    {
        Productos = new List<Producto>();
        Total = 0;
    }

}
