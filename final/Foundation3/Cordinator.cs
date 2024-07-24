using System;

public class Coordinator
{
    private Random _ran;
    private Lecture _lecture;
    private Reception _reception;
    private OutdoorGathering _outdoorGathering;

    public Coordinator()
    {
        _ran = new();
        _lecture = AddLecture();
        _reception = AddReception();
        _outdoorGathering = AddOutdoorGathering();
    }

    public void DisplayEvents()
    {
        Console.Clear();

        Console.WriteLine("Lecture Outut:");
        Console.WriteLine(_lecture.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(_lecture.FullDetails(_lecture.StandardDetails()));
        Console.WriteLine();
        Console.WriteLine(_lecture.ShortDescription());

        Console.WriteLine();

        Console.WriteLine("Reception Output:");
        Console.WriteLine(_reception.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(_reception.FullDetails(_reception.StandardDetails()));
        Console.WriteLine();
        Console.WriteLine(_reception.ShortDescription());

        Console.WriteLine();
        Console.WriteLine("OutdoorGathering Output:");
        Console.WriteLine(_outdoorGathering.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(_outdoorGathering.FullDetails(_outdoorGathering.StandardDetails()));
        Console.WriteLine();
        Console.WriteLine(_outdoorGathering.ShortDescription());
    }

    public Lecture AddLecture()
    {
        DateTime date = new(_ran.Next(2023,2025), _ran.Next(1,13), _ran.Next(1,32));
        Address address = CreateAddress();
        Lecture lecture = new("Cool Lecture", "Place to listen to a lecture.", date, "6pm", address, "George Lopez", _ran.Next(50,351));

        return lecture;
    }

    public Reception AddReception()
    {
        DateTime date = new(_ran.Next(2023,2025), _ran.Next(1,13), _ran.Next(1,32));
        Address address = CreateAddress();
        Reception reception = new("Reception of awesome", "Talk with all the people.", date, "3pm", address, "coolemail@gmail.com");

        return reception;
    }

    public OutdoorGathering AddOutdoorGathering()
    {
        DateTime date = new(_ran.Next(2023,2025), _ran.Next(1,13), _ran.Next(1,32));
        Address address = CreateAddress();
        OutdoorGathering outdoorGathering = new("Picnic", "All the burgers and corndogs you can eat.", date, "1pm", address, "70 degrees and sunny. 0% chance of rain.");

        return outdoorGathering;
    }

    public Address CreateAddress()
    {
        List<string> streetAddress = ["20 Cooper Square", "6 Metrotech Center", "9th St. PATH Station"];
        List<string> city = ["Rexburg", "Los Angeles", "Seattle"];
        List<string> state = ["ID", "CA", "WA"];
        List<string> country = ["USA", "Canada"];

        Address address = new(streetAddress[_ran.Next(0,3)], city[_ran.Next(0,3)], state[_ran.Next(0,3)], country[_ran.Next(0,2)]);
        
        return address;
    }
}