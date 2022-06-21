using FluentAssertions;
using CinnamonCinemas;

namespace CinnamonCinemasTests
{
    public class TheatreSeatingTests
    {
        private TheatreSeating? theatreSeats;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnMaxSeatof15()
        {
            theatreSeats = new TheatreSeating();

            Assert.That(theatreSeats.CreateSeats().Count(), Is.EqualTo(15));
        }

        [Test]
        public void SeatsSoldShoulEqual()
        {
            theatreSeats = new TheatreSeating();

            //the number of seats sold should equal max capacity subtracted by the number or seats that remain
            Assert.That(theatreSeats.SeatsSoldDic, Has.Count.EqualTo(theatreSeats.MaxCapacity - theatreSeats.Seats.Count));
        }
    }
}