using System.Threading;

namespace Ex4
{
    class Program
    {
        /*
         Write a small program to represent people watching birds.

        Make a Bird class with a method to run the example. 
        This example should have a loop, where you print 
        out bird behaviour, e.g. "Bird flaps wings", "Bird sings", 
        etc.       

        Create watcher classes, which will react to the birds 
        behaviour with exclamations like: “Ooh”, “How nice”, 
        “Would you look at that”. You could also create a deaf 
        bird watcher, which doesn't react to the bird's singing.

        Use Actions/delegates to have the watchers observe the bird.

        Run the example from a main method to verify the behaviour.
         */
        static void Main(string[] args)
        {
            var bird = new Bird();

            var jakob = new FancyBirdWatcher("Jakob", bird);
            Thread.Sleep(1000);
            var troels = new DeafBirdWatcher("Troels", bird);
            Thread.Sleep(1000);

            bird.Fly();
        }
    }
}
