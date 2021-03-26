namespace Ex4
{
    abstract class BirdWatcher
    {
        public string Name { get; set; }

        public BirdWatcher(string name, Bird bird)
        {
            Name = name;
            bird.FlapWings += ReactToFlap;
        }

        public abstract void ReactToFlap();
    }
}