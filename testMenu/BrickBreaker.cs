using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace testMenu
{
    public class BrickBreaker : Control
    {

        public BrickBreaker()
        {
            base.DoubleBuffered = true;
            this.Bricks = new List<Point>();
            point();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.balle, BallePosition);
            e.Graphics.DrawImage(Properties.Resources.barre, BarrePosition);
            for (int a = 0; a < 10; a++)
            {

                for (int i = 0; i < 20; i++)
                {

                    e.Graphics.DrawImage(Properties.Resources.Brick, i * (Properties.Resources.Brick.Width + 5), a * Properties.Resources.Brick.Height);

                    base.OnPaint(e);
                }
            }
        }

        public Point BallePosition = new Point(200, 350);
        public Point BarrePosition = new Point(350, 535);

        List<Point> Bricks;
        private void point()
        {
            for (int a = 0; a < 10; a++)
            {
                for (int i = 0; i < 20; i++)
                {
                    Point BrickPosition = new Point(i * Properties.Resources.Brick.Width, a * Properties.Resources.Brick.Height);
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
                {
                    case Keys.Right:
                        {

                            this.BarrePosition.X += 10;
                            this.Invalidate();
                            break;
                        }

                    case Keys.Left:
                        {
                            this.BarrePosition.X -= 10;
                            this.Invalidate();
                            break;
                        }

                    default:
                        break;

                }


            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
