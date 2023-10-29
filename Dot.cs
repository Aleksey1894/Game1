using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public struct Dot
    {
        public int x { get; set; }
        public int y { get; set; }
        public char character { get; set; }

        
        public Dot(int x, int y, char character)
        {
            this.x = x;
            this.y = y;
            this.character = character;
        }



        public static implicit operator Dot((int, int, char) value) =>
            new Dot { x = value.Item1, y = value.Item2, character = value.Item3 };

        public static bool operator ==(Dot a, Dot b) =>
                    (a.x == b.x && a.y == b.y) ? true : false;
        public static bool operator !=(Dot a, Dot b) =>
                (a.x != b.x || a.y != b.y) ? true : false;

        public void Draw()
        {
            DrawDot(character);
        }
        public void Clear()
        {
            DrawDot(' ');
        }
        private void DrawDot(char _character)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(_character);
        }
    }
}
