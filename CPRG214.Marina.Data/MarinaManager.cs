using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        //var slips2 = (from s in db.Slips
        //              where !(from l in db.Leases
        //                      select l.SlipID)
        //                      .Contains(s.ID)
        //              select s);

        //// SELECT * FROM Slip WHERE slip.ID NOT IN (SELECT SlipID FROM Lease)
        //var slips = (from s in slips2
        //             where s.DockID == dockID
        //             select new SlipDTO
        //             {
        //               ID = s.ID,
        //               Length = s.Length.ToString(),
        //               Width = s.Width.ToString(),
        //               Summary = $"ID: {s.ID} | Dimensions {s.Length}x{s.Width}"
        //             }).ToList();
        var availableSlips = db.Slips.Where(s => s.Leases.Count == 0 && s.DockID == dockID).ToList();

        List<SlipDTO> dto = (from s in availableSlips
                   select new SlipDTO
                   {
                     ID = s.ID,
                     Length = s.Length.ToString(),
                     Width = s.Width.ToString(),
                     Summary = $"ID: {s.ID} - Dimensions {s.Length}x{s.Width}"
                   }).ToList();

        return dto;
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
