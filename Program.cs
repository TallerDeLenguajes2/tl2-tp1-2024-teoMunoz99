using EspacioCadeteria;
using EspacioCadetes;
using EspacioCsv;
using EspacioPedidos;

List<Cadete> listaCad = CSV.CargarCadetes("cadetes.csv");
List<Pedido> listPed = CSV.CargarPedidos("pedidos.csv");
Console.Clear();
Cadeteria cadeteria1 = new Cadeteria("Cadeteria La Papa", listaCad, listPed);

bool salir = false;
while (!salir)
{
    Console.WriteLine("//----PEDIDOS YA----// \n");
    Console.WriteLine("0. Listar pedidos pendientes y realizados");
    Console.WriteLine("1. Dar de alta pedidos");
    Console.WriteLine("2. Asignar pedido a cadete");
    Console.WriteLine("3. Cambiar estado del pedido");
    Console.WriteLine("4. Reasignar pedido a otro cadete");
    Console.WriteLine("5. Mostrar informe");
    Console.WriteLine("6. Salir\n");
    Console.WriteLine("Elija una opcion: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "0":
            // Listar pedidos
            Console.Clear();
            Console.WriteLine("0. Lista de pedidos pendientes y realizados\n");
            foreach (var pedido in cadeteria1.GetListaPedios())
            {
                Console.WriteLine("Cliente: "+pedido.GetCliente()+", "+pedido.GetDireccion()+", "+pedido.GetEstado());
            }
            Console.ReadKey();
            break;
        case "1":
            // Implementar DarDeAltaPedido
            Console.Clear();
            Console.WriteLine("1. Dar de alta pedidos\n");
            Console.ReadKey();
            break;
        case "2":
            // Implementar AsignarPedidoACadete
            Console.Clear();
            Console.WriteLine("2. Asignar pedido a cadete\n");
            Console.ReadKey();
            break;
        case "3":
            // Implementar CambiarEstadoPedido
            Console.Clear();
            Console.WriteLine("3. Cambiar estado del pedido\n");
            Console.ReadKey();
            break;
        case "4":
            // Implementar ReasignarPedido
            Console.Clear();
            Console.WriteLine("4. Reasignar pedido a otro cadete\n");
            Console.ReadKey();
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("5. Mostrar informe\n");
            //cadeteria.GenerarInforme();
            Console.ReadKey();
            break;
        case "6":
            salir = true;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opción no válida");
            Console.ReadKey();
            break;
    }
}