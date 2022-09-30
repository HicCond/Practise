using System.Collections.Generic;
using System.Drawing;

namespace VillageDefense
{
    interface IGameObject
    {
        void Draw(Graphics g);
        bool Colision(int x, int y);
    }
}
