
using System;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial interface IDonacionCAD
{
DonacionEN ReadOIDDefault (int id
                           );

void ModifyDefault (DonacionEN donacion);



int New_ (DonacionEN donacion);

void Modify (DonacionEN donacion);


void Destroy (int id
              );


DonacionEN ReadOID (int id
                    );


System.Collections.Generic.IList<DonacionEN> ReadAll (int first, int size);
}
}
