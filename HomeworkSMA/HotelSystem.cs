using System.Collections.Generic;

namespace HotelCheckOutSystem
{
    public class HotelSystem
    {
        public int TotalRooms { get; private set; } = 10;
        public int AvailableRooms { get; private set; } = 5;
        private Dictionary<string, Room> rooms;

        public HotelSystem()
        {
            rooms = new Dictionary<string, Room>();
            // Initialize room 5373 with customer information
            Room room = new Room("5373", "occupied");
            Customer customer = new Customer("John Doe", "123 Main St", 250m);
            room.AssignCustomer(customer);
            rooms.Add("5373", room);
        }

        public Customer GetCustomerInfo(string roomNumber)
        {
            if (rooms.ContainsKey(roomNumber))
            {
                return rooms[roomNumber].Customer;
            }
            else
            {
                return null;
            }
        }

        public Room GetRoom(string roomNumber)
        {
            if (rooms.ContainsKey(roomNumber))
            {
                return rooms[roomNumber];
            }
            else
            {
                return null;
            }
        }

        public void IncrementAvailableRooms()
        {
            AvailableRooms++;
        }
    }
}
