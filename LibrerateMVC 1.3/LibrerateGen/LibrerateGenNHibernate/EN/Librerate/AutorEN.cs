
using System;
// Definición clase AutorEN
namespace LibrerateGenNHibernate.EN.Librerate
{
public partial class AutorEN
{
/**
 *	Atributo ganancias
 */
private float ganancias;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo donacion
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.DonacionEN> donacion;



/**
 *	Atributo usuario
 */
private LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario;



/**
 *	Atributo usuario_0
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.UsuarioEN> usuario_0;



/**
 *	Atributo nombre
 */
private string nombre;






public virtual float Ganancias {
        get { return ganancias; } set { ganancias = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.DonacionEN> Donacion {
        get { return donacion; } set { donacion = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.UsuarioEN> Usuario_0 {
        get { return usuario_0; } set { usuario_0 = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}





public AutorEN()
{
        donacion = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.DonacionEN>();
        usuario_0 = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.UsuarioEN>();
}



public AutorEN(int id, float ganancias, string email, Nullable<DateTime> fecha, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.DonacionEN> donacion, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.UsuarioEN> usuario_0, string nombre
               )
{
        this.init (Id, ganancias, email, fecha, donacion, usuario, usuario_0, nombre);
}


public AutorEN(AutorEN autor)
{
        this.init (Id, autor.Ganancias, autor.Email, autor.Fecha, autor.Donacion, autor.Usuario, autor.Usuario_0, autor.Nombre);
}

private void init (int id
                   , float ganancias, string email, Nullable<DateTime> fecha, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.DonacionEN> donacion, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.UsuarioEN> usuario_0, string nombre)
{
        this.Id = id;


        this.Ganancias = ganancias;

        this.Email = email;

        this.Fecha = fecha;

        this.Donacion = donacion;

        this.Usuario = usuario;

        this.Usuario_0 = usuario_0;

        this.Nombre = nombre;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AutorEN t = obj as AutorEN;
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
