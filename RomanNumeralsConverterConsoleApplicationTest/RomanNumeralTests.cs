using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;
using System;
using RomanNumeralsConverterConsoleApplication;

namespace RomanNumeralsConverterConsoleApplicationTests 
{
    public class RomanNumeralTests
    {
        private RomanNumeralsConverter RomanNumeralsConverter;

        [SetUp]
        public void Setup()
        {
            RomanNumeralsConverter = new RomanNumeralsConverter(null);
        }

        [Test]
        public void Roman_Number_I_Should_Return_1()
        {
            RomanNumeralsConverter.ConvertRomanNumber("I").Should().Be(1);

        }

        [Test]

        public void Roman_Number_IV_Should_Return_4()
        { 
            RomanNumeralsConverter.ConvertRomanNumber("IV").Should().Be(4); 
        }

        [Test]

        public void Roman_Number_V_Should_Return_5()
        {
            RomanNumeralsConverter.ConvertRomanNumber("V").Should().Be(5);
        }

        [Test]

        public void Roman_Number_VII_Should_Return_7()
        {
            RomanNumeralsConverter.ConvertRomanNumber("VII").Should().Be(7);
        }

        [Test]

        public void Roman_Number_X_Should_Return_10()
        {
            RomanNumeralsConverter.ConvertRomanNumber("X").Should().Be(10);
        }

        [Test]

        public void Roman_Number_XL_Should_Return_40()
        {
            RomanNumeralsConverter.ConvertRomanNumber("XL").Should().Be(40);
        }

        [Test]

        public void Roman_Number_L_Should_Return_50()
        {
            RomanNumeralsConverter.ConvertRomanNumber("L").Should().Be(50);
        }

        [Test]

        public void Roman_Number_XCIX_Should_Return_99()
        {
            RomanNumeralsConverter.ConvertRomanNumber("XCIX").Should().Be(99);
        }

        [Test]

        public void Roman_Number_C_Should_Return_100()
        {
            RomanNumeralsConverter.ConvertRomanNumber("C").Should().Be(100);
        }

        [Test]

        public void Roman_Number_CD_Should_Return_400()
        {
            RomanNumeralsConverter.ConvertRomanNumber("CD").Should().Be(400);
        }

        [Test]

        public void Roman_Number_DCCC_Should_Return_800()
        {
            RomanNumeralsConverter.ConvertRomanNumber("DCCC").Should().Be(800);
        }

        [Test]

        public void Roman_Number_M_Should_Return_1000()
        {
            RomanNumeralsConverter.ConvertRomanNumber("M").Should().Be(1000);
        }

        [Test]

        public void Roman_Number_null_Should_Return_ArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => RomanNumeralsConverter.ConvertRomanNumber(""));
            Assert.That(ex.Message, Is.EqualTo("Roman number can't be null"));
        }

        [Test]

        public void Roman_Number_Invalid_Should_Return_ArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => RomanNumeralsConverter.ConvertRomanNumber("adfj"));
            Assert.That(ex.Message, Is.EqualTo("Please enter a valid Roman number"));
        }
    }
}