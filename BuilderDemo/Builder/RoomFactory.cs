using BuilderDemo.Enums;
using BuilderDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Builder
{
    internal class RoomFactory
    {
        internal Room Create(RoomType type, List<Equipment> equipments = null)
        {
            switch (type)
            {
                case RoomType.Restroom:
                    {
                        return new Restroom();
                    }
                case RoomType.Restaurant:
                    {
                        return new Restaurant();
                    }
                case RoomType.DevRoom:
                    {
                        return new DevRoom();
                    }
                case RoomType.MeetingRoom:
                    {
                        return new MeetingRoom();
                    }
                case RoomType.Roof:
                    {
                        return new Roof()
                        {
                            Equipments = equipments ?? new List<Equipment>()
                        };
                    }
                case RoomType.Hall:
                    {
                        return new Hall();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
