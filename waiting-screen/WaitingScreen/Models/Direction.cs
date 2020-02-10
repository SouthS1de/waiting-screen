using System;
using System.Drawing;

namespace WaitingScreen.Models
{
    public struct Direction
    {
        private int _xDirection;
        private int _yDirection;

        private Direction(int xDirection, int yDirection)
        {
            _xDirection = xDirection;
            _yDirection = yDirection;
        }

        public static Direction NewDirection()
        {
            var x = new Random(DateTimeOffset.UtcNow.Millisecond).Next(-1, 1);
            var y = new Random(DateTimeOffset.UtcNow.Millisecond).Next(-1, 1);

            return new Direction(x, y);
        }

        public Point Value => new Point(_xDirection, _yDirection);
    }
}
