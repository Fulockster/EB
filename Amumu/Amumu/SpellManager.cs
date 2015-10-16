using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using EloBuddy.SDK.Rendering;
using SharpDX;

namespace Amumu
{
   public static class SpellManager
    {
        // Spellz type
        public static Spell.Skillshot Q { get; private set; }
        public static Spell.Active W { get; private set; }
        public static Spell.Active E { get; private set; }
        public static Spell.Active R { get; private set; }


        static SpellManager()
        {
            Q = new Spell.Skillshot(SpellSlot.Q, 1070, SkillShotType.Linear, 250, 2000, 85);
            W = new Spell.Active(SpellSlot.W, 295);
            E = new Spell.Active(SpellSlot.E, 330);
            R = new Spell.Active(SpellSlot.R, 528);
            

        }

        public static void Initialize()
        {
            // For initializer to do the job -Hellsing
        }
    }
}
