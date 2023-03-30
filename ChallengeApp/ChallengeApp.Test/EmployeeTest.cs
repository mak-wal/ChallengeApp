using NUnit.Framework;
using System;

namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void WszystkieRÛwneOcenyPracownika()
        {
            //arrange
            Employee probny = new Employee("Ktoú", "Coú");

            //act/execute
            probny.AddGrade(1);
            probny.AddGrade(1);
            probny.AddGrade(1);
            var statystyki = probny.GetStatistics();

            //Assert Spodziewany/zak≥adany wynik testu w stosunku do otrzymanego wyniku
            Assert.AreEqual(statystyki.Max, statystyki.Min);
            Assert.AreEqual(statystyki.Min, statystyki.Max);

        }
        [Test]
        public void WszystkieOcenyZerami()
        {
            //arrange
            Employee probny = new Employee("Ktoú", "Coú");

            //act/execute
            probny.AddGrade(0);
            probny.AddGrade(0);
            probny.AddGrade(0);
            var statystyki = probny.GetStatistics();

            //Assert Spodziewany/zak≥adany wynik testu w stosunku do otrzymanego wyniku
            Assert.AreEqual(statystyki.Max, statystyki.Min);
            Assert.AreEqual(statystyki.Min, statystyki.Max);
            Assert.AreEqual(statystyki.Average, 0);

        }
        [Test]
        public void PoprawnaWartoúÊObliczanejåredniej()
        {
            //arrange
            Employee probny = new Employee("Ktoú", "Coú");

            //act/execute
            probny.AddGrade(2);
            probny.AddGrade(6);
            probny.AddGrade(5);
            var statystyki = probny.GetStatistics();

            //Assert Spodziewany/zak≥adany wynik testu w stosunku do otrzymanego wyniku
            
            Assert.AreEqual(Math.Round( statystyki.Average,2),Math.Round( 4.33,2));
            

        }
        //[Test]
        //public void DoubleMaxValue()
        //{
        //    //arrange
        //    Employee probny = new Employee("Ktoú", "Coú");

        //    //act/execute
        //    probny.AddGrade(double.MaxValue);
        //    probny.AddGrade(1);
        //    probny.AddGrade(1);
        //    var statystyki = probny.GetStatistics();

        //    //Assert Spodziewany/zak≥adany wynik testu w stosunku do otrzymanego wyniku
        //    Assert.
        //    Assert.AreEqual(statystyki.Min, statystyki.Max);

        //}
    }
}