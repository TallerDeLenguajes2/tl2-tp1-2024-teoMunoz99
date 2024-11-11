using EspacioClientes;
using EspacioCadetes;

namespace EspacioPedidos
{
    class Pedido
    {
        //Atributos----
        private int Id;
        private string Cliente;
        private string Direccion;
        private string Estado;
        private string Observaciones;
        private Cadete CadeteAsignado;
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
        public string GetCliente()
        {
            return Cliente;
        }
        public void SetCliente(string _value)
        {
            Cliente = _value;
        }
        public string GetDireccion()
        {
            return Cliente;
        }
        public void SetDireccion(string _value)
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
        public Cadete GetCadeteAsignado(){
            return CadeteAsignado;
        }
        public void SetCadeteAsignado(Cadete _value){
            CadeteAsignado = _value;
        }
        //-------------
        //Constructor--
        public Pedido(int _id, string _cliente, string _direccion, string _estado = "Pendiente", string _observaciones = "", Cadete _cadeteAsignado = null)
        {
            SetId(_id);
            SetCliente(_cliente);
            SetDireccion(_direccion);
            SetEstado(_estado);
            SetObservaciones(_observaciones);
            SetCadeteAsignado(_cadeteAsignado);
        }
        //-------------
        //Metodos------
        public string VerDireccionCliente()
        {
            return GetDireccion();
        }
        public void VerDatosCliente()
        {

        }
        //-------------
    }
}