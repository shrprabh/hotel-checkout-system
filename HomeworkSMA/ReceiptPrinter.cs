using System;

namespace HotelCheckOutSystem
{
    public class ReceiptPrinter
    {
        public void PrintReceipt(CustomerInfo customer, decimal amount, string confirmationNumber)
        {
            Console.WriteLine("Printing receipt...");
            Console.WriteLine("------- Receipt -------");
            Console.WriteLine($"Customer Name: {customer.Name}");
            Console.WriteLine($"Address: {customer.Address}");
            Console.WriteLine($"Amount Paid: ${amount}");
            Console.WriteLine($"Confirmation Number: {confirmationNumber}");
            Console.WriteLine("-----------------------");
        }
    }
}
