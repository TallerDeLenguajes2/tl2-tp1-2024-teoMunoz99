using System.Data.Common;
using EspacioCadetes;
using EspacioPedidos;

namespace EspacioCadeteria
{
    public class Cadeteria
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
        public List<Cadete> GetListaCadetes()
        {
            return ListadoCadetes;
        }
        public List<Pedido> GetListaPedios()
        {
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
        public bool RegistrarCadete(string _nombre, string _telefono)
        {
            int cant = ListadoCadetes.Count;
            int id = 0; //generar id
            Cadete cadeteNuevo = new Cadete(_nombre,_telefono, id);
            ListadoCadetes.Add(cadeteNuevo);
            return ListadoCadetes.Count > cant;
        }
        public bool EliminarCadete(int _idCadete)
        {
            int cant = ListadoCadetes.Count;
            Cadete cadeteBuscado = null;
            foreach (var item in ListadoCadetes)
            {
                if(item.GetId() == _idCadete){
                    cadeteBuscado = item;
                    break;
                }
            }
            ListadoCadetes.Remove(cadeteBuscado);
            return ListadoCadetes.Count < cant;
        }
        public float CalcularJornal(int _idCadete)
        {
            int i = 0;
            foreach (var item in ListadoPedidos)
            {
                if(item.GetCadeteAsignado().GetId() == _idCadete){
                    i++;
                }
            }
            return i * 500;
        }
        public void AsignarPedido(int _idCadete, int _idPedido){
            //busco el cadete
            Cadete cadeteBuscado = null;
            foreach (var cadete in ListadoCadetes)
            {
                if(cadete.GetId() == _idCadete){
                    cadeteBuscado = cadete;
                }
            }
            //busco el pedido y le agrego el cadete
            foreach (var pedidoBuscado in ListadoPedidos)
            {
                if(_idPedido == pedidoBuscado.GetId()){
                    pedidoBuscado.SetCadeteAsignado(cadeteBuscado);
                }
            }
        }
        //-------------
    }
}