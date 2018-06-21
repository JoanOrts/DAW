
using System;
// Definición clase PuntuacionEN
namespace LibrerateGenNHibernate.EN.Librerate
{
public partial class PuntuacionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nota
 */
private int nota;



/**
 *	Atributo critica
 */
private LibrerateGenNHibernate.EN.Librerate.CriticaEN critica;



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



public virtual int Nota {
        get { return nota; } set { nota = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.CriticaEN Critica {
        get { return critica; } set { critica = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.LibroEN Libro {
        get { return libro; } set { libro = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public PuntuacionEN()
{
}



public PuntuacionEN(int id, int nota, LibrerateGenNHibernate.EN.Librerate.CriticaEN critica, LibrerateGenNHibernate.EN.Librerate.LibroEN libro, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario
                    )
{
        this.init (Id, nota, critica, libro, usuario);
}


public PuntuacionEN(PuntuacionEN puntuacion)
{
        this.init (Id, puntuacion.Nota, puntuacion.Critica, puntuacion.Libro, puntuacion.Usuario);
}

private void init (int id
                   , int nota, LibrerateGenNHibernate.EN.Librerate.CriticaEN critica, LibrerateGenNHibernate.EN.Librerate.LibroEN libro, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario)
{
        this.Id = id;


        this.Nota = nota;

        this.Critica = critica;

        this.Libro = libro;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PuntuacionEN t = obj as PuntuacionEN;
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
