using System;

namespace HotelCheckOutSystem
{
    public class FrontDeskDisplay
    {
        public void UpdateAvailableRoomsDisplay(int availableRooms)
        {
            Console.WriteLine($"Available rooms updated. Now available: {availableRooms}");
        }
    }
}
