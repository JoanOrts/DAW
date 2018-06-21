
using System;
// Definición clase LineaPedidoEN
namespace LibrerateGenNHibernate.EN.Librerate
{
public partial class LineaPedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo cantidad
 */
private int cantidad;



/**
 *	Atributo usuario
 */
private LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario;



/**
 *	Atributo carrito
 */
private LibrerateGenNHibernate.EN.Librerate.CarritoEN carrito;



/**
 *	Atributo libro
 */
private LibrerateGenNHibernate.EN.Librerate.LibroEN libro;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.CarritoEN Carrito {
        get { return carrito; } set { carrito = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.LibroEN Libro {
        get { return libro; } set { libro = value;  }
}





public LineaPedidoEN()
{
}



public LineaPedidoEN(int id, int cantidad, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario, LibrerateGenNHibernate.EN.Librerate.CarritoEN carrito, LibrerateGenNHibernate.EN.Librerate.LibroEN libro
                     )
{
        this.init (Id, cantidad, usuario, carrito, libro);
}


public LineaPedidoEN(LineaPedidoEN lineaPedido)
{
        this.init (Id, lineaPedido.Cantidad, lineaPedido.Usuario, lineaPedido.Carrito, lineaPedido.Libro);
}

private void init (int id
                   , int cantidad, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario, LibrerateGenNHibernate.EN.Librerate.CarritoEN carrito, LibrerateGenNHibernate.EN.Librerate.LibroEN libro)
{
        this.Id = id;


        this.Cantidad = cantidad;

        this.Usuario = usuario;

        this.Carrito = carrito;

        this.Libro = libro;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoEN t = obj as LineaPedidoEN;
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
