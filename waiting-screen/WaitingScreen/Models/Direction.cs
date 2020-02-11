using System;
using System.Drawing;

namespace WaitingScreen.Models
{
    public struct Direction
    {
        private int _xDirection;
        private int _yDirection;

        public Direction(int xDirection, int yDirection)
        {
            _xDirection = xDirection;
            _yDirection = yDirection;
        }

        public static Direction NewDirection()
        {
            var x = new Random(DateTimeOffset.UtcNow.Second).Next(-10, 10);
            var y = new Random(DateTimeOffset.UtcNow.Millisecond).Next(-10, 10);

            return new Direction(x, y);
        }

        public Point Value => new Point(_xDirection, _yDirection);
    }
}
