namespace EspacioClientes
{
    class Cliente
    {
        //Atributos----
        private string Nombre;
        private string Direccion;
        private string Telefono;
        private string DatosReferenciaDireccion;
        //-------------
        //Propiedades--
        public string GetNombre(){
            return Nombre;
        }
        public void SetNombre(string _value){
            Nombre = _value;
        }
        public string GetDireccion(){
            return Direccion;
        }
        public void SetDireccion(string _value){
            Direccion = _value;
        }
        public string GetTelefono(){
            return Telefono;
        }
        public void SetTelefono(string _value){
            Telefono = _value;
        }
        public string GetDatosDirRef(){
            return DatosReferenciaDireccion;
        }
        public void SetDatosDirRef(string _value){
            DatosReferenciaDireccion = _value;
        }
        //-------------
        //Constructor--
        public Cliente(string _nombre, string _direccion, string _telefono, string _datosDireccionReferencia){
            SetNombre(_nombre);
            SetDireccion(_direccion);
            SetTelefono(_telefono);
            SetDatosDirRef(_datosDireccionReferencia);
        }
        //-------------
        //Metodos------
        //-------------
    }
}