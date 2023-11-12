using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Game1
{
    public class Snake
    {
        private Queue<Dot> snake;
        private Direction direction;        
        private Dot tail;
        private Dot head;
        
        public Snake(int x, int y, int length)
        {
            direction = Direction.RIGHT;
            snake = new Queue<Dot>();
            for (int i = x - length; i < x; i++)
            {
                Dot d = (i, y, '0');
                snake.Enqueue(d);
                d.Draw();
            }
        }
       
        public Dot GetHead() => snake.Last();
        public void Move()
        {
            head = GetNextDot();
            snake.Enqueue(head);
            tail = snake.First();
            snake.Dequeue();
            tail.Clear();
            head.Draw();
            
        }

        public bool Eat(Dot d)
        {
            head = GetNextDot();
            if (head == d)
            {
                snake.Enqueue(head);
                head.Draw();
                return true;
            }
            return false;
        }
        public Dot GetNextDot()
        {
            Dot p = GetHead();
            switch (direction)
            {
                case Direction.LEFT:
                    p.x -= 1;
                    break;
                case Direction.RIGHT:
                    p.x += 1;
                    break;
                case Direction.UP:
                    p.y -= 1;
                    break;
                case Direction.DOWN:
                    p.y += 1;
                    break;
            }
            return p;
        }
        public void Rotation(ConsoleKey key)
        {
            
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (direction != Direction.RIGHT)
                        direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    if (direction != Direction.LEFT)
                        direction = Direction.RIGHT;
                    break;
                case ConsoleKey.UpArrow:
                    if (direction != Direction.DOWN)
                        direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    if (direction != Direction.UP)
                        direction = Direction.DOWN;
                    break;
            }
        }
        public bool IsHit(Dot d)
        {
            for (int i = snake.Count - 2; i > 0; i--)
            {
                if (snake.ElementAt(i) == d)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
