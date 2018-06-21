using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CP.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;


namespace LibrerateWeb.Models
{
    public class DonacionAssembler
    {

        public Donacion ConvertENToModelUI(DonacionEN en)
        {
            if (en != null)
            {

                Donacion don = new Donacion();

                don.id = en.Id;
                don.cantidad = en.Cantidad;

                return don;
            }

            else
            {
                return null;
            }

        }

        public IList<Donacion> ConvertListENToModel(IList<DonacionEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {

                IList<Donacion> don = new List<Donacion>();
                foreach (DonacionEN en in ens)
                {
                    don.Add(ConvertENToModelUI(en));
                }
                return don;
            }
            else
            {
                return null;
            }
        }
    }
}