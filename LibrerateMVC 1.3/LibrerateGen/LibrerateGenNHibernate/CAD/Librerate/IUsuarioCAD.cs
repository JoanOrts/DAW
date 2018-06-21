
using System;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (int id
                          );

void ModifyDefault (UsuarioEN usuario);



int New_ (UsuarioEN usuario);

void Modify (UsuarioEN usuario);


void Destroy (int id
              );


UsuarioEN ReadOID (int id
                   );


System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size);




System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.UsuarioEN> LeerNombre (string p_nombre);



void SeguirAutor (int p_Usuario_OID, int p_autor_OID);

void DeseguirAutor (int p_Usuario_OID, int p_autor_OID);


void AnyadirLibro (int p_Usuario_OID, System.Collections.Generic.IList<int> p_libro_OIDs);

void QuitarLibro (int p_Usuario_OID, System.Collections.Generic.IList<int> p_libro_OIDs);

LibrerateGenNHibernate.EN.Librerate.UsuarioEN LeerEmail (string p_email);
}
}
