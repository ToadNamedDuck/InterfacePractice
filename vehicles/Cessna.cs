namespace InterfacePractice
{
    public class Cessna : Vehicle, IGasoline // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage {get; set;} = 42;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
    }
}