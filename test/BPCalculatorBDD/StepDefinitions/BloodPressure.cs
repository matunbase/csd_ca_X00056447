// using NUnit.Framework;
using BPCalculator;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using FluentAssertions;
using System;
using System.Linq;


namespace BPCalculatorBDD.StepDefinitions
{
    [Binding]
    public class BloodPressure
    {
        // [SetUp]
        private readonly IBloodPressure _bp;

        public void Setup()
        {

        }
        public BPCalculator.BloodPressure()
        {
            _bp = new BPCalculator.BloodPressure();
        }

        [Given(@"Diastolic number is 50 and 80")]
        //[When(@"user presses Sumbit")]
        //[Then(@"the screen should display ‘Low blood Pressure’")]
        public void AuthenticateLowBP()
        {
            BloodPressure bloodPressure = _bp.CreateBloodPressure(50, 79);
            bloodPressure.Category.Should().Be(BPCategory.Low);
        }

        // [Test]
        // public void AuthenticateIdealBP()
        // {
        //     BloodPressure bloodPressure = new() { Diastolic = 75, Systolic = 100 };
        //     Assert.AreEqual(BPCategory.Ideal, bloodPressure.Category);
        // }

        // [Test]
        // public void AuthenticatePreHighBP()
        // {
        //     BloodPressure bloodPressure = new() { Diastolic = 86, Systolic = 138 };
        //     Assert.AreEqual(BPCategory.PreHigh, bloodPressure.Category);
        // }

        // [Test]
        // public void AuthenticateHighBP()
        // {
        //     BloodPressure bloodPressure = new() { Diastolic = 92, Systolic = 159 };
        //     Assert.AreEqual(BPCategory.High, bloodPressure.Category);
        // }

    }
}
