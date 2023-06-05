namespace InterfacePractice
{
    public class Ram : Vehicle, IGasoline // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage {get; set;} = 74;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
    }
}