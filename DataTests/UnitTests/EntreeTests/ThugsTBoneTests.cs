/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {

        [Fact]
        public void ShouldBeAEntree()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tb);
        }


        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal(6.44, tb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal("982", tb.Calories.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Empty(tb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Contains("Thugs T-Bone", tb.ToString());
        }
    }
}