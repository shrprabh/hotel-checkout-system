namespace HotelCheckOutSystem
{
    public class Bank
    {
        private string validCardNumber = "1234 5678 9000";
        private string validPin = "1234";
        public string ConfirmationNumber { get; private set; }

        public bool ChargeFee(string cardNumber, string pin, decimal amount)
        {
            // 7. The bank returns a confirmation number to the system if payment is successful.
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
