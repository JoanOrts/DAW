using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateWeb.Models
{
    public class AssemblerCritica
    {
        public Critica ConvertENToModelUI(CriticaEN en)
        {
            Critica crt = new Critica();
            crt.id = en.Id;
            crt.Titulo = en.Titulo;
            crt.Texto = en.Texto;

            return crt;


        }
        public IList<Critica> ConvertListENToModel(IList<CriticaEN> ens)
        {
            IList<Critica> crts = new List<Critica>();
            foreach (CriticaEN en in ens)
            {
                crts.Add(ConvertENToModelUI(en));
            }
            return crts;
        }
        
    }
}