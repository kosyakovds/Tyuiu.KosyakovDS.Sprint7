using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tyuiu.KosyakovDS.Sprint7.Project.V12;

namespace Tyuiu.KosyakovDS.Sprint7.Project.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateSum()
        {
            DataService ds = new DataService();

            List<PersonalComputer> pcs = new List<PersonalComputer>
            {
                new PersonalComputer { RAM = "8", HDD = "256" },
                new PersonalComputer { RAM = "16", HDD = "512" }
            };

            double res = ds.CalculateSum(pcs, "ОЗУ");
            double wait = 24.0;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateAverage()
        {
            DataService ds = new DataService();

            List<PersonalComputer> pcs = new List<PersonalComputer>
            {
                new PersonalComputer { RAM = "4", HDD = "100" },
                new PersonalComputer { RAM = "8", HDD = "300" }
            };

            double res = ds.CalculateAverage(pcs, "Жёсткий диск");
            double wait = 200.0;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateMax()
        {
            DataService ds = new DataService();

            List<PersonalComputer> pcs = new List<PersonalComputer>
            {
                new PersonalComputer { RAM = "4" },
                new PersonalComputer { RAM = "32" },
                new PersonalComputer { RAM = "16" }
            };

            double res = ds.CalculateMax(pcs, "ОЗУ");
            double wait = 32.0;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateMin()
        {
            DataService ds = new DataService();

            List<PersonalComputer> pcs = new List<PersonalComputer>
            {
                new PersonalComputer { HDD = "1024" },
                new PersonalComputer { HDD = "512" },
                new PersonalComputer { HDD = "2048" }
            };

            double res = ds.CalculateMin(pcs, "Жёсткий диск");
            double wait = 512.0;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateCount()
        {
            DataService ds = new DataService();

            List<PersonalComputer> pcs = new List<PersonalComputer>
            {
                new PersonalComputer { RAM = "8" },
                new PersonalComputer { RAM = "не число" },
                new PersonalComputer { RAM = "16" }
            };

            int res = ds.CalculateCount(pcs, "ОЗУ");
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}