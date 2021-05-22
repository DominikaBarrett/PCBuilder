namespace PCBuilder.Parts
{
    public class HeatSink :PcPart
    {
        public int ThermalPower;

        public HeatSink (string SetPartName, double SetPrice, int SetThermalPower)
        {
            ThermalPower = SetThermalPower;
            PartName = SetPartName;
            Price = SetPrice;
        }
    }
}