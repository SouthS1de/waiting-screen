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
        public Rectangle Radius { get; private set; }
        public Color Color { get; private set; }
        public Direction Direction { get; private set; }

        public Ball(Point location)
        {
            Location = new Point(location.X - 32, location.Y - 32);
            Radius = new Rectangle(location.X, location.Y, 64, 64);
            Color = GetRandomColor();
            Direction = Direction.NewDirection();
        }

        public void ChangeDirection(bool rotateX, bool rotateY)
        {
            var reverseX = 0;
            var reverseY = 0;

            if (rotateX)
            {
                reverseX = -Direction.Value.X;
            }

            if (rotateY)
            {
                reverseY = -Direction.Value.Y;
            }

            Direction = new Direction(reverseX, reverseY);
        }

        public void Move()
        {
            Location = new Point(Location.X + Direction.Value.X, Location.Y + Direction.Value.Y);
            Radius = new Rectangle(Location.X, Location.Y, 64, 64);
        }

        public bool IsInRadius(Point touchPosition)
        {
            return Radius.Contains(touchPosition);
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
