using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace testMenu
{
    public class Brick : Control
    {

        public Brick()
        {
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                e.Graphics.DrawImage(Properties.Resources.Brick, i * (Properties.Resources.Brick.Width + 10), 10);
            }



            base.OnPaint(e);
        }

    }

}
