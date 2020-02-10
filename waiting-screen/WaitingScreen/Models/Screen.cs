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

        public Ball GetBallById(Guid ballId)
        {
            return Balls.FirstOrDefault(x => x.Id == ballId);
        }

        public Ball GetBallByPosition(Point ballPosition)
        {
            return Balls.FirstOrDefault(x => x.Radius.Contains(ballPosition));
        }

        public void RemoveBallById(Guid ballId)
        {
            var selectedBall = GetBallById(ballId);

            Balls.Remove(selectedBall);
        }

        public void RemoveBallByPosition(Point ballPosition)
        {
            var selectedBall = GetBallByPosition(ballPosition);

            Balls.Remove(selectedBall);
        }
    }
}
