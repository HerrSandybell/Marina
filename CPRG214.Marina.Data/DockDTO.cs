using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
  public class DockDTO
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool WaterService { get; set; }
    public bool ElectricalService { get; set; }
    //public string DockSummary { get; set; }
  }
}
