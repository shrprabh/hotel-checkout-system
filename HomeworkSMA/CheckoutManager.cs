using System;
using Microsoft.VisualBasic.FileIO;
using System.Runtime.ConstrainedExecution;

namespace HotelCheckOutSystem
{
    public class CheckOutManager
    {
        private HotelSystem hotelSystem;
        private CustomerInfo customer;
        private RoomInfo room;
        private Bill processBill;
        private ReceiptPrinter receiptPrinter;
        private Display display;

        public CheckOutManager(HotelSystem hotelSystem)
        {
            this.hotelSystem = hotelSystem;
            processBill = new Bill();
            receiptPrinter = new ReceiptPrinter();
            display = new Display();
        }

        public void SelectCheckout()
        {
            // Checkout selected
            Console.WriteLine("Checkout process started.");
        }

        public void EnterRoomNumber(string roomNumber)
        {
            // 3. The system retrieves the customer’s information.
            customer = hotelSystem.GetCustomerInfo(roomNumber);
            if (customer != null)
            {
                room = hotelSystem.GetRoom(roomNumber);
                // 4. The system displays the total bill to the clerk.
                DisplayBill(customer.TotalBill);
            }
            else
            {
                Console.WriteLine("Invalid room number. Exiting checkout process.");
                Environment.Exit(0);
            }
        }

        private void DisplayBill(decimal totalAmount)
        {
            Console.WriteLine($"The total bill is: ${totalAmount}");
        }

        public void EnterCreditCardDetails(string cardNumber, string pin)
        {
            // 6. The system requests the bank to charge the fee.
            bool paymentSuccess = processBill.ProcessBill(cardNumber, pin, customer.TotalBill);

            if (paymentSuccess)
            {
                Console.WriteLine("Payment successful.");
                // 10. The system updates the room status to 'available'.
                room.UpdateStatus("available");
                // 11. The system increases the number of available rooms displayed at the front desk for the customers.
                hotelSystem.IncrementAvailableRooms();
                display.UpdateAvailableRoomsDisplay(hotelSystem.AvailableRooms);
            }
            else
            {
                // Step 7: If the bank denies, the system displays an error message and prompts the desk clerk to enter
                //the different details.
                // Alternative flow: Payment denied
                Console.WriteLine("Payment denied. Please enter different credit card details.");
                Console.WriteLine("Enter the customer's credit card number:");
                string newCardNumber = Console.ReadLine();

                Console.WriteLine("Enter the PIN:");
                string newPin = Console.ReadLine();

                EnterCreditCardDetails(newCardNumber, newPin);
            }
        }

        public void SelectPrintReceipt()
        {
            // 9. The system prints the receipt.
            receiptPrinter.PrintReceipt(customer, customer.TotalBill, processBill.ConfirmationNumber);
        }
    }
}
