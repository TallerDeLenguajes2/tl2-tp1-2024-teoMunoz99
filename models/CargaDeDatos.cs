using EspacioCadetes;
using EspacioPedidos;
using System.Text.Json;

namespace EspacioDatos
{
    public abstract class AccesoADatos
    {
        public abstract List<Cadete> CargarCadetes(string _rutaArchivo);
        public abstract List<Pedido> CargarPedidos(string _rutaArchivo);
    }

    public class AccesoCSV : AccesoADatos
    {
        public override List<Cadete> CargarCadetes(string archivoCSV)
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
        public override List<Pedido> CargarPedidos(string archivoCSV)
        {
            var listaDePedidos = new List<Pedido>();
            foreach (var linea in File.ReadLines(archivoCSV))
            {
                var valores = linea.Split(',');
                if (valores[0] == "Id") continue;
                var pedido = new Pedido(int.Parse(valores[0]), valores[1], valores[2], valores[3], valores[4]);
                listaDePedidos.Add(pedido);
            }
            return listaDePedidos;
        }
    }

    public class AccesoJSON : AccesoADatos
    {
        public override List<Cadete> CargarCadetes(string archivoJSON)
        {
            string jsonContent = File.ReadAllText(archivoJSON);
            return JsonSerializer.Deserialize<List<Cadete>>(jsonContent);
        }

        public override List<Pedido> CargarPedidos(string archivoJSON)
        {
            string jsonContent = File.ReadAllText(archivoJSON);
            return JsonSerializer.Deserialize<List<Pedido>>(jsonContent);
        }
    }

    /*static class AccesoADatos
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
    }*/
}