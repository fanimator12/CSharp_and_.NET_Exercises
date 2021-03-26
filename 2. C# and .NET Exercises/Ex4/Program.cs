using System;

namespace Ex4
{
    class Program
    {
        /*
         In the Main method of the Program class, 
         create an instance of the WaitingRoom and 
         call the RunWaitingRoom method. Currently it 
         won't do anything, because no patients 
         have drawn a number.
         */
        static void Main(string[] args)
        {
            var wr = new WaitingRoom();

            var jakob = new Patient(wr);
            var troels = new Patient(wr);
            var kasper = new Patient(wr);

            wr.RunWaitingRoom();
        }
    }
}
