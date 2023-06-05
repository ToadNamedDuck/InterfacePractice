namespace InterfacePractice
{
    public interface IElectric
    {
        int CurrentChargePercentage {get;}

        void ChargeBattery();
    }
}