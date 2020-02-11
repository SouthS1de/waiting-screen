using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaitingScreen.ModelAbstractions;

namespace WaitingScreen.Models
{
    public class Ball : IBall
    {
        public Point Location { get; private set; }
        public Size Size { get; private set; }
        public Rectangle Region { get; private set; }
        public Color Color { get; private set; }
        public Direction Direction { get; private set; }

        public Ball(Point location, Size size)
        {
            Location = new Point(location.X - size.Width / 2, location.Y - size.Height / 2);
            Size = size;
            Region = new Rectangle(location, size);
            Color = GetRandomColor();
            Direction = Direction.NewDirection();
        }

        public void ChangeDirection(bool hasToReverseX, bool hasToReverseY)
        {
            var x = Direction.Value.X;
            var y = Direction.Value.Y;

            if (hasToReverseX)
            {
                x = -x;
            }

            if (hasToReverseY)
            {
                y = -y;
            }

            Direction = new Direction(x, y);
        }

        public void Move()
        {
            Location = new Point(Location.X + Direction.Value.X, Location.Y + Direction.Value.Y);
            Region = new Rectangle(Location, Size);
        }

        public bool IsInRadius(Point touchPosition)
        {
            return Region.Contains(touchPosition);
        }

        private Color GetRandomColor()
        {
            var randomValue = new Random();
            var red = randomValue.Next(255);
            var green = randomValue.Next(255);
            var blue = randomValue.Next(255);

           return Color.FromArgb(red, green, blue);
        }
    }
}
