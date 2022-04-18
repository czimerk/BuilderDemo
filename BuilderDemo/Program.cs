// See https://aka.ms/new-console-template for more information
using BuilderDemo.Builder;
using BuilderDemo.Models;
using BuilderDemo.Enums;

Console.WriteLine("Hello, World!");

var builder = new OfficeBuilder();

var officeB = builder
    .WithEntrace()
    .WithParkingLot()
    .WithFloors(5)
    .AddRoom(0, RoomType.Hall)
    .AddRooms(1, RoomType.Restroom, 2)
    .AddRooms(1, RoomType.MeetingRoom, 2)
    .AddRooms(1, RoomType.DevRoom, 4)
    .AddRooms(2, RoomType.Restroom, 2)
    .AddRooms(2, RoomType.MeetingRoom, 2)
    .AddRooms(2, RoomType.DevRoom, 4)
    .AddRoom(3, RoomType.Restaurant)
    .AddRooms(3, RoomType.Restroom, 2)
    .AddRoom(4, RoomType.Roof, new List<Equipment>() { new Antenna() })
    .Build();

var builder2 = new OfficeBuilder();
builder2.WithEntrace().WithParkingLot().WithFloors(2);
builder2.AddRoom(0, RoomType.Hall);
builder2.AddRoom(1, RoomType.Restroom);
for (int i = 0; i < 6; i++)
{
    builder2.AddRoom(1, RoomType.DevRoom);
}
var office2 = builder2.Build();

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