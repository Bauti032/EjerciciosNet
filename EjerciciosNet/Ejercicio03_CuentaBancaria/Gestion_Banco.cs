namespace  EjerciciosNet.Ejercicio03_CuentaBancaria;
using EjerciciosNet.Ejercicio03_CuentaBancaria;

public class Gestion_Banco
{
    public void Depositar(Cuenta cuenta, double cant)
    {
        cuenta.Saldo = cuenta.Saldo + cant;
        Console.WriteLine("Saldo agregado correctamente");
    }

    public void Retirar(Cuenta cuenta, double cant)
    {
        if (cuenta.Saldo > 0 && cuenta.Saldo > cant) 
        {
            cuenta.Saldo = cuenta.Saldo - cant;
            Console.WriteLine("Saldo restado correctamente: " + cant);
        } else
        {
            Console.WriteLine("Saldo insuficiente o Igual a 0.");
        }
    }
    public void ConsultaSaldo (Cuenta cuenta)
    {
        string cantidad_saldo = cuenta.Saldo.ToString();
        Console.WriteLine($"El saldo actual es de ${cantidad_saldo}");
    }
}