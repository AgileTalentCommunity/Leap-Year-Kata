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

        [Test]
        public void Should_return_true_when_year_is_a_typical_leap_year()
        {
            var actual = LeapYear.IsLeapYear(1996);
            Check.That(actual).IsTrue();
        }

        [Test]
        public void Should_return_false_when_year_is_an_atypical_common_year()
        {
            var actual = LeapYear.IsLeapYear(1900);
            Check.That(actual).IsFalse();
        }

        [Test]
        public void Should_return_true_when_year_is_an_atypical_leap_year()
        {
            var actual = LeapYear.IsLeapYear(2000);
            Check.That(actual).IsTrue();
        }
    }
}
