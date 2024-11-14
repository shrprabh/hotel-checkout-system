namespace HotelCheckOutSystem
{
    public class PaymentProcessor
    {
        public string ConfirmationNumber { get; private set; }

        public bool ProcessPayment(string cardNumber, string pin, decimal amount)
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
