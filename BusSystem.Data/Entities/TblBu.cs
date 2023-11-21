using System;
using System.Collections.Generic;

namespace BusSystem.Data.Entities;

public partial class TblBu
{
    public int BusId { get; set; }

    public string? BusDestinationCity { get; set; }

    public string? BusSourceCity { get; set; }

    public int? BusCapacity { get; set; }

    public string? BusType { get; set; }

    public DateTime? BusDepartureTime { get; set; }

    public DateTime? BusArrivalTime { get; set; }
}
