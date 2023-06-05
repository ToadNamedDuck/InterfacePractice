namespace InterfacePractice
{
    public class Tesla : Vehicle, IElectric // Electric car
    {
        public int CurrentChargePercentage {get; set;} = 33;
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }
}