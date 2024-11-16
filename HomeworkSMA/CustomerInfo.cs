namespace HotelCheckOutSystem
{
    public class CustomerInfo
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public decimal TotalBill { get; private set; }

        public CustomerInfo(string name, string address, decimal totalBill)
        {
            Name = name;
            Address = address;
            TotalBill = totalBill;
        }
    }
}
