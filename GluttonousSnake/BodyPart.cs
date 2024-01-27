using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GluttonousSnake
{
    internal class BodyPart: PictureBox
    {
        private Control parent_plane;
        private int square_size = 25;
        public char moveDirection;
        
        public BodyPart(Control plane, Point loc, Color col, char dr) {
            this.parent_plane = plane;
            this.moveDirection = dr;
            this.Location = loc;
            this.Size = new Size(square_size, square_size);
            this.BackColor = col;
            this.parent_plane.Controls.Add(this);
        }

    }
}
