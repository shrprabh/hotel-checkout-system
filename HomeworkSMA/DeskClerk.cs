using System;

namespace HotelCheckOutSystem
{
    public class DeskClerk
    {
        private CheckOutManager checkOutManager;

        public DeskClerk(HotelSystem hotelSystem)
        {
            checkOutManager = new CheckOutManager(hotelSystem);
        }

        public void StartCheckOutProcess()
        {
            // 1. The desk clerk selects the checkout in the system
            checkOutManager.SelectCheckout();

            // 2. The desk clerk enters the room number of the customer.
            Console.WriteLine("Enter the room number of the customer:");
            string roomNumber = Console.ReadLine();

            checkOutManager.EnterRoomNumber(roomNumber);

            // 5. The desk clerk enters the customer’s credit card details.
            Console.WriteLine("Enter the customer's credit card number:");
            string cardNumber = Console.ReadLine();

            Console.WriteLine("Enter the PIN:");
            string pin = Console.ReadLine();

            checkOutManager.EnterCreditCardDetails(cardNumber, pin);

            // 8. The desk clerk selects a printing option to print the receipt.
            Console.WriteLine("Select a printing option to print the receipt (Y/N):");
            string printOption = Console.ReadLine();
            if (printOption.ToUpper() == "Y")
            {
                checkOutManager.SelectPrintReceipt();
            }
        }
    }
}
