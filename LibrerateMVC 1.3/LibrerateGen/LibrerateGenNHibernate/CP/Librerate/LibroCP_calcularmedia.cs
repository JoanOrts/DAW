
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CAD.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;



/*PROTECTED REGION ID(usingLibrerateGenNHibernate.CP.Librerate_Libro_calcularmedia) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace LibrerateGenNHibernate.CP.Librerate
{
public partial class LibroCP : BasicCP
{
public void Calcularmedia (int p_oid)
{
        /*PROTECTED REGION ID(LibrerateGenNHibernate.CP.Librerate_Libro_calcularmedia) ENABLED START*/

        ILibroCAD libroCAD = null;
        LibroCEN libroCEN = null;



        try
        {
                SessionInitializeTransaction ();
                libroCAD = new LibroCAD (session);
                libroCEN = new LibroCEN (libroCAD);



                // Write here your custom transaction ...

                LibroEN en = libroCAD.ReadOIDDefault (p_oid);

                int cont = 0;
                int total = 0;

                if (en.Critica != null) {
                        for (int i = 0; i < en.Critica.Count; i++) {
                                total = total + en.Critica [i].Puntuacion_0.Nota;
                                cont++;
                        }
                }

                if (en.Puntuacion != null) {
                        for (int i = 0; i < en.Puntuacion.Count; i++) {
                                total = total + en.Puntuacion [i].Nota;
                                cont++;
                        }
                }

                if (cont != 0) {
                        en.Media = total / cont;
                }

                else{
                        en.Media = 0;
                }

                libroCAD.Modify (en);

                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
