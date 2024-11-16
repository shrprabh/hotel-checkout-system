namespace HotelCheckOutSystem
{
    public class RoomInfo
    {
        public string RoomNumber { get; private set; }
        public string Status { get; private set; }
        public CustomerInfo Customer { get; private set; }

        public RoomInfo(string roomNumber, string status)
        {
            RoomNumber = roomNumber;
            Status = status;
        }

        public void AssignCustomer(CustomerInfo customer)
        {
            Customer = customer;
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
            if (newStatus == "available")
            {
                Customer = null;
            }
        }
    }
}
