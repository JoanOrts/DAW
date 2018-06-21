
using System;
// Definición clase CarritoEN
namespace LibrerateGenNHibernate.EN.Librerate
{
public partial class CarritoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo numerador
 */
private int numerador;



/**
 *	Atributo precio
 */
private float precio;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN> lineaPedido;



/**
 *	Atributo usuario
 */
private LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario;



/**
 *	Atributo estado
 */
private bool estado;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Numerador {
        get { return numerador; } set { numerador = value;  }
}



public virtual float Precio {
        get { return precio; } set { precio = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual bool Estado {
        get { return estado; } set { estado = value;  }
}





public CarritoEN()
{
        lineaPedido = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN>();
}



public CarritoEN(int id, int numerador, float precio, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN> lineaPedido, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario, bool estado
                 )
{
        this.init (Id, numerador, precio, lineaPedido, usuario, estado);
}


public CarritoEN(CarritoEN carrito)
{
        this.init (Id, carrito.Numerador, carrito.Precio, carrito.LineaPedido, carrito.Usuario, carrito.Estado);
}

private void init (int id
                   , int numerador, float precio, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN> lineaPedido, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario, bool estado)
{
        this.Id = id;


        this.Numerador = numerador;

        this.Precio = precio;

        this.LineaPedido = lineaPedido;

        this.Usuario = usuario;

        this.Estado = estado;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CarritoEN t = obj as CarritoEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
