using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class VwSubKegiatan
{
    public long? Id { get; set; }

    public string BidangView { get; set; }

    public string UrusanView { get; set; }

    public string ProgView { get; set; }

    public string KegView { get; set; }

    public string SubKegView { get; set; }

    public string SubKeg50Id { get; set; }

    public string SubKeg50Kode { get; set; }
}
