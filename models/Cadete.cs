using EspacioPedidos;
using System.Collections.Generic;
using System.IO;

namespace EspacioCadetes
{
    class Cadete
    {
        //Atributos-----------------------------------------
        private int Id;
        private string Nombre;
        private string Telefono;
        private List<Pedido> ListadoPedidos { get; set; }
        //--------------------------------------------------
        //Propiedades---------------------------------------
        public int GetId()
        {
            return Id;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public void SetNombre(string value)
        {
            Nombre = value;
        }
        private string GetTelefono()
        {
            return Telefono;
        }
        private void SetTelefono(string value)
        {
            Telefono = value;
        }
        //--------------------------------------------------
        //Constructor---------------------------------------
        public Cadete(string _nombre, string _telefono, int _id = 0)
        {
            Id = _id;
            SetNombre(_nombre);
            SetTelefono(_telefono);
            ListadoPedidos = new List<Pedido>();
        }
        //--------------------------------------------------
        //Metodos-------------------------------------------

        public void AsignarPedido(Pedido pedido)
        {
            ListadoPedidos.Add(pedido);
        }

        public void EliminarPedido(Pedido pedido)
        {
            ListadoPedidos.Remove(pedido);
        }
        public float CalcularJornal()
        {
            return ListadoPedidos.Count * 500;
        }
        public List<Pedido> ListarPedidos()
        {
            return ListadoPedidos;
        }
        
        //--------------------------------------------------
    }
}