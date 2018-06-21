
using System;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial interface ILibroCAD
{
LibroEN ReadOIDDefault (int id
                        );

void ModifyDefault (LibroEN libro);



int New_ (LibroEN libro);

void Modify (LibroEN libro);


void Destroy (int id
              );


LibroEN ReadOID (int id
                 );


System.Collections.Generic.IList<LibroEN> ReadAll (int first, int size);



System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> LeerGenero (string p_genero);


System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> LeerUsuario (string p_usuario);


System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> LeerPrecio (string p_precio);


System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> LeerNombre (string p_nombre);


void AsignarAlbum (int p_Libro_OID, System.Collections.Generic.IList<int> p_album_OIDs);

void QuitardeAlbum (int p_Libro_OID, System.Collections.Generic.IList<int> p_album_OIDs);
}
}
