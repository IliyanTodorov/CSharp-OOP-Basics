﻿using System;
using Vehicles.Core;

namespace Vehicles
{
    public class StartUp
    {
        static void Main()
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
