using EASSET.Helpers;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Serenity.ComponentModel;
using StackExchange.Exceptional.Internal;
using System;
using System.Data;
using System.Windows.Markup;

namespace EASSET.MasterData.Forms;

[FormScript("MasterData.UPB")]
[BasedOnRow(typeof(UPBRow), CheckNames = true)]

public class UPBForm
{
  
    //[DefaultValue(), ReadOnly(true)]
    //public string ThAng { get; set; }
    public string UnitId { get; set; }
    public string SubUnitId { get; set; }
    public string UpbKode { get; set; }
    public string UpbNama { get; set; }

    //public string Op { get; set; }
    //public DateTime Lu { get; set; }
    //public string Pc { get; set; }
    //public short Dlt { get; set; }
}