using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TblRkbmd
{
    public string Rkbmdid { get; set; }

    public string UnitId { get; set; }

    public double? NoUrut { get; set; }

    public string Keterangan { get; set; }

    public string ThAng { get; set; }

    public string Op { get; set; }

    public DateTime? Lu { get; set; }

    public string Pc { get; set; }

    public byte? Dlt { get; set; }

    public string SubUnitId { get; set; }

    public string SubKegId { get; set; }

    public string KodeRekening { get; set; }

    public string NamaRekening { get; set; }

    public double? JmlUsulan { get; set; }

    public double? JmlKebMax { get; set; }

    public double? JmlExisting { get; set; }

    public string SubKegKode { get; set; }

    public string SubKegNama { get; set; }

    public string SubSubRo108id { get; set; }

    public string Satuan { get; set; }

    public string Rkpdid { get; set; }
}
