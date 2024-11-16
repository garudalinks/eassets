using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TblLoggpsTrack
{
    public int LoggpsTrackid { get; set; }

    public string Nohp { get; set; }

    public string Lat { get; set; }

    public string Lon { get; set; }

    public double? SpeedKmH { get; set; }

    public DateTime? Tanggal { get; set; }
}
