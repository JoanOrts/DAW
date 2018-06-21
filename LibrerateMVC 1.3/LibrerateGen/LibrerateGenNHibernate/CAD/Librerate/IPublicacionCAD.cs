
using System;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial interface IPublicacionCAD
{
PublicacionEN ReadOIDDefault (int id
                              );

void ModifyDefault (PublicacionEN publicacion);



int New_ (PublicacionEN publicacion);

void Modify (PublicacionEN publicacion);


void Destroy (int id
              );


PublicacionEN ReadOID (int id
                       );


System.Collections.Generic.IList<PublicacionEN> ReadAll (int first, int size);


System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PublicacionEN> LeerNombre (string p_nombre);
}
}
