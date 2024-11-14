namespace HotelCheckOutSystem
{
    public class Room
    {
        public string RoomNumber { get; private set; }
        public string Status { get; private set; }
        public Customer Customer { get; private set; }

        public Room(string roomNumber, string status)
        {
            RoomNumber = roomNumber;
            Status = status;
        }

        public void AssignCustomer(Customer customer)
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
