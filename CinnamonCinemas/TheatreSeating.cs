namespace CinnamonCinemas
{
    public class TheatreSeating
    {
        public int MaxCapacity { get; private set; }
        public Queue<string> Seats { get; private set; }
        public IDictionary<int, string>? SeatsSoldDic { get; private set; }


        public TheatreSeating()
        {
            MaxCapacity = 15;
            Seats = CreateSeats();
            SeatsSoldDic = new Dictionary<int, string>();
        }

        public Queue<string> CreateSeats()
        {
            char maxRow = 'C';
            int maxCol = 5;

            Queue<string> seats = new Queue<string>();

            for (char c = 'A'; c <= maxRow; c++)
                for (int i = 1; i <= maxCol; i++)
                    seats.Enqueue(c.ToString() + i.ToString());

            return seats;

        }
        public void FillSeats()
        {
            int seatRequests = 0;
            int seatsSold = SeatsSoldDic.Count;

            do
            {
                Random rnd = new Random();
                seatRequests = rnd.Next(1, 3);
               
                
                for (int i = seatsSold; i <= (seatsSold + seatRequests); i++)
                {
                    SeatsSoldDic.Add(i, Seats.Peek());
                    Seats.Dequeue();
                }

            } while (seatRequests <= Seats.Count());

            PrintSoldSeats();
        }

        public void PrintSoldSeats()
        {
            SeatsSoldDic.ToList().ForEach(action: x => Console.WriteLine(x.Value));
        }
    }

}
