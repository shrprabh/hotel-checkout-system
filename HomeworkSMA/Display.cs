using System;

namespace HotelCheckOutSystem
{
    public class Display
    {
        public void UpdateAvailableRoomsDisplay(int availableRooms)
        {
            Console.WriteLine($"Available rooms updated. Now available: {availableRooms}");
        }
    }
}
