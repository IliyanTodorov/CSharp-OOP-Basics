﻿using System;

namespace Animals.Models
{
    public class Cat : Animal
    {
        public Cat(string name, string favFood) : base(name, favFood)
        {
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "MEEOW";
        }
    }
}