using System;
using static System.Console;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using PCBuilder.Parts;
using Utils = PCBuilder.Utilities.Utils;

namespace PCBuilder
{
    public class Shop
    {
        public List<CPU> CpuList = new();
        public List<RAM> RamList = new();
        public List<PowerSupply> PowersSupplyList = new();
        public List<HeatSink> HeatSinkList = new();
        public Random randComp = new ();


        public Shop()
        {
            Utils.Start();
            AddCpuToList();
            AddHeatSinkToList();
            AddPowerSupplyToList();
            AddRamToList();
        }

        public CPU RandCpu()
        {
            
            var cpuRandList =randComp.Next(0, CpuList.Count);
            return CpuList[cpuRandList];
        }

        public RAM RandRAM()
        {
            
            var ramRandList = randComp.Next(0, RamList.Count);
            return RamList[ramRandList];
        }

        public PowerSupply RandPowerSupply()
        {
         
            var psRandList = randComp.Next(0, PowersSupplyList.Count);
            return PowersSupplyList[psRandList];
        }

        public HeatSink RandHeatSink()
        {
            
            var heatSinkRand = randComp.Next(0, HeatSinkList.Count);
            return HeatSinkList[heatSinkRand];
        }


        private void AddCpuToList()
        {
            CpuList.Add(new CPU("Intel", 350.00, -80, 80));
            CpuList.Add(new CPU("ADM", 420.00, -90, 95));
            CpuList.Add(new CPU("Different CPU", 500.00, -100, 105));
        }

        private void AddRamToList()
        {
            //Name, Price, Capacity, ElectricalPower, ThermalPower
            RamList.Add(new RAM("Crucial", 90.00, 8, -5, 3));
            RamList.Add(new RAM("HyperX", 100.00, 8, -5, 3));
            RamList.Add(new RAM("G.SKILL", 120.00, 8, -5, 3));
        }

        private void AddPowerSupplyToList()
        {
            PowersSupplyList.Add(new PowerSupply("Power Supply1", 90.00, 350));
            PowersSupplyList.Add(new PowerSupply("Power Supply2", 120.00, 400));
            PowersSupplyList.Add(new PowerSupply("Power Supply3", 180.00, 450));
        }

        private void AddHeatSinkToList()
        {
            HeatSinkList.Add(new HeatSink("HeatSink 1", 100, -100));
            HeatSinkList.Add(new HeatSink("HeatSink 2", 120, -120));
            HeatSinkList.Add(new HeatSink("HeatSink 3", 140, -140));
        }

    }
}