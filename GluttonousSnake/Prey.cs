using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace GluttonousSnake
{
    // Prey Class, 猎物   
    internal class Prey: PictureBox
    {   
        private int square_size = 25;

        private PictureBox parent_plane;
        private int x_range, y_range; 

        private Random generator = new Random();

        public Prey(PictureBox plane) {
            this.parent_plane = plane;
            this.x_range = this.parent_plane.Width / square_size;
            this.y_range = this.parent_plane.Height / square_size;
            generateAccessibleLoc();
            this.Size = new Size(square_size, square_size);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ImageLocation = @"bird.PNG";
            this.parent_plane.Controls.Add(this);
        }

        public Point getLoc() { return this.Location; }

        public void generateAccessibleLoc() {
            bool accessible = false;
            while (!accessible) {
                randInit();
                foreach (Control item in this.parent_plane.Controls)
                    if (item.GetType().ToString() == "GluttonousSnake.BodyPart")
                        if (item.Location.Equals(this.Location))
                        {
                            accessible = false;
                            break;
                        }
                        else
                        {
                            accessible = true;
                        }
            }
        }

        private void randInit() {
            Thread.Sleep(50);
            this.Location =  new Point(generator.Next(0, x_range - 1) * square_size,
                                    generator.Next(0, y_range - 1) * square_size);
        }

        
    }
}
