using System;
using System.Drawing;
using WaitingScreen.Models;

namespace WaitingScreen.ModelAbstractions
{
    public interface IBall
    {
        Point Location { get; }
        Rectangle Radius { get; }
        Color Color { get; }
        Direction Direction { get; }
        void ChangeDirection(bool rotateX, bool rotateY);
        void Move();
        bool IsInRadius(Point touchPosition);
    }
}
