
using System;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (int id
                                );

void ModifyDefault (AdministradorEN administrador);



int New_ (AdministradorEN administrador);

void Modify (AdministradorEN administrador);


void Destroy (int id
              );


AdministradorEN ReadOID (int id
                         );


System.Collections.Generic.IList<AdministradorEN> ReadAll (int first, int size);
}
}
