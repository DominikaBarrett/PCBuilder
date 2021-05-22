using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using PCBuilder.Utilities;
using static System.Console;

namespace PCBuilder.Parts
{
    public class PCrunner
    {
        public string name;
        public List<PcPart> components = new();
        public double Price;


        public PCrunner(string setName)
        {
            name = setName;
            Shop shop = new Shop();

            components.Add(shop.RandCpu());
            components.Add(shop.RandPowerSupply());
            components.Add(shop.RandRAM());
            components.Add(shop.RandHeatSink());
            SetPcPrice();
            ShowPc();
        }

        public void ShowPc()
        {
            Utils.PC();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            WriteLine($"Computer name : {name}");
            WriteLine($"Computer price : {Price} zloty");
            WriteLine($"Electrical power bilance : {this.ElectricalPowerBilance()}");
            WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            ResetColor();

            foreach (PcPart part in components)
            {
                if (part is CPU cpuPart)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"CPU name : {cpuPart.PartName}");
                    WriteLine($"CPU Electrical power: {cpuPart.ElectricalPower}");
                    WriteLine($"CPU thermal power : {cpuPart.ThermalPower}");
                    WriteLine($"CPU price: {cpuPart.Price}");
                    ResetColor();
                }

                if (part is RAM ramPart)
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine($"Ram name : {ramPart.PartName}");
                    WriteLine($"Ram electrical power : {ramPart.ElectricalPower}");
                    WriteLine($"Ram thermal power : {ramPart.ThermalPower}");
                    WriteLine($"Ramprice : {ramPart.Price}");
                    ResetColor();
                }

                if (part is PowerSupply powerSupplyPart)
                {
                    ForegroundColor = ConsoleColor.Cyan;
                    WriteLine($"Power supply name : {powerSupplyPart.PartName}");
                    WriteLine($"Power supply electrical power : {powerSupplyPart.ElectricalPower}");
                    WriteLine($"Power supply price : {powerSupplyPart.Price} zloty");
                    ResetColor();
                }

                if (part is HeatSink heatSinkPart)
                {
                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine($"Heatsink name : {heatSinkPart.PartName}");
                    WriteLine($"Heatsink thermal power : {heatSinkPart.ThermalPower}");
                    WriteLine($"Heatsink price : {heatSinkPart.Price}");
                    ResetColor();
                }
            }

            WriteLine("========================================================");
        }


        private void SetPcPrice()
        {
            double returnPrice = 0;
            foreach (PcPart part in components)
            {
                returnPrice += part.Price;
            }

            Price = returnPrice;
        }

        private int ElectricalPowerBilance()
        {
            int ElectricalBilanceToReturn = 0;

            foreach (PcPart part in components)
            {
                if (part is CPU cpuPart)
                {
                    ElectricalBilanceToReturn += cpuPart.ElectricalPower;
                }

                if (part is RAM ramPart)
                {
                    ElectricalBilanceToReturn += ramPart.ElectricalPower;
                }

                if (part is PowerSupply powerSupplyPart)
                {
                    ElectricalBilanceToReturn += powerSupplyPart.ElectricalPower;
                }
            }

            return ElectricalBilanceToReturn;
        }
    }
}