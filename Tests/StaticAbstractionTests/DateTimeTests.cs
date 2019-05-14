using System;
using StaticAbstraction;
using NUnit.Framework;

namespace StaticAbstractionTests
{
    [TestFixture]
    public class DateTimeTests
    {
        private IDateTime _dt;
        private DateTime _start = DateTime.MinValue;
        private DateTime _startUtc =DateTime.MinValue;

        [SetUp]
        public void Setup()
        {
            _dt = new StAbDateTime();
            _start = DateTime.Now;
            _startUtc = _start.ToUniversalTime();
        }

        [Test]
        public void MaxValue_test()
        {
            Assert.AreEqual(DateTime.MaxValue, _dt.MaxValue);
        }

        [Test]
        public void MinValue_test()
        {
            Assert.AreEqual(DateTime.MinValue, _dt.MinValue);
        }

        [Test]
        public void Now_test()
        {
            DateTime before = DateTime.Now;
            DateTime compare = _dt.Now;
            DateTime after = DateTime.Now;

            Assert.IsTrue(before <= compare);
            Assert.IsTrue(compare <= after);
        }

        [Test]
        public void UtcNow_test()
        {
            DateTime before = DateTime.UtcNow;
            DateTime compare = _dt.UtcNow;
            DateTime after = DateTime.UtcNow;

            Assert.IsTrue(before <= compare);
            Assert.IsTrue(compare <= after);
        }


        [Test]
        public void LeapYear_test()
        {
            for (int year = 1850; year < 2050; year++)
            {
                Assert.AreEqual(DateTime.IsLeapYear(year), _dt.IsLeapYear(year));
            }
        }

        [Test]
        public void Compare_test()
        {
            DateTime earlier = DateTime.Now.AddMinutes(-60);
            DateTime later = DateTime.Now.AddMinutes(60);

            Assert.AreEqual(DateTime.Compare(earlier, later), _dt.Compare(earlier, later));
            Assert.AreEqual(DateTime.Compare(later, earlier), _dt.Compare(later, earlier));
            Assert.AreEqual(DateTime.Compare(earlier, earlier), _dt.Compare(earlier, earlier));
        }
    }
}

