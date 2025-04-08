using System;

public class OutdoorGatheringEvent : Event {
    private string weatherForecast;
    
    public OutdoorGatheringEvent(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address) {
        this.weatherForecast = weatherForecast;
    }
    
    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nEvent Type: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}
