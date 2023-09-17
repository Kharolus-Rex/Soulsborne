﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    /* In this area will exist all of the lists
     * for things such as Weapons, Rooms, Items
     * Treasures, Monsters, etc.
     * 
     */

    public static class World
    {
        public static List<Room> rooms = new List<Room>();
        public static List<Weapon> weapons = new List<Weapon>();
        public static List<Monster> monsters = new List<Monster>();
        public static List<Player> players = new List<Player>();
        public static List<Potion> potion = new List<Potion>();
        public static List<Treasures> treasures = new List<Treasures>();
        public static List<Items> items = new List<Items>();

        public static Room FindRoomByID(int roomId)
        {
            foreach (Room room in rooms)
            {
                if (room.IdNumber == roomId)
                {
                    return room;
                }
            }
            return null;
        }
    }
}
