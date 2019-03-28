using System;

namespace Patterns.Creational.Prototype
{
    public sealed class Prototype : ICloneable
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Parameter1 { get; set; }
        public string Parameter2 { get; set; }

        public object Clone()
        {
            // Для складних прототипованих об'єктів це може бути глибоке клонування.
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Parameter1: {Parameter1}, Parameter2: {Parameter2}";
        }
    }
}
