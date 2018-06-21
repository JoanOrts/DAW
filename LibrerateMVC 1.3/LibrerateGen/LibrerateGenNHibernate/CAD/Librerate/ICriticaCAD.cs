
using System;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial interface ICriticaCAD
{
CriticaEN ReadOIDDefault (int id
                          );

void ModifyDefault (CriticaEN critica);



int New_ (CriticaEN critica);

void Modify (CriticaEN critica);


void Destroy (int id
              );


CriticaEN ReadOID (int id
                   );


System.Collections.Generic.IList<CriticaEN> ReadAll (int first, int size);


System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CriticaEN> LeerTitulo (string p_titulo);
}
}
