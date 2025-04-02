using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Los Angeles", "CA", "USA");
        Address address3 = new Address("789 Oak St", "Chicago", "IL", "USA");

        Event lecture = new Lecture("Tech Innovations", "A talk on future tech trends", "April 10, 2025", "10:00 AM", address1, "Dr. Smith", 100);
        Event reception = new Reception("Company Gala", "Networking event for professionals", "May 5, 2025", "7:00 PM", address2, "rsvp@company.com");
        Event outdoorGathering = new OutdoorGathering("Spring Festival", "Outdoor celebration of spring", "June 15, 2025", "3:00 PM", address3, "Sunny with mild winds");

        Event[] events = { lecture, reception, outdoorGathering };
        
        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("--------------------------");
        }
    }
}
