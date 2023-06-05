namespace InterfacePractice
{
    public class Zero : Vehicle, IElectric // Electric motorcycle
    {
        public int CurrentChargePercentage {get; set;} = 25;
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }
}