﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary;
internal class MiniVan : Car
{
    public MiniVan() { }
    public MiniVan(string name, int maxSpeed, int currentSpeed)
    : base(name, maxSpeed, currentSpeed) { }
    public override void TurboBoost()
    {
        // Minivans have poor turbo capabilities!
        State = EngineStateEnum.EngineDead;
        Console.WriteLine("Eek! Your engine block exploded!");
    }
}
