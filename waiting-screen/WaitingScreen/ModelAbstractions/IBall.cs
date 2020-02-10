using System;
using System.Drawing;
using WaitingScreen.Models;

namespace WaitingScreen.ModelAbstractions
{
    public interface IBall
    {
        Guid Id { get; }
        Point Location { get; }
        Rectangle Radius { get; }
        Color Color { get; }
        Direction Direction { get; }
        void ChangeDirection();
        void Move();
        bool IsInRadius(Point touchPosition);
    }
}
