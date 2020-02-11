using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaitingScreen.ModelAbstractions;

namespace WaitingScreen.Models
{
    public class Screen : PictureBox, IScreen
    {
        public List<Ball> Balls { get; private set; } = new List<Ball>();
        public Rectangle Border { get; private set; }

        public Screen(int width, int height)
        {
            Border = new Rectangle(0, 0, width, height);
        }

        public void AddBall(Ball newBall)
        {
            Balls.Add(newBall);
        }

        public void AddBall(Point newBallLocation)
        {
            var newBall = new Ball(newBallLocation);
            AddBall(newBall);
        }

        public Ball GetBall(Point ballPosition)
        {
            return Balls.FirstOrDefault(x => x.Radius.Contains(ballPosition));
        }

        public void RemoveBall(Point ballPosition)
        {
            var selectedBall = GetBall(ballPosition);

            if (Balls.Contains(selectedBall))
            {
                Balls.Remove(selectedBall);
            }
        }

        public bool IsValidX(int x)
        {
            return x >= Border.X && x <= Border.Width - 64;
        }

        public bool IsValidY(int y)
        {
            return y >= Border.Y && y <= Border.Height - 64;
        }
    }
}
