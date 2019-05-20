using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DorukOtomasyon_MesutSertacGun.Model
{
    public class StopOfProcess : TableBase
    {
        public string Reason { get; set; }
    }
}