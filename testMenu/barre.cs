using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace testMenu
{
    public class barre : Control
    {
        public barre()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {

            
            e.Graphics.DrawImage(Properties.Resources.barre, 10, 10);

            base.OnPaint(e);
        }
    }
}
