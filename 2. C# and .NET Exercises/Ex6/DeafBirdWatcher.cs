using System;

namespace Ex4
{
    class DeafBirdWatcher : BirdWatcher
    {

        public DeafBirdWatcher(string name, Bird bird) : base(name, bird)
        {
            Console.WriteLine($"Deaf BirdWatcher {Name} starts looking for birds.");
        }

        public override void ReactToFlap()
        {
            System.Console.WriteLine($"{Name}: Nøøj flotte vinger!");
        }
    }
}