
using System;
// Definición clase LibroEN
namespace LibrerateGenNHibernate.EN.Librerate
{
public partial class LibroEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo precio
 */
private float precio;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo portada
 */
private string portada;



/**
 *	Atributo genero
 */
private LibrerateGenNHibernate.Enumerated.Librerate.GeneroEnum genero;



/**
 *	Atributo numpag
 */
private int numpag;



/**
 *	Atributo idioma
 */
private string idioma;



/**
 *	Atributo media
 */
private int media;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN> lineaPedido;



/**
 *	Atributo critica
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CriticaEN> critica;



/**
 *	Atributo puntuacion
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PuntuacionEN> puntuacion;



/**
 *	Atributo album
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AlbumEN> album;



/**
 *	Atributo publicacion
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PublicacionEN> publicacion;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.UsuarioEN> usuario;



/**
 *	Atributo cantidadvendida
 */
private int cantidadvendida;



/**
 *	Atributo usuario_0
 */
private LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario_0;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual float Precio {
        get { return precio; } set { precio = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string Portada {
        get { return portada; } set { portada = value;  }
}



public virtual LibrerateGenNHibernate.Enumerated.Librerate.GeneroEnum Genero {
        get { return genero; } set { genero = value;  }
}



public virtual int Numpag {
        get { return numpag; } set { numpag = value;  }
}



public virtual string Idioma {
        get { return idioma; } set { idioma = value;  }
}



public virtual int Media {
        get { return media; } set { media = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CriticaEN> Critica {
        get { return critica; } set { critica = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PuntuacionEN> Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AlbumEN> Album {
        get { return album; } set { album = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PublicacionEN> Publicacion {
        get { return publicacion; } set { publicacion = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual int Cantidadvendida {
        get { return cantidadvendida; } set { cantidadvendida = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.UsuarioEN Usuario_0 {
        get { return usuario_0; } set { usuario_0 = value;  }
}





public LibroEN()
{
        lineaPedido = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN>();
        critica = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.CriticaEN>();
        puntuacion = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.PuntuacionEN>();
        album = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.AlbumEN>();
        publicacion = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.PublicacionEN>();
        usuario = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.UsuarioEN>();
}



public LibroEN(int id, string nombre, float precio, Nullable<DateTime> fecha, string descripcion, string portada, LibrerateGenNHibernate.Enumerated.Librerate.GeneroEnum genero, int numpag, string idioma, int media, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CriticaEN> critica, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PuntuacionEN> puntuacion, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AlbumEN> album, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PublicacionEN> publicacion, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.UsuarioEN> usuario, int cantidadvendida, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario_0
               )
{
        this.init (Id, nombre, precio, fecha, descripcion, portada, genero, numpag, idioma, media, lineaPedido, critica, puntuacion, album, publicacion, usuario, cantidadvendida, usuario_0);
}


public LibroEN(LibroEN libro)
{
        this.init (Id, libro.Nombre, libro.Precio, libro.Fecha, libro.Descripcion, libro.Portada, libro.Genero, libro.Numpag, libro.Idioma, libro.Media, libro.LineaPedido, libro.Critica, libro.Puntuacion, libro.Album, libro.Publicacion, libro.Usuario, libro.Cantidadvendida, libro.Usuario_0);
}

private void init (int id
                   , string nombre, float precio, Nullable<DateTime> fecha, string descripcion, string portada, LibrerateGenNHibernate.Enumerated.Librerate.GeneroEnum genero, int numpag, string idioma, int media, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CriticaEN> critica, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PuntuacionEN> puntuacion, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AlbumEN> album, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PublicacionEN> publicacion, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.UsuarioEN> usuario, int cantidadvendida, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario_0)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Precio = precio;

        this.Fecha = fecha;

        this.Descripcion = descripcion;

        this.Portada = portada;

        this.Genero = genero;

        this.Numpag = numpag;

        this.Idioma = idioma;

        this.Media = media;

        this.LineaPedido = lineaPedido;

        this.Critica = critica;

        this.Puntuacion = puntuacion;

        this.Album = album;

        this.Publicacion = publicacion;

        this.Usuario = usuario;

        this.Cantidadvendida = cantidadvendida;

        this.Usuario_0 = usuario_0;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LibroEN t = obj as LibroEN;
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
