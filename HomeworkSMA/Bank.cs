namespace HotelCheckOutSystem
{
    public class Bank
    {
        private string validCardNumber = "123456789000";
        private string validPin = "1234";
        public string ConfirmationNumber { get; private set; }

        public bool ChargeFee(string cardNumber, string pin, decimal amount)
        {
            if (cardNumber == validCardNumber && pin == validPin)
            {
                // Payment successful
                ConfirmationNumber = "989898";
                return true;
            }
            else
            {
                // Payment denied
                return false;
            }
        }
    }
}
