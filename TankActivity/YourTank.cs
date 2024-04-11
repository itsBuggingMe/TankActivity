using TANKS_;
using System;
using System.Linq;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
namespace TankActivity;
//^ Do not change using statements ^

internal class Example_Tank : Tank
{
    protected override void Initalize()
    {
        TankColor = TankColor.Blue;
        Weapon = Weapon.Double;
    }

    protected override void Update(Tank[] otherTanks)
    {

    }
}