using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPRG.Marina.App.Controls
{
  public class DockEventArgs : EventArgs
  {
    public int ID { get; set; }
    public bool eService { get; set; }
    public bool wService { get; set; }
  }
}