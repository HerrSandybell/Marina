using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
  public class SlipDTO
  {
    public int ID { get; set; }
    public string Width { get; set; }
    public string Length { get; set; }
    public string Summary { get; set; } //ID: width times length
  }
}
