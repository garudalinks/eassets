using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TbmSubUnit
{
    public string SubUnitId { get; set; }

    public string UnitId { get; set; }

    public string SubUnitKode { get; set; }

    public string SubUnitNama { get; set; }

    public string ThAng { get; set; }

    public string Op { get; set; }

    public DateTime? Lu { get; set; }

    public string Pc { get; set; }

    public bool? Dlt { get; set; }

    public string Alamat { get; set; }

    public string Npwp { get; set; }
}
