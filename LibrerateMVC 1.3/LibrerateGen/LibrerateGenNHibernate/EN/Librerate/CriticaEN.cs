
using System;
// Definición clase CriticaEN
namespace LibrerateGenNHibernate.EN.Librerate
{
public partial class CriticaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo texto
 */
private string texto;



/**
 *	Atributo puntuacion_0
 */
private LibrerateGenNHibernate.EN.Librerate.PuntuacionEN puntuacion_0;



/**
 *	Atributo libro
 */
private LibrerateGenNHibernate.EN.Librerate.LibroEN libro;



/**
 *	Atributo usuario
 */
private LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.PuntuacionEN Puntuacion_0 {
        get { return puntuacion_0; } set { puntuacion_0 = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.LibroEN Libro {
        get { return libro; } set { libro = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public CriticaEN()
{
}



public CriticaEN(int id, string titulo, string texto, LibrerateGenNHibernate.EN.Librerate.PuntuacionEN puntuacion_0, LibrerateGenNHibernate.EN.Librerate.LibroEN libro, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario
                 )
{
        this.init (Id, titulo, texto, puntuacion_0, libro, usuario);
}


public CriticaEN(CriticaEN critica)
{
        this.init (Id, critica.Titulo, critica.Texto, critica.Puntuacion_0, critica.Libro, critica.Usuario);
}

private void init (int id
                   , string titulo, string texto, LibrerateGenNHibernate.EN.Librerate.PuntuacionEN puntuacion_0, LibrerateGenNHibernate.EN.Librerate.LibroEN libro, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario)
{
        this.Id = id;


        this.Titulo = titulo;

        this.Texto = texto;

        this.Puntuacion_0 = puntuacion_0;

        this.Libro = libro;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CriticaEN t = obj as CriticaEN;
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
