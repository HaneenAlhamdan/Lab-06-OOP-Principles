using System;
using Xunit;
using Lab_06_OOP_Principles;

namespace TestZoo
{
    public class UnitTest1
    {

            Leopard leopard = new Leopard("snoring");
            Dolphin dolphin = new Dolphin("whistling", "Small fishs");
            Panda panda = new Panda("Bleating", "Bamboo canes and mambo");
            Turtle turtle = new Turtle("Hissing", "Meat");
            Hawk hawk = new Hawk(true, "Scream", "Meat", "Yellow");

        [Fact]
        public void F_leopard()
        {
            Assert.Equal($"My sound is {leopard.sound}", leopard.Sound());
        }

        [Fact]
            public void S_leopard()
            {
                Assert.Equal("I can Walk very fast", leopard.CanWalk());
            }

            [Fact]
            public void S_Hawk()
            {
                Assert.Equal($"My beak color is {hawk.beakColor}", hawk.BeakColor());
            }

            [Fact]
            public void F_Panda()
            {
                Assert.Equal("I don't hibernate during winter", panda.Hibernate());
            }

            [Fact]
            public void S_Panda()
            {
                Assert.Equal($" My sound is{panda.sound}", panda.Sound());
            }

            [Fact]
            public void F_Turtle()
            {
                Assert.Equal("I can swim ", turtle.CanSwim());
            }

            [Fact]
            public void S_Turtle()
            {
                Assert.Equal($"{turtle.sound}", turtle.Sound());
            }

            [Fact]
            public void F_Dolphin()
            {
            Assert.Equal($"My sound is {dolphin.sound}", dolphin.Sound());
        }

            [Fact]
            public void S_Dolphin()
            {
            Assert.Equal("I Can Swim", dolphin.CanSwim());
        }

            [Fact]
            public void OverrideMethod()
            {
                Assert.NotEqual("My sound is roarrrrrr", leopard.Sound());
            }

            [Fact]
            public void IsAnimal()
            {
                Assert.True(leopard is Animals);
            }

            [Fact]
            public void Interface_one()
            {
                Assert.Equal("I can swim", leopard.CanSwim());
            }

            [Fact]
            public void Interface_Two()
            {
                Assert.Equal("I can Walk very fast", leopard.CanWalk());
            }
        
    }
}
