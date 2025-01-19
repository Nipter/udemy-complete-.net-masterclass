
namespace Domain
{
    public class Flight
    {
        List<Booking> bookinfList = new();
        public IEnumerable<Booking> BookingList => bookinfList;
 
        public int RemainingNumberOfSeats { get; set; }

        public Guid Id { get; }

        [Obsolete("Needed by EF")]
        public Flight()
        {
            
        }

        public Flight(int seatCapacity)
        {
            RemainingNumberOfSeats = seatCapacity;
        }

        public object? Book(string passengerEmail, int numberOfSeats)
        {
            if (numberOfSeats > this.RemainingNumberOfSeats)
            {
                return new OverbookingError();
            }

            bookinfList.Add(new Booking(passengerEmail, numberOfSeats));

            RemainingNumberOfSeats -= numberOfSeats;
            return null;
        }

        public object? CancelBooking(string passengerEmail, int numberSteats)
        {
            if(!BookingList.Any(booking => booking.Email == passengerEmail))
            {
                return new BookingNotFoundError();
            }
            RemainingNumberOfSeats += numberSteats;
            return null;
        }
    }
}
