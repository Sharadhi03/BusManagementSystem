using BusSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSystem.Data.BusRepository
{
    public class BusRepository
    {
        BmsContext BmsDbContext { get; set; }
        public BusRepository()
        {
            this.BmsDbContext = new BmsContext();
        }
        public List<TblBu> GetAllBuses()
        {
            return this.BmsDbContext.TblBus.ToList();
        }
        public void AddBus(TblBu bus)
        {
            this.BmsDbContext.TblBus.Add(bus);
            this.BmsDbContext.SaveChanges();
        }
        public void DeleteBus(int busId)
        {
            var busNeedsTobeDeleted = this.BmsDbContext.TblBus.Where(b => b.BusId == busId).FirstOrDefault();
            if (busNeedsTobeDeleted != null)
            {
                this.BmsDbContext.Remove(busNeedsTobeDeleted);
                this.BmsDbContext.SaveChanges();
            }
        }
        public TblBu GetBus(string BusDestinationCity)
        {
            var busBy = this.BmsDbContext.TblBus.Where(b => b.BusDestinationCity == BusDestinationCity).FirstOrDefault();
            return busBy;
        }
    }
}
