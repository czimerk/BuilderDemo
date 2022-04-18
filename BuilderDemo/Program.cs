// See https://aka.ms/new-console-template for more information
using BuilderDemo.Models;

Console.WriteLine("Hello, World!");

var office = new Office()
{
    Entrance = new Entrance(),
    ParkingLot = new ParkingLot(),
    Floors = new List<Floor>()
    {
        new Floor()
        { 
            Id = 0,
            Rooms = new List<Room>()
            { 
                new Hall()
            }
        },
        new Floor()
        {
            Id = 1,
            Rooms = new List<Room>()
            {
                new Restroom(),
                new Restroom(),
                new MeetingRoom(),
                new MeetingRoom(),
                new DevRoom(),
                new DevRoom(),
                new DevRoom(),
                new DevRoom()
            }
        },
        new Floor()
        {
            Id = 2,
            Rooms = new List<Room>()
            {
                new Restroom(),
                new Restroom(),
                new MeetingRoom(),
                new MeetingRoom(),
                new DevRoom(),
                new DevRoom(),
                new DevRoom(),
                new DevRoom()
            }
        },
        new Floor()
        {
            Id = 3,
            Rooms = new List<Room>()
            {
                new Restaurant(),
                new Restroom(),
                new Restroom()
            }
        },
        new Floor()
        {
            Id = 4,
            Rooms = new List<Room>()
            {
                new Roof()
                {
                    Equipments = new List<Equipment>()
                    {
                        new Antenna()
                    } 
                }
            }
        }
    }

};