using System;

public class ReceptionEvent : Event {
    private string rsvpEmail;
    
    public ReceptionEvent(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address) {
        this.rsvpEmail = rsvpEmail;
    }
    
    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {rsvpEmail}";
    }
}
