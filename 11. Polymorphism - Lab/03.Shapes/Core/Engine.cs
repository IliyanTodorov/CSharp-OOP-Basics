﻿using System;
using Shapes.Models;

namespace Operations.Core
{
    public class Engine
    {
        public void Run()
        {
            Shape rectangle = new Rectangle(12, 4);
            Shape circle = new Circle(29);

            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine(circle.Draw());
        }
    }
}