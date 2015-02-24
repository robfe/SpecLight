using System;
using System.Globalization;
using System.Threading;
using SpecLight.Infrastructure;
using Xunit;

namespace SpecLight.Tests
{
    public class StringHelpersTests
    {
        [Fact]
        public void ValuesAreOneWord()
        {
            Assert.Equal("the US is one word", StringHelpers.CreateText(((Action<string>)The_IsOneWord).Method, new object []{"US"}));
        }

        [Fact]
        public void ShouldTrueGetsReplaced()
        {
            Assert.Equal("shan't", StringHelpers.CreateText(((Action<bool>)Shall_).Method, new object []{false}));
            Assert.Equal("I shouldn't see the light", StringHelpers.CreateText(((Action<bool>)IShould_SeeTheLight).Method, new object []{false}));
        }

        [Fact]
        public void ParameterNameGetsUsed()
        {
            Assert.Equal("the thing passes", StringHelpers.CreateText(((Action<bool>)TheThing_).Method, new object []{true}));
            Assert.Equal("the thing fails really badly", StringHelpers.CreateText(((Action<bool>)TheThing_).Method, new object []{false}));

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Assert.Equal("the date parameters 1/1/0001 12:00 AM Monday", StringHelpers.CreateText(((Action<DateTime, DateTime, DateTime>)TheDateParameters___).Method, new object []{new DateTime(), new DateTime(), new DateTime()}));
        }

        [Fact]
        public void NullIsOk()
        {
            Assert.Equal("the <null> is one word", StringHelpers.CreateText(((Action<string>)The_IsOneWord).Method, new object[] { null }));
        }

        [Fact]
        public void ArraysGetFormatted()
        {
            Assert.Equal("takes an array [one, two]", StringHelpers.CreateText(((Action<string[]>)TakesAnArray_).Method, new object[] { new string[]{"one, two"} }));
        }

        void The_IsOneWord(string s)
        {
        }

        private void Shall_(bool b)
        {
        }

        private void IShould_SeeTheLight(bool b)
        {
        }

        private void TheThing_(bool passesOrFailsReallyBadly)
        {
        }

        private void TheDateParameters___(DateTime date, DateTime time, DateTime day)
        {
        }

        private void TakesAnArray_(string[] array)
        {
            
        }
    }
}
