using System;
using System.Threading;

namespace Ex4
{
    class Bird
    {
        public Action FlapWings;
        public Action Sing;

        public void Fly()
        {
            while (true)
            {
                Console.WriteLine("Bird flaps its wings");
                FlapWings();

                Thread.Sleep(1000);

                Console.WriteLine("Bird sings");
                Sing();

                Thread.Sleep(1000);
            }
        }
    }
}