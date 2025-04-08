using System;

public class Program {
    public static void Main() {
        Address address1 = new Address("Ceibos", "Guayaquil", "GYE", "ECU");
        Address address2 = new Address("Calle 50 & Calle 67 E", "Ciudad de Panama", "PA", "PAN");
        Address address3 = new Address("58 S 5 W", "Denver", "CO", "USA");
        
        LectureEvent lecture = new LectureEvent("Biotechnology", "How Biotech will change the world we know", "01 JUL 2025", "08:00 AM", address1, "Jose Velastegui", 50);
        ReceptionEvent reception = new ReceptionEvent("Networking Software event", "Conect with potential recruters", "28 Dec 2025", "08:00 PM", address2, "jose@outlook.com");
        OutdoorGatheringEvent outdoor = new OutdoorGatheringEvent("Party", "Dance and recreation", "19 OCT 2025", "09:00 PM", address3, "Music and dance");
        
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("\n--------------------\n");
        
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("\n--------------------\n");
        
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetShortDescription());
    }
}
