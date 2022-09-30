using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageDefense.Engine
{
    class GameOver
    {
        static public bool isGameOver = false;
        static public void DrawGameOverScreen(Graphics g)
        {
            g.DrawString($"GAME OVER \n Time: { Convert.ToInt32(Time.GetMinutes())}:{Time.GetSeconds()}", new Font("Stencil", 25),
                new SolidBrush(Color.Red), Render.Resolution.X / 2 - 100, Render.Resolution.Y / 2 - 100);

            g.DrawString("made by Mykyta Zaborovskyi", new Font("Times New Roman", 10),
                new SolidBrush(Color.Red), Render.Resolution.X / 2 - 83, Render.Resolution.Y / 2 + 165);
        }
    }
}
