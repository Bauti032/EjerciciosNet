using System;
using EjerciciosNet;
// using EjerciciosNet.Ejercicio01_Pedidos;
// using EjerciciosNet.Ejercicio02_AdminCurso;
// using EjerciciosNet.Ejercicio03_CuentaBancaria;
// using EjerciciosNet.Ejercicio04_ReservaHotel;
using EjerciciosNet.Ejercicio05_GestionInv;
using ProdInv = EjerciciosNet.Ejercicio05_GestionInv.Producto;
// Ejercicio01_Pedidos();
// Ejercicio02_AdminCurso();
// Ejercicio03_CuentaBancaria();
// Ejercicio04_ReservaHotel();
Ejercicio05_GestionInv();
// static void Ejercicio01_Pedidos() 
//     {    
//         Pedido pedido = new Pedido();

//         Console.Write("¿Cuántos productos querés ingresar?: ");
//         int cantidad = int.Parse(Console.ReadLine());

    
//         for (int i = 0; i < cantidad; i++)
//         {
//             Console.WriteLine($"\nProducto {i + 1}");

//             Console.Write("Nombre: ");
//             string nombre = Console.ReadLine();

//             Console.Write("Precio: ");
//             double precio = double.Parse(Console.ReadLine());

//             Producto producto = new Producto(nombre, precio);

//             GestionPedido.AgregarProducto(pedido, producto);
//         }

       
//         double total = GestionPedido.CalcularTotal(pedido);
//         Console.WriteLine($"\nTotal del pedido: {total}");

       
//         Console.WriteLine("\nProductos en el pedido:");
//         foreach (var p in pedido.Productos)
//         {
//             Console.WriteLine($"- {p.Nombre} (${p.Precio})");
//         }

        
//         Console.Write("\n¿Qué producto querés quitar?: ");
//         string nombreAQuitar = Console.ReadLine();

//         Producto productoAQuitar = null;

//         // Buscar producto
//         foreach (var p in pedido.Productos)
//         {
//             if (p.Nombre.ToLower() == nombreAQuitar.ToLower())
//             {
//                 productoAQuitar = p;
//                 break;
//             }
//         }

//         if (productoAQuitar != null)
//         {
//             GestionPedido.QuitarProducto(pedido, productoAQuitar);
//             Console.WriteLine("Producto eliminado correctamente.");
//         }
//         else
//         {
//             Console.WriteLine("Producto no encontrado.");
//         }

        
//         double nuevoTotal = GestionPedido.CalcularTotal(pedido);
//         Console.WriteLine($"\nNuevo total: {nuevoTotal}");
//     }


//     static void Ejercicio02_AdminCurso()
// {
    
//    Console.WriteLine("Nombre del curso: ");
//    string nombre_Curso = Console.ReadLine();
   
//    Console.WriteLine("Ingrese la cantidad del cupo: ");
//    int cant_cupo = Convert.ToInt32(Console.ReadLine());

//    Curso curso = new Curso();
//    curso.NombreCurso = nombre_Curso;
//    curso.Cupo = cant_cupo;

//    Gestion_Curso gestion = new Gestion_Curso();

//    Console.WriteLine("Cuantos estudiantes queres cargar: ");
//    int cant = Convert.ToInt32(Console.ReadLine());

//    for (int i = 0; i < cant; i++)
//     {
//         Console.WriteLine($"Estudiante N° {i + 1}");

//         Console.WriteLine("Nombre");
//         string nombre = Console.ReadLine();
//         Console.WriteLine("Legajo: ");
//         string legajo = Console.ReadLine();

//         Estudiante estudiante = new Estudiante();
//         estudiante.Nombre = nombre;
//         estudiante.Legajo = legajo;
//         bool resultado = gestion.InscribirEstudiante(curso, estudiante);
//         Console.WriteLine(resultado ? "Inscripto Correctamente": "No hay cupo");
//     }

//     // Consulta de cupo
//     bool hay_cupo = gestion.ConsultaCupo(curso);
//     Console.WriteLine(hay_cupo ? "Quedan lugares": "Lleno");

//     //dar de baja
//     Console.WriteLine("Ingrese el legajo del estudiante a eliminar: ");
//     string legajo_eliminar = Console.ReadLine();

//     Estudiante encontrado = null;
//     foreach (var e in curso.Inscriptos)
//     {
//         if (e.Legajo == legajo_eliminar)
//         {
//             encontrado = e;
//             break;
//         }
//     }
//     if (encontrado != null)
//     {
//         bool eliminado = gestion.DarBajaCurso(curso, encontrado);
//         Console.WriteLine(eliminado ? "Eliminado Correctamente": "No se pudo eliminar");
//     }
//     else
//     {
//         Console.WriteLine("Legajo no encontrado");
//     }
//     Console.WriteLine($"Inscriptos Actuales: {curso.Inscriptos.Count}");
    
// }


// static void Ejercicio03_CuentaBancaria()
// {
//     Console.WriteLine("Ingrese el Nombre del cliente: ");
//     string nombrecliente = Console.ReadLine();
//     Console.WriteLine("Ingrese DNI");
//     string dniccliente = Console.ReadLine();

//     Cliente cliente = new Cliente();
//     cliente.Nombre = nombrecliente;
//     cliente.DNI = dniccliente;

//     Console.WriteLine("Ingrese el Nro de cuenta del cliente: ");
//     string numerocuenta = Console.ReadLine();
//     Console.WriteLine("Ingrese el saldo inicial: ");
//     double saldoinicial = Convert.ToDouble(Console.ReadLine());

//     Cuenta cuenta = new Cuenta();
//     cuenta.Numero = numerocuenta;
//     cuenta.Saldo = saldoinicial;


//     // Console.WriteLine("-----------------------");
//     // Console.WriteLine("1. Depositar");
//     // Console.WriteLine("2. Retirar");
//     // Console.WriteLine("3. Consultar Saldo");
//     // Console.WriteLine("0. Salir");
//     // Console.WriteLine("Ingrese la operacion a realizar: ");
//     // int opcion = Convert.ToInt32(Console.ReadLine());
//     int opcion_2 = 2;
//     Gestion_Banco gestion = new Gestion_Banco();
//     while (opcion_2 != 0) {
        
//     Console.WriteLine("-----------------------");
//     Console.WriteLine("1. Depositar");
//     Console.WriteLine("2. Retirar");
//     Console.WriteLine("3. Consultar Saldo");
//     Console.WriteLine("0. Salir");
//     Console.WriteLine("Ingrese la operacion a realizar: ");
//     int opcion = Convert.ToInt32(Console.ReadLine());
//         switch(opcion)
//         {
//             case 1:
//                 Console.WriteLine("Ingrese la cantidad de saldo a depositar: ");
//                 double cant = Convert.ToDouble(Console.ReadLine());
//                 gestion.Depositar(cuenta, cant);
//                 break;
//             case 2:
//                 Console.WriteLine("Ingrese la cantidad de saldo a retirar: ");
//                 double cant_retiro = Convert.ToDouble(Console.ReadLine());
//                 gestion.Retirar(cuenta, cant_retiro);
//                 break;
//             case 3:
//                 gestion.ConsultaSaldo(cuenta);
//                 break;
//             case 0:
//                 opcion_2 = 0;
//                 break;

//         }
//     }
// }

// static void Ejercicio04_ReservaHotel()
{
    Console.WriteLine("Ingrese el nombre del huesped: ");
    string nuevo_huesped = Console.ReadLine();
    Console.WriteLine("Ingrese el DNI del huesped: ");
    string nuevo_dni = Console.ReadLine();

    Huesped hues_ped = new Huesped();
    hues_ped.Nombre = nuevo_huesped;
    hues_ped.DNI = nuevo_dni;

    Console.WriteLine("Ingrese el numero de habitación: ");
    int nuevahab = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese si está disponible o no (1. Si - 2. No):" );
    int disponible = Convert.ToInt32(Console.ReadLine());

    Habitacion hab_itacion = new Habitacion();
    hab_itacion.Numero = nuevahab;
    if (disponible == 1)
    {
        hab_itacion.Disponible = true;
    } else
    {
        hab_itacion.Disponible = false;
    }


        Gestion_Hotel gestion_Hotel = new Gestion_Hotel();
        int opcion_2 = 2;
     while (opcion_2 != 0) {
        
        Console.WriteLine("-----------------------");
        Console.WriteLine("1. Reservar");
        Console.WriteLine("2. Cancelar Reserva");
        Console.WriteLine("3. Consultar Reserva");
        Console.WriteLine("0. Salir");
        Console.WriteLine("Ingrese la operacion a realizar: ");
        int opcion = Convert.ToInt32(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    gestion_Hotel.ReservaHab(hab_itacion, hues_ped);
                    break;
                case 2:
                    gestion_Hotel.CancelarReserva(hab_itacion,hues_ped);
                    break;
                case 3:
                    gestion_Hotel.ConsultaReserva(hab_itacion);
                    break;
                case 0:
                    opcion_2 = 0;
                    break;

            }
        }
}



static void Ejercicio05_GestionInv()
{
    string menu = "a";

    while (menu != null)
    {
        Console.WriteLine("Bienvenido al Sistema de gestión.");
        Console.WriteLine("Operaciones a realizar ");
        Console.WriteLine("1. Ingresar Proovedor ");
        Console.WriteLine("2. Ingresar Productos ");
        Console.WriteLine("3. Agregar Stock de productos ");
        Console.WriteLine("4. Retirar Stock de producto");
        Console.WriteLine("5. Consultar Stock de producto");
        Console.WriteLine("6. Salir del sistema");

        int op;
        Console.WriteLine("Ingrese la Opción: ");
        op = Convert.ToInt32(Console.ReadLine());


        Gestion_Inventario gestinv = new Gestion_Inventario();

        switch (op)
        {
            case 1:
                Console.WriteLine("Ingrese nombre del proovedor: ");
                string nombre_prov = Console.ReadLine();

                Console.WriteLine("Ingrese el cuit del proovedor: ");
                string cuit_proov = Console.ReadLine();

                Proovedor proovedor = new Proovedor(nombre_prov, cuit_proov);
                gestinv.AgregarProovedor(proovedor);
                break;

            case 2:
                Console.WriteLine("Ingrese nombre del producto: ");
                string nombre_prod = Console.ReadLine();

                Console.WriteLine("Ingrese el stock del producto: ");
                int stock = Convert.ToInt32(Console.ReadLine());

                ProdInv prod = new ProdInv(nombre_prod, stock);
                gestinv.AgregarProducto(prod);
                break;

            case 3:
                Console.WriteLine("Ingrese la cantidad del producto a ingresar: ");
                int cant = Convert.ToInt32(Console.ReadLine());
                gestinv.AgregarStock(prod, cant);
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;

        }
    }
}