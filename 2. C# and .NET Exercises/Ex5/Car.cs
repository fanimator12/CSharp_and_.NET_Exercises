namespace Ex5
{
    class Car
    {
        public string Color { get; set; }
        public int EngineSize { get; set; }
        public int FuelEconomy { get; set; }
        public bool IsManualShift { get; set; }

        public Car(string color, int engineSize, int fuelEconomy, bool isManualShift)
        {
            Color = color;
            EngineSize = engineSize;
            FuelEconomy = fuelEconomy;
            IsManualShift = isManualShift;
        }

        public override string ToString()
        {
            return $"Color: {Color}, EngineSize: {EngineSize}, FuelEconomy: {FuelEconomy}, IsManualShift: {IsManualShift}";
        }
    }
}
