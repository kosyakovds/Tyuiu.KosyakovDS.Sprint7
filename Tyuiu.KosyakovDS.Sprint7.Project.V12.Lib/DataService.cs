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
        public double GetValidDouble(object cellValue)
        {
            return Convert.ToDouble(cellValue.ToString().Replace(".", ","));
        }

        public int CalculateCount(List<PersonalComputer> pcs, string columnName)
        {
            int count = 0;
            string selectedCol = columnName.Trim();

            foreach (var pc in pcs)
            {
                string valueToParse = "";

                if (selectedCol == "ОЗУ")
                {
                    valueToParse = pc.RAM;
                }
                else if (selectedCol == "Жёсткий диск")
                {
                    valueToParse = pc.HDD;
                }

                if (double.TryParse(valueToParse.Replace(".", ","), out _))
                {
                    count++;
                }
            }
            return count;
        }

        public double CalculateMax(List<PersonalComputer> pcs, string columnName)
        {
            if (pcs.Count == 0) return 0;

            double max = double.MinValue;

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

                if (double.TryParse(valueToParse.Replace(".", ","), out double val))
                {
                    if (val > max) max = val;
                }
            }
            if (max == double.MinValue)
            {
                return 0;
            }
            else
            {
                return max;
            }
        }

        public double CalculateMin(List<PersonalComputer> pcs, string columnName)
        {
            if (pcs.Count == 0) return 0;

            double min = double.MaxValue;
            string selectedCol = columnName.Trim();

            foreach (var pc in pcs)
            {
                string valueToParse = "";

                if (selectedCol == "ОЗУ")
                {
                    valueToParse = pc.RAM;
                }
                else if (selectedCol == "Жёсткий диск")
                {
                    valueToParse = pc.HDD;
                }

                if (double.TryParse(valueToParse.Replace(".", ","), out double val))
                {
                    if (val < min) min = val;
                }
            }
            if (min == double.MaxValue)
            {
                return 0;
            }
            else
            {
                return min;
            }
        }

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

                if (double.TryParse(valueToParse.Replace(".", ","), out double val))
                {
                    sum += val;
                }
            }

            return sum;
        }

        public double CalculateAverage(List<PersonalComputer> pcs, string columnName)
        {
            if (pcs.Count == 0) return 0;

            double sum = 0;
            int count = 0;

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

                if (double.TryParse(valueToParse.Replace(".", ","), out double val))
                {
                    sum += val;
                    count++;
                }
            }

            return count > 0 ? sum / count : 0;
        }
    }
}