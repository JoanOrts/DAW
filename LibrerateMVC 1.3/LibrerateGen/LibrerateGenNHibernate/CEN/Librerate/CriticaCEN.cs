

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using LibrerateGenNHibernate.Exceptions;

using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CAD.Librerate;


namespace LibrerateGenNHibernate.CEN.Librerate
{
/*
 *      Definition of the class CriticaCEN
 *
 */
public partial class CriticaCEN
{
private ICriticaCAD _ICriticaCAD;

public CriticaCEN()
{
        this._ICriticaCAD = new CriticaCAD ();
}

public CriticaCEN(ICriticaCAD _ICriticaCAD)
{
        this._ICriticaCAD = _ICriticaCAD;
}

public ICriticaCAD get_ICriticaCAD ()
{
        return this._ICriticaCAD;
}

public int New_ (string p_titulo, string p_Texto, int p_puntuacion_0, int p_libro, int p_usuario)
{
        CriticaEN criticaEN = null;
        int oid;

        //Initialized CriticaEN
        criticaEN = new CriticaEN ();
        criticaEN.Titulo = p_titulo;

        criticaEN.Texto = p_Texto;


        if (p_puntuacion_0 != -1) {
                // El argumento p_puntuacion_0 -> Property puntuacion_0 es oid = false
                // Lista de oids id
                criticaEN.Puntuacion_0 = new LibrerateGenNHibernate.EN.Librerate.PuntuacionEN ();
                criticaEN.Puntuacion_0.Id = p_puntuacion_0;
        }


        if (p_libro != -1) {
                // El argumento p_libro -> Property libro es oid = false
                // Lista de oids id
                criticaEN.Libro = new LibrerateGenNHibernate.EN.Librerate.LibroEN ();
                criticaEN.Libro.Id = p_libro;
        }


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                criticaEN.Usuario = new LibrerateGenNHibernate.EN.Librerate.UsuarioEN ();
                criticaEN.Usuario.Id = p_usuario;
        }

        //Call to CriticaCAD

        oid = _ICriticaCAD.New_ (criticaEN);
        return oid;
}

public void Modify (int p_Critica_OID, string p_titulo, string p_Texto)
{
        CriticaEN criticaEN = null;

        //Initialized CriticaEN
        criticaEN = new CriticaEN ();
        criticaEN.Id = p_Critica_OID;
        criticaEN.Titulo = p_titulo;
        criticaEN.Texto = p_Texto;
        //Call to CriticaCAD

        _ICriticaCAD.Modify (criticaEN);
}

public void Destroy (int id
                     )
{
        _ICriticaCAD.Destroy (id);
}

public CriticaEN ReadOID (int id
                          )
{
        CriticaEN criticaEN = null;

        criticaEN = _ICriticaCAD.ReadOID (id);
        return criticaEN;
}

public System.Collections.Generic.IList<CriticaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CriticaEN> list = null;

        list = _ICriticaCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CriticaEN> LeerTitulo (string p_titulo)
{
        return _ICriticaCAD.LeerTitulo (p_titulo);
}
}
}
