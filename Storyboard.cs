using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Storyboard : StoryboardObjectGenerator
    {

        public static int BeatDuration = 14119 - 13690;

        public override void Generate()
        {
            intro();
		    background();
            kiai();
        }

        public void intro() {
            var blue_bg = GetLayer("intro_bg").CreateSprite("sb/bg/ew.jpg", OsbOrigin.Centre);
            blue_bg.Fade(-500, -23, 0, 1);
            blue_bg.Scale(-500, 11976, 0.445, 0.6);
            blue_bg.Fade(9833, 11976, 1, 0);
        }

        public void background() {
            var bg = GetLayer("bg").CreateSprite(Beatmap.BackgroundPath, OsbOrigin.Centre);
            bg.Fade(0,0);
            bg.Scale(0,0.58);
            bg.Fade(54834, 1);
            bg.Fade(82210, 0);

            var girl = GetLayer("girl_foreground").CreateSprite("sb/bg/girl.png", OsbOrigin.Centre);
            girl.Scale(54834,0.58);
            girl.Fade(54834, 1);
            girl.Fade(82210, 0);
        }

        public void kiai() {
            var white = GetLayer("kiai_flashes").CreateSprite("sb/etc/p.png", OsbOrigin.Centre);
            white.Scale(54834, 1000);
            white.Additive(54834, 82262);
            white.StartLoopGroup(54834, 14);
            white.Fade(0, 857, 0.4, 0);
            white.EndGroup();

            white.StartLoopGroup(68548, 14);
            white.Fade(0, 857, 0.4, 0);
            white.EndGroup();
        }
    }
}
