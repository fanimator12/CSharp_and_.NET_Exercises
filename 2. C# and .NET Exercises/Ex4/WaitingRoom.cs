using System;
using System.Threading;

namespace Ex4
{
    class WaitingRoom
    {
        /*
         Initialize currentNumber and ticketCount to 0.

        Method RunWaitingRoom() should have a loop, 
        which runs as long as currentNumber is lower 
        than ticketCount. In the loop, increment currentNumber 
        and call NumberChange with the currentNumber.

        Occasionally the doctor is ready for the next patient, 
        so the patients are informed by the ticket system in 
        the waiting room, and the patient with the correct 
        ticket number enters the doctor’s office. Make a print 
        out whenever the number changes, e.g. "Patient number 
        {currentNumber} can now enter". Use Thread.Sleep(1000) 
        to pause the program, like in Java.

        In DrawNumber() increment ticketCount, then return 
        ticketCount. This method simulates when patients enter 
        the waiting room and draw a number.
        */
        int currentNumber = 0;
        int ticketCount = 0;
        public Action<int> NumberChange;

        public void RunWaitingRoom()
        {
            while (currentNumber < ticketCount)
            {
                currentNumber++;
                Console.WriteLine("Diing!");
                NumberChange(currentNumber);
                Thread.Sleep(1000);
            }
        }

        public int DrawNumber()
        {
            ticketCount++;
            return ticketCount;
        }
    }
}