namespace PCBuilder.Parts
{
    public class RAM :PcPart
    {
        public int ElectricalPower;
        public int ThermalPower;
        public int Capacity;

        public RAM (string SetPartName, double SetPrice, int SetCapacity, int SetElectricalPower, int SetThhermalPower )
        {
            ElectricalPower = SetElectricalPower;
            PartName = SetPartName;
            Price = SetPrice;
            ThermalPower = SetThhermalPower;
            Capacity = SetCapacity;
        }
    }
}