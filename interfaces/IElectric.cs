namespace InterfacePractice
{
    public interface IElectric
    {
        public int CurrentChargePercentage {get;}

        public void ChargeBattery();
    }
}