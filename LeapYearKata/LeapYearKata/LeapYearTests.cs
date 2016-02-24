using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace LeapYearKata
{
    public class LeapYearTests
    {
        [TestCase(2001, false)]
        [TestCase(1996, true)]
        [TestCase(1900, false)]
        [TestCase(2000, true)]
        public void Should_return_true_when_year_is_leap_year(int year, bool isLeapYear)
        {
            var actual = LeapYear.IsLeapYear(year);
            Check.That(actual).IsEqualTo(isLeapYear);
        }
    }
}
