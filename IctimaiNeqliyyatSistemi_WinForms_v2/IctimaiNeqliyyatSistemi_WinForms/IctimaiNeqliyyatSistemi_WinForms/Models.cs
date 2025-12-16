using System;
using System.Collections.Generic;

namespace IctimaiNeqliyyatSistemi_WinForms
{
    public sealed class Stop
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "";
        public string District { get; set; } = "";
        public override string ToString() => $"{Name} ({District})";
    }

    public sealed class Route
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Code { get; set; } = "";
        public string Name { get; set; } = "";
        public List<Guid> StopIds { get; set; } = new();
        public override string ToString() => $"{Code} - {Name}";
    }

    public sealed class Trip
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid RouteId { get; set; }
        public DateTime Departure { get; set; } = DateTime.Now;
        public string BusNo { get; set; } = "";
    }

    public enum PassengerType
    {
        Adi,
        Telebe,
        Pensiya
    }

    public enum PaymentType
    {
        Nagd,
        Kart
    }

    public sealed class TicketSale
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid TripId { get; set; }
        public DateTime SoldAt { get; set; } = DateTime.Now;
        public PassengerType PassengerType { get; set; }
        public PaymentType PaymentType { get; set; }
        public decimal Price { get; set; }
    }

    public sealed class TransportState
    {
        public List<Stop> Stops { get; set; } = new();
        public List<Route> Routes { get; set; } = new();
        public List<Trip> Trips { get; set; } = new();
        public List<TicketSale> Sales { get; set; } = new();
    }
}
