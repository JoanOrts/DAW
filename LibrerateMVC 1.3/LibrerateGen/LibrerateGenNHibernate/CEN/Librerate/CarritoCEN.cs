

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
 *      Definition of the class CarritoCEN
 *
 */
public partial class CarritoCEN
{
private ICarritoCAD _ICarritoCAD;

public CarritoCEN()
{
        this._ICarritoCAD = new CarritoCAD ();
}

public CarritoCEN(ICarritoCAD _ICarritoCAD)
{
        this._ICarritoCAD = _ICarritoCAD;
}

public ICarritoCAD get_ICarritoCAD ()
{
        return this._ICarritoCAD;
}

public int New_ (int p_numerador, float p_precio, int p_usuario, bool p_estado)
{
        CarritoEN carritoEN = null;
        int oid;

        //Initialized CarritoEN
        carritoEN = new CarritoEN ();
        carritoEN.Numerador = p_numerador;

        carritoEN.Precio = p_precio;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                carritoEN.Usuario = new LibrerateGenNHibernate.EN.Librerate.UsuarioEN ();
                carritoEN.Usuario.Id = p_usuario;
        }

        carritoEN.Estado = p_estado;

        //Call to CarritoCAD

        oid = _ICarritoCAD.New_ (carritoEN);
        return oid;
}

public void Modify (int p_Carrito_OID, int p_numerador, float p_precio, bool p_estado)
{
        CarritoEN carritoEN = null;

        //Initialized CarritoEN
        carritoEN = new CarritoEN ();
        carritoEN.Id = p_Carrito_OID;
        carritoEN.Numerador = p_numerador;
        carritoEN.Precio = p_precio;
        carritoEN.Estado = p_estado;
        //Call to CarritoCAD

        _ICarritoCAD.Modify (carritoEN);
}

public void Destroy (int id
                     )
{
        _ICarritoCAD.Destroy (id);
}

public CarritoEN ReadOID (int id
                          )
{
        CarritoEN carritoEN = null;

        carritoEN = _ICarritoCAD.ReadOID (id);
        return carritoEN;
}

public System.Collections.Generic.IList<CarritoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CarritoEN> list = null;

        list = _ICarritoCAD.ReadAll (first, size);
        return list;
}
public void AdjuntarlineaPedido (int p_Carrito_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        //Call to CarritoCAD

        _ICarritoCAD.AdjuntarlineaPedido (p_Carrito_OID, p_lineaPedido_OIDs);
}
public void QuitarlineaPedido (int p_Carrito_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        //Call to CarritoCAD

        _ICarritoCAD.QuitarlineaPedido (p_Carrito_OID, p_lineaPedido_OIDs);
}
}
}
