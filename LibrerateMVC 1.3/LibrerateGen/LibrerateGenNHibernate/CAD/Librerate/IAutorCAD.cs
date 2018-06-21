
using System;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial interface IAutorCAD
{
AutorEN ReadOIDDefault (int id
                        );

void ModifyDefault (AutorEN autor);



int New_ (AutorEN autor);

void Modify (AutorEN autor);


void Destroy (int id
              );


AutorEN ReadOID (int id
                 );


System.Collections.Generic.IList<AutorEN> ReadAll (int first, int size);


System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AutorEN> LeerNombre (string p_nombre);
}
}
