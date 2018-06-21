
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using LibrerateGenNHibernate.Exceptions;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CAD.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;


namespace LibrerateGenNHibernate.CP.Librerate
{
public partial class AlbumCP : BasicCP
{
public AlbumCP() : base ()
{
}

public AlbumCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
