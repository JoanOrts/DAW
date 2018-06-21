
using System;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial interface IAlbumCAD
{
AlbumEN ReadOIDDefault (int id
                        );

void ModifyDefault (AlbumEN album);



int New_ (AlbumEN album);

void Modify (AlbumEN album);


void Destroy (int id
              );


AlbumEN ReadOID (int id
                 );


System.Collections.Generic.IList<AlbumEN> ReadAll (int first, int size);


void AnyadirLibroAlbum (int p_Album_OID, System.Collections.Generic.IList<int> p_libro_OIDs);

void QuitarLibroAlbum (int p_Album_OID, System.Collections.Generic.IList<int> p_libro_OIDs);

System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AlbumEN> LeerNombre (string p_nombre);
}
}
