using System;

namespace HeroPerk
{
    [Flags]
    enum Perks
    {

        WarpShift = 1 << 1,
        Stealth = 1 << 2,
        AutoHeal = 1 << 3,
        DoubleJump = 1 << 4,
    }
}
