using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uspadtask
{
    public abstract class Animal
    {
        public float Weight { get; set; }
        public string Color { get; set; }
        public Animal(string color, float weight)
        {
            Weight = weight;
            Color = color;
        }
        public abstract string MakeSound();
    }
    public class AnimalWithTail : Animal
    {
        override public string MakeSound()
        {
            return "";
        }
        public float TailLength { get; set; }
        public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
        {
            TailLength = tailLength;
        }
        public AnimalWithTail(string color, float weight) : base(color, weight)
        {
            color = "black";
            weight = 2;
        }

    }
    public class Dog : AnimalWithTail
    {
        public override string MakeSound() { return "GHAAFF!!!"; }
        public override string ToString() { return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}."; }
        public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength) { }
    }
    public class Cat : AnimalWithTail
{
    private string Purr()
    {
        return "purrrr";
    }
    private string Meow()
    {
        return "Meow";
    }
    public override string MakeSound() { return Purr() + Meow(); }
    public override string ToString() { return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}."; }
    public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength) { }
}
}

