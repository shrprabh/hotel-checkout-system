namespace HotelCheckOutSystem
{
    public class Bill
    {
        public string ConfirmationNumber { get; private set; }

        public bool ProcessBill(string cardNumber, string pin, decimal amount)
        {
            // Simulate bank interaction
            Bank bank = new Bank();
            bool paymentSuccess = bank.ChargeFee(cardNumber, pin, amount);
            if (paymentSuccess)
            {
                ConfirmationNumber = bank.ConfirmationNumber;
            }
            return paymentSuccess;
        }
    }
}
