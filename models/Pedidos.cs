using EspacioClientes;

namespace EspacioPedidos
{
    class Pedido
    {
        //Atributos----
        private int Id;
        private Cliente Cliente;
        private string Estado;
        private string Observaciones;
        //-------------
        //Propiedades--

        public int GetId()
        {
            return Id;
        }
        public void SetId(int _value)
        {
            Id = _value;
        }
        public Cliente GetCliente()
        {
            return Cliente;
        }
        public void SetCliente(Cliente _value)
        {
            Cliente = _value;
        }
        public string GetEstado()
        {
            return Estado;
        }
        public void SetEstado(string _value)
        {
            Estado = _value;
        }
        public string GetObservaciones()
        {
            return Observaciones;
        }
        public void SetObservaciones(string _value)
        {
            Observaciones = _value;
        }
        //-------------
        //Constructor--
        public Pedido(int _id, Cliente _cliente, string _direccion, string _observaciones)
        {
            SetId(_id);
            SetCliente(_cliente);
            SetDireccion(_direccion);
            SetEstado("Pendiente"); // estado inicial
            SetObservaciones(_observaciones);
        }
        //-------------
        //Metodos------
        public void VerDireccionCliente(){
            
        }
        public void VerDatosCliente(){
            
        }
        //-------------
    }
}