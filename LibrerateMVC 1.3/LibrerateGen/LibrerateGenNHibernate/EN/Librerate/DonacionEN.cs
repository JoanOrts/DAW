
using System;
// Definición clase DonacionEN
namespace LibrerateGenNHibernate.EN.Librerate
{
public partial class DonacionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo cantidad
 */
private float cantidad;



/**
 *	Atributo autor
 */
private LibrerateGenNHibernate.EN.Librerate.AutorEN autor;



/**
 *	Atributo usuario
 */
private LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual float Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.AutorEN Autor {
        get { return autor; } set { autor = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public DonacionEN()
{
}



public DonacionEN(int id, float cantidad, LibrerateGenNHibernate.EN.Librerate.AutorEN autor, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario
                  )
{
        this.init (Id, cantidad, autor, usuario);
}


public DonacionEN(DonacionEN donacion)
{
        this.init (Id, donacion.Cantidad, donacion.Autor, donacion.Usuario);
}

private void init (int id
                   , float cantidad, LibrerateGenNHibernate.EN.Librerate.AutorEN autor, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario)
{
        this.Id = id;


        this.Cantidad = cantidad;

        this.Autor = autor;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DonacionEN t = obj as DonacionEN;
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
