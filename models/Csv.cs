using EspacioCadetes;
using EspacioPedidos;

namespace EspacioCsv
{
    static class CSV
    {
        public static List<Cadete> CargarCadetes(string archivoCSV)
        {
            var listaDeCadetes = new List<Cadete>();

            foreach (var linea in File.ReadLines(archivoCSV))
            {
                var valores = linea.Split(',');
                if (valores[0] == "Id") continue;
                var cadete = new Cadete(valores[1], valores[2], int.Parse(valores[0]));
                listaDeCadetes.Add(cadete);
            }

            return listaDeCadetes;
        }

        public static List<Pedido> CargarPedidos(string archivoCSV)
        {
            var listaDePedidos = new List<Pedido>();
            foreach (var linea in File.ReadLines(archivoCSV))
            {
                var valores = linea.Split(',');
                if (valores[0] == "Id") continue;
                var pedido = new Pedido(int.Parse(valores[0]),valores[1],valores[2],valores[3],valores[4]);
                listaDePedidos.Add(pedido);
            }
            return listaDePedidos;
        }
    }
}