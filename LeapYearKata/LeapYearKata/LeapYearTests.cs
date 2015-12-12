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
        [Test]
        public void Should_return_false_when_year_is_a_common_year()
        {
            var actual = LeapYear.IsLeapYear(2001);
            Check.That(actual).IsFalse();
        }
    }

    public class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            return false;
        }
    }
}
