using System;

namespace HotelCheckOutSystem
{
    public class CheckOutController
    {
        private HotelSystem hotelSystem;
        private Customer customer;
        private Room room;
        private PaymentProcessor paymentProcessor;
        private ReceiptPrinter receiptPrinter;
        private FrontDeskDisplay frontDeskDisplay;

        public CheckOutController(HotelSystem hotelSystem)
        {
            this.hotelSystem = hotelSystem;
            paymentProcessor = new PaymentProcessor();
            receiptPrinter = new ReceiptPrinter();
            frontDeskDisplay = new FrontDeskDisplay();
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
            bool paymentSuccess = paymentProcessor.ProcessPayment(cardNumber, pin, customer.TotalBill);

            if (paymentSuccess)
            {
                Console.WriteLine("Payment successful.");
                // 10. The system updates the room status to 'available'.
                room.UpdateStatus("available");
                // 11. The system increases the number of available rooms displayed at the front desk for the customers.
                hotelSystem.IncrementAvailableRooms();
                frontDeskDisplay.UpdateAvailableRoomsDisplay(hotelSystem.AvailableRooms);
            }
            else
            {
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
            receiptPrinter.PrintReceipt(customer, customer.TotalBill, paymentProcessor.ConfirmationNumber);
        }
    }
}
