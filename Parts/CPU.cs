namespace PCBuilder.Parts
{
    public class CPU : PcPart
    {
        public int ElectricalPower;
        public int ThermalPower;

        public CPU(string SetPartName, double SetPrice, int SetElectricalPower, int SetThermalPower)
        {
            ElectricalPower = SetElectricalPower;
            ThermalPower = SetThermalPower;
            PartName = SetPartName;
            Price = SetPrice;
        }

    }
}