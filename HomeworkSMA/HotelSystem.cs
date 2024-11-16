using System.Collections.Generic;

namespace HotelCheckOutSystem
{
    public class HotelSystem
    {
        // initializing the total rooms to 10 based on question
        public int TotalRooms { get; private set; } = 10;
        public int AvailableRooms { get; private set; } = 5;
        private Dictionary<string, RoomInfo> rooms;

        public HotelSystem()
        {
            rooms = new Dictionary<string, RoomInfo>();
            // Initialize room 5373 with customer information
            RoomInfo room = new RoomInfo("5373", "occupied");
            CustomerInfo customer = new CustomerInfo("Shreyas Prabhakar", "123 Main St", 250m);
            room.AssignCustomer(customer);
            rooms.Add("5373", room);
        }

        public CustomerInfo GetCustomerInfo(string roomNumber)
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

        public RoomInfo GetRoom(string roomNumber)
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
