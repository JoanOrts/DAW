

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
 *      Definition of the class PuntuacionCEN
 *
 */
public partial class PuntuacionCEN
{
private IPuntuacionCAD _IPuntuacionCAD;

public PuntuacionCEN()
{
        this._IPuntuacionCAD = new PuntuacionCAD ();
}

public PuntuacionCEN(IPuntuacionCAD _IPuntuacionCAD)
{
        this._IPuntuacionCAD = _IPuntuacionCAD;
}

public IPuntuacionCAD get_IPuntuacionCAD ()
{
        return this._IPuntuacionCAD;
}

public int New_ (int p_nota, int p_libro, int p_usuario)
{
        PuntuacionEN puntuacionEN = null;
        int oid;

        //Initialized PuntuacionEN
        puntuacionEN = new PuntuacionEN ();
        puntuacionEN.Nota = p_nota;


        if (p_libro != -1) {
                // El argumento p_libro -> Property libro es oid = false
                // Lista de oids id
                puntuacionEN.Libro = new LibrerateGenNHibernate.EN.Librerate.LibroEN ();
                puntuacionEN.Libro.Id = p_libro;
        }


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                puntuacionEN.Usuario = new LibrerateGenNHibernate.EN.Librerate.UsuarioEN ();
                puntuacionEN.Usuario.Id = p_usuario;
        }

        //Call to PuntuacionCAD

        oid = _IPuntuacionCAD.New_ (puntuacionEN);
        return oid;
}

public void Modify (int p_Puntuacion_OID, int p_nota)
{
        PuntuacionEN puntuacionEN = null;

        //Initialized PuntuacionEN
        puntuacionEN = new PuntuacionEN ();
        puntuacionEN.Id = p_Puntuacion_OID;
        puntuacionEN.Nota = p_nota;
        //Call to PuntuacionCAD

        _IPuntuacionCAD.Modify (puntuacionEN);
}

public void Destroy (int id
                     )
{
        _IPuntuacionCAD.Destroy (id);
}

public PuntuacionEN ReadOID (int id
                             )
{
        PuntuacionEN puntuacionEN = null;

        puntuacionEN = _IPuntuacionCAD.ReadOID (id);
        return puntuacionEN;
}

public System.Collections.Generic.IList<PuntuacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PuntuacionEN> list = null;

        list = _IPuntuacionCAD.ReadAll (first, size);
        return list;
}
}
}
