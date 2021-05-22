namespace PCBuilder.Parts
{
    public class PowerSupply : PcPart
    {
        public int ElectricalPower;

        public PowerSupply(string SetPartName, double SetPrice, int SetElectricalPower)
        {   
           ElectricalPower = SetElectricalPower;
           PartName = SetPartName;
           Price = SetPrice;
        }
    }
}