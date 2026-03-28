namespace EjerciciosNet.Ejercicio05_GestionInv;
using EjerciciosNet.Ejercicio05_GestionInv;

public class Producto
{
    public string Nombre {get; set;} 
    public int Stock {get;set;}

    public Producto (string nombre, int stock)
    {
        Nombre = nombre;
        Stock = stock;
    }
}