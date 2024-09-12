[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/88f8fMid)

¿Cuál de estas relaciones considera que se realiza por composición y cuál por agregación?
-La relación entre Cliente y Pedidos es una composición
-La relación entre Cadeteria y Cadete sería de agregación

¿Qué métodos considera que debería tener la clase Cadeteria y la clase Cadete?

Clase Cadeteria-----
-AsignarPedidoACadete(Cadete cadete, Pedido pedido)
-GenerarInformeActividades()
-RegistrarCadete(Cadete cadete)
-EliminarCadete(Cadete cadete)

Clase Cadete--------
-AgregarPedido(Pedido pedido)
-EliminarPedido(Pedido pedido)
-CalcularJornal()
-ListarPedidos()

Teniendo en cuenta los principios de abstracción y ocultamiento, qué atributos, propiedades y métodos deberían ser públicos y cuáles privados.

-Atributos públicos: Nombre, Telefono, Direccion en las clases Cliente y Cadete.
Métodos: VerDatosCliente() o JornalACobrar()

-Atributos privados: ListadoPedidos en Cadete, Estado y Obs en Pedido


¿Cómo diseñaría los constructores de cada una de las clases?

public Cadeteria(string nombre, string telefono) {
        Nombre = nombre;
        Telefono = telefono;
        ListadoCadetes = new List<Cadete>();
    }

public Cadete(int id, string nombre, string telefono) {
        Id = id;
        Nombre = nombre;
        Telefono = telefono;
        ListadoPedidos = new List<Pedido>();
    }

¿Se le ocurre otra forma que podría haberse realizado el diseño de clases?

Crear una interfaz Persona que tegnga atributos comunes a Cliente y Cadete, como Nombre y Telefono, para evitar repetir código.