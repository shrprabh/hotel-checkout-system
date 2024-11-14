using System;

namespace HotelCheckOutSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize hotel system with available rooms
            HotelSystem hotelSystem = new HotelSystem();
            // Initialize desk clerk
            DeskClerk deskClerk = new DeskClerk(hotelSystem);
            // Start checkout process
            deskClerk.StartCheckOutProcess();
        }
    }
}
