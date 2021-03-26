using System;

namespace Ex3
{
    class Program
    {
        /*
         In the Time struct, define two methods:

        - AddMinutes(int minutes)
        - SubtractMinutes(int minutes)
        
        Implement their behavior. Test that this works. 
        Make sure that your number of minutes doesn't exceed 59, 
        or hours 23. If you would go beyond 23:59, reset the hours to 0, 
        as a normal clock.
         */
        static void Main(string[] args)
        {
            Time t = new Time(23, 55);
            Console.WriteLine(t);
            t.AddMinutes(10);
            Console.WriteLine(t);
            t.SubtractMinutes(30);
            Console.WriteLine(t);

            t = new Time(00, 05);
            t.SubtractMinutes(20);
            Console.WriteLine(t);

            t = new Time(00, 05);
            t.AddMinutes(20);
            Console.WriteLine(t);

            t = new Time(00, 05);
            t.SubtractMinutes(120);
            Console.WriteLine(t);

            t = new Time(00, 05);
            t.SubtractMinutes(1560);
            Console.WriteLine(t);

            t = new Time(00, 05);
            t.AddMinutes(1560);
            Console.WriteLine(t);
        }
    }

    public struct Time
    {
        private int minutes;

        public int Hour
        {
            get
            {
                return minutes > 0 ? (minutes / 60) % 24 : ((1440 - Math.Abs(minutes) % 1440) / 60) % 24;
            }
            set
            {
                minutes = 60 * value;
            }
        }

        public int Minute
        {
            get
            {
                return minutes > 0 ? minutes % 60 : 60 - Math.Abs(minutes) % 60;
            }
            set
            {
                minutes = value;
            }
        }

        public Time(int hours, int minutes)
        {
            this.minutes = minutes + 60 * hours;
        }

        public override string ToString()
        {
            return $"{String.Format("{0:00}", Hour)}:{String.Format("{0:00}", Minute)}";
        }

        public void AddMinutes(int minutes)
        {
            this.minutes += minutes;
        }

        public void SubtractMinutes(int minutes)
        {
            this.minutes -= minutes;
        }
    }
}
