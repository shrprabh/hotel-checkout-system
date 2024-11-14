using System;

namespace HotelCheckOutSystem
{
    public class DeskClerk
    {
        private CheckOutController checkOutController;

        public DeskClerk(HotelSystem hotelSystem)
        {
            checkOutController = new CheckOutController(hotelSystem);
        }

        public void StartCheckOutProcess()
        {
            // 1. The desk clerk selects the checkout in the system
            checkOutController.SelectCheckout();

            // 2. The desk clerk enters the room number of the customer.
            Console.WriteLine("Enter the room number of the customer:");
            string roomNumber = Console.ReadLine();

            checkOutController.EnterRoomNumber(roomNumber);

            // 5. The desk clerk enters the customer’s credit card details.
            Console.WriteLine("Enter the customer's credit card number:");
            string cardNumber = Console.ReadLine();

            Console.WriteLine("Enter the PIN:");
            string pin = Console.ReadLine();

            checkOutController.EnterCreditCardDetails(cardNumber, pin);

            // 8. The desk clerk selects a printing option to print the receipt.
            Console.WriteLine("Select a printing option to print the receipt (Y/N):");
            string printOption = Console.ReadLine();
            if (printOption.ToUpper() == "Y")
            {
                checkOutController.SelectPrintReceipt();
            }
        }
    }
}
