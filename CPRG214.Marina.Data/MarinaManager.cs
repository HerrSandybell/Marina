using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
  public class MarinaManager
  {
    public List<SlipDTO> GetNonleasedSlipsByDock(int dockID)
    {
      using (var db = new MarinaEntities())
      {
        // SELECT * FROM Slip WHERE slip.ID NOT IN (SELECT SlipID FROM Lease)
        var slips = (from s in (from s in db.Slips
                                where !(from l in db.Leases
                                        select l.SlipID)
                                        .Contains(s.ID)
                                select s)
                     where s.DockID == dockID
                     select new SlipDTO
                     {
                       ID = s.ID,
                       Summary = $"ID: {s.ID} | Dimensions {s.Length}x{s.Width}"
                     }).ToList();

        return slips;
      }
    }

    public List<DockDTO> GetDocks()
    {
      //using (var db = new MarinaEntities())
      //{
      //  var docks = db.Docks.Select(d => new DockDTO
      //  {
      //    ID = d.ID,
      //    Name = d.Name,
      //    WaterService = d.WaterService,
      //    ElectricalService = d.ElectricalService
      //  }).ToList();
      //  return docks;
      //}
      using (var db = new MarinaEntities())
      {
        var docks = db.Docks.Select(d => new DockDTO
        {
          ID = d.ID,
          Name = d.Name,
          WaterService = d.WaterService,
          ElectricalService = d.ElectricalService
        }).ToList();
        return docks;
      }
    }

    public DockDTO GetSingleDock(int dockID)
    {
      using (var db = new MarinaEntities())
      {
        DockDTO dto = null;
        var dock = db.Docks.SingleOrDefault(d => d.ID == dockID);
        if (dock != null)
        {
          dto = new DockDTO
          {
            ID = dock.ID,
            Name = dock.Name,
            WaterService = dock.WaterService,
            ElectricalService = dock.ElectricalService
          };
        }
        return dto;
      }
    }
  }
}
