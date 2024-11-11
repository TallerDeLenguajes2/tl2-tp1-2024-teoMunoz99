using EspacioCadeteria;
using EspacioCadetes;
using EspacioDatos;
using EspacioPedidos;


Console.Clear();
Console.WriteLine("Seleccione el tipo de archivo para cargar los datos:");
Console.WriteLine("1. CSV");
Console.WriteLine("2. JSON");

AccesoADatos accesoDatos;
string tipoArchivo = Console.ReadLine();

string rutaCadetes, rutaPedidos;

if (tipoArchivo == "1")
{
    accesoDatos = new AccesoCSV();
    rutaCadetes = "cadetes.csv";
    rutaPedidos = "pedidos.csv";
}
else if (tipoArchivo == "2")
{
    accesoDatos = new AccesoJSON();
    rutaCadetes = "cadetes.json";
    rutaPedidos = "pedidos.json";
}
else
{
    Console.WriteLine("Opción inválida.");
    return;
}

// Usar la instancia seleccionada para cargar datos
var listaCadetes = accesoDatos.CargarCadetes(rutaCadetes);
var listaPedidos = accesoDatos.CargarPedidos(rutaPedidos);
Console.Clear();
Cadeteria cadeteria1 = new Cadeteria("Cadeteria La Papa", listaCadetes, listaPedidos);

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
                Console.WriteLine("Cliente: " + pedido.GetCliente() + ", " + pedido.GetDireccion() + ", " + pedido.GetEstado());
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