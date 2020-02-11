using System;
using System.Collections.Generic;
using System.Drawing;
using WaitingScreen.Models;

namespace WaitingScreen.ModelAbstractions
{
    public interface IScreen
    {
        List<Ball> Balls { get; }
        Rectangle Border { get; }
        void AddBall(Ball ball);
        void AddBall(Point location, Size size);
        Ball GetBall(Point location);
        void RemoveBall(Point location);
        (bool hasToReverseX, bool hasToReverseY) HasToReverseDirection(Ball ball);
    }
}
