using System;

public class LectureEvent : Event {
    private string speaker;
    private int capacity;
    
    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address) {
        this.speaker = speaker;
        this.capacity = capacity;
    }
    
    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nEvent Type: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}
