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
        void AddBall(Ball newBall);
        void AddBall(Point newBallLocation);
        Ball GetBallById(Guid ballId);
        void RemoveBallById(Guid ballId);
        Ball GetBallByPosition(Point ballPosition);
        void RemoveBallByPosition(Point ballPosition);
    }
}
