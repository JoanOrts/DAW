
using System;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial interface ILineaPedidoCAD
{
LineaPedidoEN ReadOIDDefault (int id
                              );

void ModifyDefault (LineaPedidoEN lineaPedido);



int New_ (LineaPedidoEN lineaPedido);

void Modify (LineaPedidoEN lineaPedido);


void Destroy (int id
              );


LineaPedidoEN ReadOID (int id
                       );


System.Collections.Generic.IList<LineaPedidoEN> ReadAll (int first, int size);
}
}
