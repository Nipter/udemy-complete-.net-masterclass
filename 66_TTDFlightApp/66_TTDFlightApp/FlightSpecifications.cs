using System.Globalization;
using Domain;
using FluentAssertions;

namespace _66_TTDFlightApp
{
    public class FlightSpecifications
    {
        [Theory]
        [InlineData(3,2,1)]
        [InlineData(6,3,3)]
        [InlineData(10,6,4)]
        [InlineData(12,8,4)]
        public void Booking_reduces_the_nuber_of_seats(int seatCapacity, int numberOfSeats, int remainingNumberOfSeats)
        {
            var flight = new Flight(seatCapacity: seatCapacity);

            flight.Book("examiple@example.com", numberOfSeats);

            flight.RemainingNumberOfSeats.Should().Be(remainingNumberOfSeats);
        }

        [Fact]
        public void Avoids_overbooking()
        {
            //Given
            var flight = new Flight(3);

            //when
            var error = flight.Book("example@example.com", 4);

            //Then
            error.Should().BeOfType<OverbookingError>();
        }

        [Fact]
        public void Books_flights_successfully()
        {
            var flight = new Flight(3);
            var error = flight.Book("example@example.com", 1);
            error.Should().BeNull();
        }

        [Fact]
        public void Remembers_booking()
        {
            var flight = new Flight(150);

            flight.Book("example@example.com", 4);

            flight.BookingList.Should().ContainEquivalentOf(new Booking("example@example.com", 4));
        }

        [Theory]
        [InlineData(3,1,1,3)]
        [InlineData(4,2,2,4)]
        [InlineData(7,5,4,6)]
        public void Canceling_bookings_frees_up_the_seats(int initialCapacity, int numberOfSeatsToBook, int numberOfSeatsToCancel, int remainingNumberOfSeats)
        {
            // Given
            var flight = new Flight(initialCapacity);
            flight.Book("a@b.com", numberOfSeatsToBook);

            // When
            flight.CancelBooking(passengerEmail: "a@b.com", numberSteats: numberOfSeatsToCancel);

            // Then
            flight.RemainingNumberOfSeats.Should().Be(remainingNumberOfSeats);
        }

        [Fact]
        public void Doesnt_cancel_booking_for_passengers_who_have_not_booked()
        {
            var flight = new Flight(3);
            var error = flight.CancelBooking("a@b.com", 2);
            error.Should().BeOfType<BookingNotFoundError>();
        }

        [Fact]
        public void Returns_null_when_successfullt_cancels_a_booking()
        {
            var flight = new Flight(3);
            flight.Book("a@b.com", 1);
            var error = flight.CancelBooking("a@b.com", 1);
            error.Should().BeNull();
        }
    }
}