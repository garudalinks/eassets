using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TbmJenis108
{
    public string Jenis108Id { get; set; }

    public string Kelompok108Id { get; set; }

    public string JenisKode { get; set; }

    public string JenisNama { get; set; }

    public string Keterangan { get; set; }

    public string ThAng { get; set; }

    public string Op { get; set; }

    public DateTime? Lu { get; set; }

    public string Pc { get; set; }

    public bool? Dlt { get; set; }

    public byte? IsEnabled { get; set; }
}
