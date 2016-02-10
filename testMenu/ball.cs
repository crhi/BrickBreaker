using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace testMenu
{
    class ball : Control
    {
        public ball()
        {
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {


            e.Graphics.DrawImage(Properties.Resources.balle, 10, 10);

            base.OnPaint(e);
        }
    }

}
