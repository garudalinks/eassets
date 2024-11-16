using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TbmRo108
{
    public string Ro108id { get; set; }

    public string Objek108Id { get; set; }

    public string Rokode { get; set; }

    public string Ronama { get; set; }

    public string Keterangan { get; set; }

    public string ThAng { get; set; }

    public string Op { get; set; }

    public DateTime? Lu { get; set; }

    public string Pc { get; set; }

    public bool? Dlt { get; set; }

    public short? MasaManfaat { get; set; }

    public byte? IsEnabled { get; set; }
}
