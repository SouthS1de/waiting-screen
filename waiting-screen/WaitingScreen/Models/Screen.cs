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
        public List<Ball> Balls { get; private set; }
        public Rectangle Border { get; private set; }

        public Screen()
        {
            InitiateScreen();

            Balls = new List<Ball>();
            Border = new Rectangle(Location, Size);
        }

        public void AddBall(Ball ball)
        {
            Balls.Add(ball);
        }

        public void AddBall(Point location, Size size)
        {
            var newBall = new Ball(location, size);
            AddBall(newBall);
        }

        public Ball GetBall(Point location)
        {
            return Balls.FirstOrDefault(x => x.Region.Contains(location));
        }

        public void RemoveBall(Point location)
        {
            var selectedBall = GetBall(location);

            if (Balls.Contains(selectedBall))
            {
                Balls.Remove(selectedBall);
            }
        }

        public (bool hasToReverseX, bool hasToReverseY) HasToReverseDirection(Ball ball)
        {
            var hasToReverseX = ball.Location.X < Border.X 
                || ball.Location.X > Border.Size.Width - ball.Region.Width;

            var hasToReverseY =  ball.Location.Y < Border.Y 
                || ball.Location.Y > Border.Size.Height - ball.Region.Height;

            return (hasToReverseX, hasToReverseY);
        }

        private void InitiateScreen()
        {
            BackColor = Color.Black;
            Dock = DockStyle.Fill;
            Location = new Point(0, 0);
            Name = "Screen";
            Size = new Size(984, 661);
            TabIndex = 0;
            TabStop = false;          
        }
    }
}
