using EspacioCadetes;
using EspacioPedidos;

namespace EspacioCadeteria
{
    class Cadeteria
    {
        //Atributos----
        private string Nombre;
        private string Telefono;
        private List<Cadete> ListadoCadetes;
        private List<Pedido> ListadoPedidos;
        //-------------
        //Propiedades--
        public string GetNombre()
        {
            return Nombre;
        }
        private void SetNombre(string _value)
        {
            Nombre = _value;
        }
        public string GetTelefono()
        {
            return Telefono;
        }
        private void SetTelefono(string _value)
        {
            Telefono = _value;
        }
        public List<Cadete> GetListaCadetes(){
            return ListadoCadetes;
        }
        public List<Pedido> GetListaPedios(){
            return ListadoPedidos;
        }
        //-------------
        //Constructor--
        public Cadeteria(string _nombre, List<Cadete> _listaCadetes = null, List<Pedido> _listaPedidos = null)
        {
            SetNombre(_nombre);
            ListadoCadetes = _listaCadetes ?? new List<Cadete>();
            ListadoPedidos = _listaPedidos ?? new List<Pedido>();
        }
        //-------------
        //Metodos------
        /*public bool AsignarPedido(int _idCadete, Pedido _pedido)
        {
            //busco al cadete
            Cadete cadeteBuscado = ListadoCadetes.FirstOrDefault(c => c.GetId() == _idCadete);
            if (cadeteBuscado == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }*/
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