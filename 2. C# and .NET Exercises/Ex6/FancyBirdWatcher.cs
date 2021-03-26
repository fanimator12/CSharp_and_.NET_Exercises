using System;

namespace Ex4
{
    class FancyBirdWatcher : BirdWatcher
    {

        public FancyBirdWatcher(string name, Bird bird) : base(name, bird)
        {
            Console.WriteLine($"Fancy BirdWatcher {Name} starts looking for birds.");
            bird.Sing += ReactToSing;
        }

        public override void ReactToFlap()
        {
            System.Console.WriteLine($"{Name}: Olala fancy wings there!");
        }

        public void ReactToSing()
        {
            System.Console.WriteLine($"{Name}: Olala What a beautiful voice!");
        }
    }
}