using BuilderDemo.Enums;
using BuilderDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Builder
{
    public class OfficeBuilder
    {
        private Office _office = new Office();

        internal OfficeBuilder WithEntrace()
        {
            _office.Entrance = new Entrance();
            return this;
        }

        internal OfficeBuilder WithParkingLot()
        {
            _office.ParkingLot = new ParkingLot();
            return this;
        }

        internal OfficeBuilder WithFloors(int floorNumber)
        {
            _office.Floors = new List<Floor>();
            for (int i = 0; i < floorNumber; i++)
            {
                _office.Floors.Add(new Floor() { Id = i });
            }
            return this;
        }
        internal OfficeBuilder AddRoom(int floorIndex, RoomType type, List<Equipment> equipments = null)
        {
            var roomFactory = new RoomFactory();
            var room = roomFactory.Create(type, equipments);
            if (_office.Floors[floorIndex].Rooms == null)
            {
                _office.Floors[floorIndex].Rooms = new List<Room>();
            }
            _office.Floors[floorIndex].Rooms.Add(room);

            return this;
        }

        internal OfficeBuilder AddEquipment(int floorIndex, RoomType type)
        {
            var roomFactory = new RoomFactory();
            var room = roomFactory.Create(type);
            if (_office.Floors[floorIndex].Rooms == null)
            {
                _office.Floors[floorIndex].Rooms = new List<Room>();
            }
            _office.Floors[floorIndex].Rooms.Add(room);

            return this;
        }

        internal Office Build()
        {
            return _office;
        }
    }
}
