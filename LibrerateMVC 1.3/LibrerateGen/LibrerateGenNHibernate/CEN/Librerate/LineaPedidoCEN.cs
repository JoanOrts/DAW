

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
 *      Definition of the class LineaPedidoCEN
 *
 */
public partial class LineaPedidoCEN
{
private ILineaPedidoCAD _ILineaPedidoCAD;

public LineaPedidoCEN()
{
        this._ILineaPedidoCAD = new LineaPedidoCAD ();
}

public LineaPedidoCEN(ILineaPedidoCAD _ILineaPedidoCAD)
{
        this._ILineaPedidoCAD = _ILineaPedidoCAD;
}

public ILineaPedidoCAD get_ILineaPedidoCAD ()
{
        return this._ILineaPedidoCAD;
}

public int New_ (int p_cantidad, int p_usuario, int p_carrito, int p_libro)
{
        LineaPedidoEN lineaPedidoEN = null;
        int oid;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Cantidad = p_cantidad;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                lineaPedidoEN.Usuario = new LibrerateGenNHibernate.EN.Librerate.UsuarioEN ();
                lineaPedidoEN.Usuario.Id = p_usuario;
        }


        if (p_carrito != -1) {
                // El argumento p_carrito -> Property carrito es oid = false
                // Lista de oids id
                lineaPedidoEN.Carrito = new LibrerateGenNHibernate.EN.Librerate.CarritoEN ();
                lineaPedidoEN.Carrito.Id = p_carrito;
        }


        if (p_libro != -1) {
                // El argumento p_libro -> Property libro es oid = false
                // Lista de oids id
                lineaPedidoEN.Libro = new LibrerateGenNHibernate.EN.Librerate.LibroEN ();
                lineaPedidoEN.Libro.Id = p_libro;
        }

        //Call to LineaPedidoCAD

        oid = _ILineaPedidoCAD.New_ (lineaPedidoEN);
        return oid;
}

public void Modify (int p_LineaPedido_OID, int p_cantidad)
{
        LineaPedidoEN lineaPedidoEN = null;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Id = p_LineaPedido_OID;
        lineaPedidoEN.Cantidad = p_cantidad;
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.Modify (lineaPedidoEN);
}

public void Destroy (int id
                     )
{
        _ILineaPedidoCAD.Destroy (id);
}

public LineaPedidoEN ReadOID (int id
                              )
{
        LineaPedidoEN lineaPedidoEN = null;

        lineaPedidoEN = _ILineaPedidoCAD.ReadOID (id);
        return lineaPedidoEN;
}

public System.Collections.Generic.IList<LineaPedidoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LineaPedidoEN> list = null;

        list = _ILineaPedidoCAD.ReadAll (first, size);
        return list;
}
}
}
