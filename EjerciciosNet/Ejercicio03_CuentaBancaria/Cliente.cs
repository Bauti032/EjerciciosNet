namespace  EjerciciosNet.Ejercicio03_CuentaBancaria;
using EjerciciosNet.Ejercicio03_CuentaBancaria;

public class Cliente
{
    public string Nombre {get; set;}
    public string DNI {get; set;}
    public List<Cuenta> Cuentas {get; set;} = new List<Cuenta>();
}