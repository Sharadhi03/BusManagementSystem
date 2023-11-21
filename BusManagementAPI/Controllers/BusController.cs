using BusManagementAPI.Models;
using BusSystem.Data.BusRepository;
using BusSystem.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        public BusRepository BusRepository { get; set; }

        public BusController()
        {
            this.BusRepository = new BusRepository();
        }
        [HttpGet]
        public List<TblBu> GetAllBuses()
        {
            return this.BusRepository.GetAllBuses();
        }
        [HttpPost]
        public void AddBus(Bus bus)
        {
            TblBu tblbus = new TblBu();
            tblbus.BusId = 1;
            tblbus.BusDestinationCity = bus.BusDestinationCity;
            tblbus.BusSourceCity = bus.BusSourceCity;
            tblbus.BusCapacity = bus.BusCapacity;
            tblbus.BusType = bus.BusType;
            tblbus.BusDepartureTime = bus.BusDepartureTime;
            tblbus.BusArrivalTime = bus.BusArrivalTime;
            this.BusRepository.AddBus(tblbus);
        }
        [HttpDelete]
        public void DeleteBus(int busId)
        {
            this.BusRepository.DeleteBus(busId);
        }
        [HttpGet("{BusDestinationCity}")]
        public TblBu GetBus(string BusDestinationCity)
        {
            return BusRepository.GetBus(BusDestinationCity);
        }
    }
}
