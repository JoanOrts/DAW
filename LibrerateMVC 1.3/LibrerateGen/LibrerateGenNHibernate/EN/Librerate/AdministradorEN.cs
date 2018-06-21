
using System;
// Definición clase AdministradorEN
namespace LibrerateGenNHibernate.EN.Librerate
{
public partial class AdministradorEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo usuario
 */
private LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario;



/**
 *	Atributo contrasena
 */
private String contrasena;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual String Contrasena {
        get { return contrasena; } set { contrasena = value;  }
}





public AdministradorEN()
{
}



public AdministradorEN(int id, string nombre, string email, Nullable<DateTime> fecha, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario, String contrasena
                       )
{
        this.init (Id, nombre, email, fecha, usuario, contrasena);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (Id, administrador.Nombre, administrador.Email, administrador.Fecha, administrador.Usuario, administrador.Contrasena);
}

private void init (int id
                   , string nombre, string email, Nullable<DateTime> fecha, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario, String contrasena)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Email = email;

        this.Fecha = fecha;

        this.Usuario = usuario;

        this.Contrasena = contrasena;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdministradorEN t = obj as AdministradorEN;
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
