using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Walls
    {
        private char ch;
        private List<Dot> wall = new List<Dot>();

        public Walls(int width, int height, char character)
        {
            ch = character;

            for (int x = 0; x < width; x++)
            {
                Dot gorizontTop = new Dot { x = x, y = 0, character = ch };
                Dot gorizontBottom = new Dot { x = x, y = height - 1, character = ch };
                gorizontTop.Draw();
                gorizontBottom.Draw();
                wall.Add(gorizontTop);
                wall.Add(gorizontBottom);
            }

            for (int y = 1; y < height - 1; y++)
            {
                Dot verticalLeft = new Dot { x = 0, y = y, character = ch };
                Dot verticalRigth = new Dot { x = width - 1, y = y, character = ch };
                verticalLeft.Draw();
                verticalRigth.Draw();
                wall.Add(verticalLeft);
                wall.Add(verticalRigth);
            }
        }

        public virtual bool IsHit(Dot d)
        {
            foreach (var w in wall)
            {
                if (d == w)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
