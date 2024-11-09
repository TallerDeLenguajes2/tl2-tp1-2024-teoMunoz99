using EspacioCadetes;
using EspacioPedidos;

namespace EspacioCadeteria
{
    class Cadeteria
    {
        //Atributos----
        private string Nombre;
        private string Telefono;
        private List<Cadete> ListadoCadetes { get; set; }
        //-------------
        //Propiedades--
        private string GetNombre()
        {
            return Nombre;
        }
        private void SetNombre(string _value)
        {
            Nombre = _value;
        }
        private string GetTelefono()
        {
            return Telefono;
        }
        private void SetTelefono(string _value)
        {
            Telefono = _value;
        }
        //-------------
        //Constructor--
        public Cadeteria(string _nombre)
        {
            SetNombre(_nombre);
            ListadoCadetes = new List<Cadete>();
        }
        //-------------
        //Metodos------
        public bool AsignarPedidoACadete(int _idCadete, Pedido _pedido)
        {
            //busco al cadete
            Cadete cadeteBuscado = ListadoCadetes.FirstOrDefault(c => c.GetId() == _idCadete);
            if (cadeteBuscado == null)
            {
                return false;
            }
            else
            {
                //agrego el pedido
                cadeteBuscado.AsignarPedido(_pedido);
                return true;
            }
        }
        //-GenerarInformeActividades() crear clase informe
        public bool RegistrarCadete(Cadete _cadeteNuevo)
        {
            int cant = ListadoCadetes.Count;
            ListadoCadetes.Add(_cadeteNuevo);
            return ListadoCadetes.Count > cant;
        }
        public bool EliminarCadete(Cadete _cadeteQuitar)
        {
            int cant = ListadoCadetes.Count;
            ListadoCadetes.Remove(_cadeteQuitar);
            return ListadoCadetes.Count < cant;
        }
        //-------------
    }
}