
using System;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial interface ICarritoCAD
{
CarritoEN ReadOIDDefault (int id
                          );

void ModifyDefault (CarritoEN carrito);



int New_ (CarritoEN carrito);

void Modify (CarritoEN carrito);


void Destroy (int id
              );


CarritoEN ReadOID (int id
                   );


System.Collections.Generic.IList<CarritoEN> ReadAll (int first, int size);



void AdjuntarlineaPedido (int p_Carrito_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs);

void QuitarlineaPedido (int p_Carrito_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs);
}
}
