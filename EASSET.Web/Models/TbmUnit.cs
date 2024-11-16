using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TbmUnit
{
    public string UnitId { get; set; }

    public string UnitKode { get; set; }

    public string UnitNama { get; set; }

    public string ThAng { get; set; }

    public string Alamat { get; set; }

    public string Op { get; set; }

    public DateTime Lu { get; set; }

    public string Pc { get; set; }

    public bool Dlt { get; set; }

    public string Npwp { get; set; }

    public byte? IsBlud { get; set; }

    public int? NoUrut { get; set; }
}
