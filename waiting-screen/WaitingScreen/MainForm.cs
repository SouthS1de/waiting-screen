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
                var rotateX = !_screen.IsValidX(ball.Location.X);
                var rotateY = !_screen.IsValidY(ball.Location.Y);

                if (rotateX || rotateY)
                {
                    ball.ChangeDirection(rotateX, rotateY);
                }

                ball.Move();

                e.Graphics.DrawEllipse(new Pen(ball.Color), ball.Radius);
            }
        }

        private void OnTick(object sender, EventArgs e)
        {
            _screen.Refresh();
        }

        private void OnClick(object sender, MouseEventArgs e)
        {
            _screen.AddBall(e.Location);
        }

        private void OnDoubleClick(object sender, MouseEventArgs e)
        {
            _screen.RemoveBall(e.Location);
        }
    }
}
