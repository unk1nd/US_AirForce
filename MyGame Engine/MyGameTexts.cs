﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.DirectX.DirectInput;

#endregion

namespace TheGame
{
    class FrameRate : Text2D
    {
        public FrameRate(Engine_Font font): base(font)
        {
            Position = new Point(700, 0);
            Color = Color.DarkGreen;
            Visible = false;
        }
        public override void Update()
        {
            Text = "FPS: " + Engine_Game.CurrentFrameRate.ToString();

            if (Engine_Keyboard.IsTriggered(Key.F9))
                Visible = !Visible;
        }
    }
}
