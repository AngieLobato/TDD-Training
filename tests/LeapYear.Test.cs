using System;
using System.Globalization;
using NUnit.Framework;

namespace CSharp.Training.Tests
{
    public class KnowLeapYear
    {
        LeapYear IsLeapYear = new LeapYear();

        [TestCase(1997)]
        [TestCase(1998)]
        [TestCase(1999)]
        [TestCase(2001)]
        [TestCase(2002)]
        [TestCase(2003)]
        [TestCase(2005)]
        [TestCase(2006)]
        [TestCase(2007)]
        [TestCase(2009)]
        [TestCase(2010)]
        [TestCase(2011)]
        [TestCase(2013)]
        [TestCase(2014)]
        [TestCase(2015)]
        [TestCase(2017)]
        [TestCase(2018)]
        [TestCase(2019)]
        [TestCase(2021)]
        public void NotLeapYear(int anio)
        {
            Assert.AreEqual(IsLeapYear.LeapYearCalendar(anio), "NoLeapYear", "Incorrect" + anio);
        }

        [TestCase(1996)]
        [TestCase(2000)]
        [TestCase(2004)]
        [TestCase(2008)]
        [TestCase(2016)]
        [TestCase(2012)]
        [TestCase(2020)]
        public void YeaLeapYear(int anio)
        {
            Assert.AreEqual(IsLeapYear.LeapYearCalendar(anio), "LeapYear", "Incorrect" + anio);
        }


        
    }
}
