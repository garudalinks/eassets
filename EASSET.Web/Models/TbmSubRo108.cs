using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TbmSubRo108
{
    public string SubRo108id { get; set; }

    public string Ro108id { get; set; }

    public string SubRokode { get; set; }

    public string SubRonama { get; set; }

    public string Keterangan { get; set; }

    public string ThAng { get; set; }

    public string Op { get; set; }

    public DateTime? Lu { get; set; }

    public string Pc { get; set; }

    public bool? Dlt { get; set; }

    public byte? MasaManfaat { get; set; }

    public byte? IsEnabled { get; set; }
}
