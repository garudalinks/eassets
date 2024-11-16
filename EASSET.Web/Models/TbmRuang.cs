using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TbmRuang
{
    public string RuangId { get; set; }

    public string UnitId { get; set; }

    public string SubUnitId { get; set; }

    public string RuangKode { get; set; }

    public string RuangNama { get; set; }

    public string ThAng { get; set; }

    public string Op { get; set; }

    public DateTime Lu { get; set; }

    public string Pc { get; set; }

    public byte Dlt { get; set; }
}
