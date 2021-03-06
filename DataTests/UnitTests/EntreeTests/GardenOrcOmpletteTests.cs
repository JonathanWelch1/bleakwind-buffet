﻿/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ChangingBroccoliNotifiesProperty()
        {
            var go = new GardenOrcOmelette();

            Assert.PropertyChanged(go, "Broccoli", () =>
            {
                go.Broccoli = false;
            });
            Assert.PropertyChanged(go, "Broccoli", () =>
            {
                go.Broccoli = true;
            });
        }
        [Fact]
        public void ChangingMushroomsNotifiesProperty()
        {
            var go = new GardenOrcOmelette();

            Assert.PropertyChanged(go, "Mushrooms", () =>
            {
                go.Mushrooms = false;
            });
            Assert.PropertyChanged(go, "Mushrooms", () =>
            {
                go.Mushrooms = true;
            });
        }
        [Fact]
        public void ChangingTomatoNotifiesProperty()
        {
            var go = new GardenOrcOmelette();

            Assert.PropertyChanged(go, "Tomato", () =>
            {
                go.Tomato = false;
            });
            Assert.PropertyChanged(go, "Tomato", () =>
            {
                go.Tomato = true;
            });
        }
        [Fact]
        public void ChangingCheddarNotifiesProperty()
        {
            var go = new GardenOrcOmelette();

            Assert.PropertyChanged(go, "Cheddar", () =>
            {
                go.Cheddar = false;
            });
            Assert.PropertyChanged(go, "Cheddar", () =>
            {
                go.Cheddar = true;
            });
        }

        [Fact]
        public void ShouldBeAEntree()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(go);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = true;
            Assert.True(go.Broccoli);
            go.Broccoli = false;
            Assert.False(go.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Mushrooms = true;
            Assert.True(go.Mushrooms);
            go.Mushrooms = false;
            Assert.False(go.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Tomato = true;
            Assert.True(go.Tomato);
            go.Tomato = false;
            Assert.False(go.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Cheddar = true;
            Assert.True(go.Cheddar);
            go.Cheddar = false;
            Assert.False(go.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal(4.57, go.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal("404", go.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = includeBroccoli;
            go.Mushrooms = includeMushrooms;
            go.Cheddar = includeCheddar;
            go.Tomato = includeTomato;
            if (!go.Broccoli && !go.Mushrooms && !go.Cheddar && !go.Tomato)
            {
                Assert.Contains("Hold broccoli", go.SpecialInstructions);
                Assert.Contains("Hold mushrooms", go.SpecialInstructions);
                Assert.Contains("Hold tomato", go.SpecialInstructions);
                Assert.Contains("Hold cheddar", go.SpecialInstructions);
            }
            else Assert.Empty(go.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", go.ToString());
        }
    }
}