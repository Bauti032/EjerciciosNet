namespace EjerciciosNet.Ejercicio05_GestionInv;
using EjerciciosNet.Ejercicio05_GestionInv;

public class Proovedor
{
    public string Nombre {get; set;} 
    public string Cuit {get; set;}

    public Proovedor (string nombre, string cuit)
    {
        Nombre = nombre;
        Cuit = cuit;
    }
}