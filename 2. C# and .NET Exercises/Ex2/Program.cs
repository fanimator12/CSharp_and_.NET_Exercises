using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Time(13, 37));
            Console.WriteLine(new Time(24, 00));
            Console.WriteLine(new Time(12, 55));
            Console.WriteLine(new Time(02, 65));
        }
    }
    
// A struct type Time can be declared as follows: 
    public struct Time
    {
        private int minutes;

        public int Hour
        {
            get
            {
                return minutes / 60;
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
                return minutes % 60;
            }
            set
            {
                minutes = value;
            }
        }
/*
    In the Time struct type, declare a

    - public property Hour returning the number of hours
    - public property Minute returning the number of minutes.
     

    For instance, new Time(23, 45).Minute should be 45.

    Modify the ToString() method so that it shows a Time in the format hh:mm, for instance 10:05, instead of 605. 

     

    Test your struct with a few different time values.
 */
        public Time(int hours, int minutes)
        {
            this.minutes = minutes + 60 * hours;
        }

        public override string ToString()
        {
            return $"{String.Format("{0:00}", Hour)}:{String.Format("{0:00}", Minute)}";
        }
    }
}
