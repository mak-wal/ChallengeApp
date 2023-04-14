using NUnit.Framework;
using System;

namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void statisticMax()
        {
            var employee = new Employee("s","d");
            employee.AddGrade(0);
            employee.AddGrade(-1);
            employee.AddGrade(0);
            var statistic = employee.GetStatistics();
            Assert.AreEqual(statistic.Max,0);
        }
        [Test]
        public void statisticMin()
        {
            var employee = new Employee("s", "d");
            employee.AddGrade(0);
            employee.AddGrade(-1);
            var statistic = employee.GetStatistics();
            Assert.AreEqual(statistic.Min, 0);
        }
        [Test]
        public void statisticAverage()
        {
            var employee = new Employee("s", "d");
            employee.AddGrade(0);
            employee.AddGrade(-1);
            employee.AddGrade(1);
            var statistic = employee.GetStatistics();
            Assert.AreEqual(statistic.Average, 0.5);
        }
        [Test]
        public void statisticAverage2()
        {
            var employee = new Employee("s", "d");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            var statistic = employee.GetStatistics();
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistic.Average, 2));
        }
    }
}