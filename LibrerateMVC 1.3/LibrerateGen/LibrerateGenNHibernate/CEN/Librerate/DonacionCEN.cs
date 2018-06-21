

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
 *      Definition of the class DonacionCEN
 *
 */
public partial class DonacionCEN
{
private IDonacionCAD _IDonacionCAD;

public DonacionCEN()
{
        this._IDonacionCAD = new DonacionCAD ();
}

public DonacionCEN(IDonacionCAD _IDonacionCAD)
{
        this._IDonacionCAD = _IDonacionCAD;
}

public IDonacionCAD get_IDonacionCAD ()
{
        return this._IDonacionCAD;
}

public int New_ (float p_cantidad, int p_autor, int p_usuario)
{
        DonacionEN donacionEN = null;
        int oid;

        //Initialized DonacionEN
        donacionEN = new DonacionEN ();
        donacionEN.Cantidad = p_cantidad;


        if (p_autor != -1) {
                // El argumento p_autor -> Property autor es oid = false
                // Lista de oids id
                donacionEN.Autor = new LibrerateGenNHibernate.EN.Librerate.AutorEN ();
                donacionEN.Autor.Id = p_autor;
        }


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                donacionEN.Usuario = new LibrerateGenNHibernate.EN.Librerate.UsuarioEN ();
                donacionEN.Usuario.Id = p_usuario;
        }

        //Call to DonacionCAD

        oid = _IDonacionCAD.New_ (donacionEN);
        return oid;
}

public void Modify (int p_Donacion_OID, float p_cantidad)
{
        DonacionEN donacionEN = null;

        //Initialized DonacionEN
        donacionEN = new DonacionEN ();
        donacionEN.Id = p_Donacion_OID;
        donacionEN.Cantidad = p_cantidad;
        //Call to DonacionCAD

        _IDonacionCAD.Modify (donacionEN);
}

public void Destroy (int id
                     )
{
        _IDonacionCAD.Destroy (id);
}

public DonacionEN ReadOID (int id
                           )
{
        DonacionEN donacionEN = null;

        donacionEN = _IDonacionCAD.ReadOID (id);
        return donacionEN;
}

public System.Collections.Generic.IList<DonacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DonacionEN> list = null;

        list = _IDonacionCAD.ReadAll (first, size);
        return list;
}
}
}
