namespace EjerciciosNet.Ejercicio04_ReservaHotel;
using EjerciciosNet.Ejercicio04_ReservaHotel;
public class Gestion_Hotel
{
    public void ReservaHab (Habitacion habitacion, Huesped huesped)
    {
        if (habitacion.Disponible == true)
        {
            habitacion.huespedActual = huesped.Nombre;
            habitacion.Disponible = false;
        } else
        {
            Console.WriteLine("La habitación se encuentra reservada: ");
        }
    }
    public void CancelarReserva (Habitacion habitacion, Huesped huesped)
    {
        habitacion.huespedActual = "";
        habitacion.Disponible = true;
        Console.WriteLine("La habitación está libre.");
    }
    public bool ConsultaReserva (Habitacion habitacion)
    {
        if (habitacion.Disponible == true)
        {
            Console.WriteLine("Habitación libre mi rey.");
            return true;
        } else
        {
            string cliente_okupa = habitacion.huespedActual;
            Console.WriteLine($"Está ocupada por {cliente_okupa}");
            return false;
        }
    }
}