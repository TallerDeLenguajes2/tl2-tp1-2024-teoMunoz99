namespace Clases
{
    //-------------------------------------------------------
    public class Cadete
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public Cadete(int id, string nombre, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
        }
    }
    //-------------------------------------------------------

    public class Cadeteria
    {
        public string Nombre { get; set; }
        public List<Cadete> ListadoCadetes { get; set; }
        public List<Pedido> ListadoPedidos { get; set; }

        public Cadeteria(string nombre)
        {
            Nombre = nombre;
            ListadoCadetes = new List<Cadete>();
            ListadoPedidos = new List<Pedido>();
        }

        public void ListarPedidos()
        {
            if (ListadoPedidos.Count <= 0)
            {
                Console.WriteLine("No hay pedidos");
            }
            else
            {
                foreach (var item in ListadoPedidos)
                {
                    Console.WriteLine(item.Cliente + " - " + item.Estado);
                }
            }
        }
        public void DarDeAltaPedido(Pedido pedido)
        {
            ListadoPedidos.Add(pedido);
        }

        public void AsignarCadeteAPedido(int idPedido, int idCadete)
        {
            var pedido = ListadoPedidos.FirstOrDefault(p => p.Id == idPedido);
            var cadete = ListadoCadetes.FirstOrDefault(c => c.Id == idCadete);
            if (pedido != null && cadete != null)
            {
                pedido.CadeteAsignado = cadete;
            }
            else
            {
                if (pedido == null)
                {
                    Console.WriteLine($"No se encontró el pedido con el Id: {idPedido}");
                }
                if (cadete == null)
                {
                    Console.WriteLine($"No se encontró el cadete con el Id: {idCadete}");
                }
            }
        }

        public void ReasignarPedido(Pedido pedido, Cadete nuevoCadete)
        {
            /*foreach (var cadete in ListadoCadetes)
            {
                if (cadete.ListadoPedidos.Contains(pedido))
                {
                    cadete.RemoverPedido(pedido);
                    nuevoCadete.AsignarPedido(pedido);
                    break;
                }
            }*/
        }

        public void GenerarInforme()
        {
            var totalPedidos = ListadoPedidos.Count;
            var totalGanancias = totalPedidos * 500; // 500 por pedido
            Console.Clear();
            Console.WriteLine($"Cadeteria: {Nombre}\n");
            Console.WriteLine($"Total de pedidos: {totalPedidos}");
            Console.WriteLine($"Total ganado: {totalGanancias}\n");
            Console.WriteLine("-Pedidos realizados:\n");
            foreach (var cadete in ListadoCadetes)
            {
                //Console.WriteLine($"{cadete.Nombre} realizó {cadete.ListadoPedidos.Count} pedidos");
            }
            Console.ReadKey();
        }

        public void CargarDatosDesdeCSV(string pathCadetes, string pathPedidos)
        {
            ListadoCadetes = CargarCadetesDesdeCSV(pathCadetes);
            ListadoPedidos = CargarPedidosDesdeCSV(pathPedidos);
        }

        private List<Cadete> CargarCadetesDesdeCSV(string pathCadetes)
        {
            var listaCadetes = new List<Cadete>();

            if (!File.Exists(pathCadetes))
            {
                return listaCadetes; // Retorna lista vacía si no existe el archivo
            }

            try
            {
                using (var reader = new StreamReader(pathCadetes))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue; // Ignora líneas vacías

                        var valores = linea.Split(',');
                        if (valores.Length == 3) // Verifica que tenga las columnas correctas
                        {
                            int id;
                            if (int.TryParse(valores[0], out id))
                            {
                                string nombre = valores[1];
                                string telefono = valores[2];
                                var cadete = new Cadete(id, nombre, telefono);
                                listaCadetes.Add(cadete);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo de cadetes: {ex.Message}");
            }

            return listaCadetes;
        }

        private List<Pedido> CargarPedidosDesdeCSV(string pathPedidos)
        {
            var listaPedidos = new List<Pedido>();

            if (!File.Exists(pathPedidos))
            {
                return listaPedidos; // Retorna lista vacía si no existe el archivo
            }

            try
            {
                using (var reader = new StreamReader(pathPedidos))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue; // Ignora líneas vacías

                        var valores = linea.Split(',');
                        if (valores.Length == 5) // Verifica que tenga las columnas correctas
                        {
                            int id;
                            if (int.TryParse(valores[0], out id))
                            {
                                string cliente = valores[1];
                                string direccion = valores[2];
                                string estado = valores[3];
                                string observaciones = valores[4];
                                var pedido = new Pedido(id, cliente, direccion, observaciones)
                                {
                                    Estado = estado // Establece el estado del pedido
                                };
                                listaPedidos.Add(pedido);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo de pedidos: {ex.Message}");
            }

            return listaPedidos;
        }

        private float JornalACobrar(int idCadete)
        {
            int totalEnvios = ListadoPedidos.Count(x => x.CadeteAsignado != null && x.CadeteAsignado.Id == idCadete);
            return totalEnvios * 500;
        }
    }


    //-------------------------------------------------------
    public class Pedido
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public Cadete CadeteAsignado { get; set; } // Referencia al cadete

        public Pedido(int id, string cliente, string direccion, string observaciones)
        {
            Id = id;
            Cliente = cliente;
            Direccion = direccion;
            Estado = "Pendiente"; // essstado inicial
            Observaciones = observaciones;
        }

        public void CambiarEstado(string nuevoEstado)
        {
            Estado = nuevoEstado;
        }
    }

    //-------------------------------------------------------
}