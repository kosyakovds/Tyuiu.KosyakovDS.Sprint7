using System;
using System.Collections.Generic;

namespace Tyuiu.KosyakovDS.Sprint7.Project.V12
{
    public class PersonalComputer
    {
        public string Manufacturer { get; set; } = "";
        public string Processor { get; set; } = "";
        public string Frequency { get; set; } = "";
        public string RAM { get; set; } = "";
        public string HDD { get; set; } = "";
        public string ReleaseDate { get; set; } = "";
    }

    public class Supplier
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Note { get; set; } = "";
    }

    public class DataService
    {
        public double CalculateSum(List<PersonalComputer> pcs, string columnName)
        {
            double sum = 0;

            foreach (var pc in pcs)
            {
                string valueToParse = "";

                if (columnName == "ОЗУ")
                {
                    valueToParse = pc.RAM;
                }
                else if (columnName == "Жёсткий диск")
                {
                    valueToParse = pc.HDD;
                }

                if (double.TryParse(valueToParse, out double val))
                {
                    sum += val;
                }
            }

            return sum;
        }
    
        public string GetStatistics(List<PersonalComputer> pcs, List<Supplier> suppliers)
        {
            string stats = Environment.NewLine;

            List<string> manufacturers = new List<string>();
            foreach (PersonalComputer pc in pcs)
            {
                if (!manufacturers.Contains(pc.Manufacturer))
                {
                    manufacturers.Add(pc.Manufacturer);
                }
            }

            stats += "Всего ПК: " + pcs.Count + Environment.NewLine + Environment.NewLine;
            stats += "Всего поставщиков: " + suppliers.Count + Environment.NewLine + Environment.NewLine;
            stats += "Количество производителей: " + manufacturers.Count;

            return stats;
        }
    }
}