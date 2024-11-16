using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TblKibAtribusi
{
    public string KibAtribusiId { get; set; }

    public string OpAdd { get; set; }

    public string PcAdd { get; set; }

    public DateTime? DateAdd { get; set; }

    public string OpEdit { get; set; }

    public string PcEdit { get; set; }

    public DateTime? DateEdit { get; set; }

    public byte? Dlt { get; set; }

    public string KibAId { get; set; }

    public string KibAwalId { get; set; }

    /// <summary>
    /// {a,b,c,d,e,f}
    /// </summary>
    public string JenisAtribusi { get; set; }

    public DateTime? Tanggal { get; set; }

    public string JenisBiaya { get; set; }

    public double? NilaiBiaya { get; set; }

    public int? Nourut { get; set; }
}
