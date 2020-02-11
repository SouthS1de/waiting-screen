using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaitingScreen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _timer.Start();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            foreach (var ball in _screen.Balls)
            {
                var hasToReverse = _screen.HasToReverseDirection(ball);

                if (hasToReverse.hasToReverseX || hasToReverse.hasToReverseY)
                {
                    ball.ChangeDirection(hasToReverse.hasToReverseX, hasToReverse.hasToReverseY);
                }

                ball.Move();

                e.Graphics.DrawEllipse(new Pen(ball.Color), ball.Region);
            }
        }

        private void OnTick(object sender, EventArgs e)
        {
            _screen.Refresh();
        }

        private void OnClick(object sender, MouseEventArgs e)
        {
            var ballSize = new Size(64, 64);

            _screen.AddBall(e.Location, ballSize);
        }

        private void OnDoubleClick(object sender, MouseEventArgs e)
        {
            _screen.RemoveBall(e.Location);
        }
    }
}
