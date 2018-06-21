
using System;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial interface IPuntuacionCAD
{
PuntuacionEN ReadOIDDefault (int id
                             );

void ModifyDefault (PuntuacionEN puntuacion);



int New_ (PuntuacionEN puntuacion);

void Modify (PuntuacionEN puntuacion);


void Destroy (int id
              );


PuntuacionEN ReadOID (int id
                      );


System.Collections.Generic.IList<PuntuacionEN> ReadAll (int first, int size);
}
}
