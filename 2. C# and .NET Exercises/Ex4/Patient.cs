using System;
using System.Threading;

namespace Ex4
{
    class Patient
    {
        /*
         In the constructor, add the ReactToNumber 
         method to the WaitingRoom's Action. Make the patient 
         draw a number from the WaitingRoom.

        In the ReactToNumber, on notification the patient 
        must look up (print out behaviour), if it’s their 
        number go to the doctor’s office, otherwise go 
        back to play with phone. 

        In the main method, create a bunch of patients.
        Upon notification the patient must look up 
        (print out behaviour), if it’s their number go 
        to the doctor’s office, otherwise go back to play 
        with phone. 

        Simulate this with print outs.
         */
        int numberInQueue;

        private WaitingRoom wr;

        public Patient(WaitingRoom wr)
        {
            this.wr = wr;
            wr.NumberChange += ReactToNumber;
            numberInQueue = wr.DrawNumber();
            Console.WriteLine($"Patient {numberInQueue} enters waiting room");
            Thread.Sleep(1000);
        }

        public void ReactToNumber(int ticketNumber)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Patient {numberInQueue} looks up");
            Thread.Sleep(1000);
            if (ticketNumber == numberInQueue)
            {
                Console.WriteLine($"Patient {numberInQueue} goes to the doctor's room");
                wr.NumberChange -= ReactToNumber;
            }
            else
            {
                Console.WriteLine($"Patient {numberInQueue} goes back to looking at phone");
            }
        }
    }
}