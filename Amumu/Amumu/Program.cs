using System;
using System.Collections.Generic;
using System.Linq;
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
   public static class Amumu
    {
        // for which champ (ignore these notes)
        public const string ChampName = "Amumu";

        public static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnLoadingComplete;
        }

        private static void OnLoadingComplete(EventArgs args)
        {
            if (Player.Instance.ChampionName != ChampName)
            {
             // champ name confirm (ignore these notes)
                return;
            }
            SpellManager.Initialize();
            ModeManager.Initialize();
            Config.Initialize();

            Drawing.OnDraw += Drawing_OnDraw;
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            Circle.Draw(Color.Red, SpellManager.Q.Range, Player.Instance.Position);
            Circle.Draw(Color.Blue, SpellManager.W.Range, Player.Instance.Position);
            Circle.Draw(Color.Purple, SpellManager.E.Range, Player.Instance.Position);
            Circle.Draw(Color.GreenYellow, SpellManager.R.Range, Player.Instance.Position);
        }
    }
}
