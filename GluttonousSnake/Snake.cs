using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;


namespace GluttonousSnake
{
    // Turn Class, 转向性质
    class TurnProperty {
        private int rank = 0;
        private char direction;

        public TurnProperty(char dr) {
            this.direction = dr;
        }

        public int getRank() { return this.rank ; }

        public char getDirection() { return this.direction; } 

        public void next() { this.rank++; }
    }


    // Snake Class, 贪吃蛇
    internal class Snake
    {
        private int square_size = 25, boarder = 3, len = 3, displacement = 25;
        private PictureBox parent_plane;

        private ArrayList body, turns;

        public Snake(PictureBox plane) {
            // 显示界面定义
            this.parent_plane = plane;
            this.body = new ArrayList();
            this.turns = new ArrayList(); // 转向参数

            // Add Head
            Point spt = new Point(plane.Size.Width / 2 - square_size, 
                                  plane.Size.Height / 2);
            body.Add(new BodyPart(this.parent_plane, spt, ColorTranslator.FromHtml("#FF99CC"), 'r'));
            // Add Body Parts
            Size sz = new Size(square_size, square_size);
            for (int i = 1; i < len; i++) {
                spt.X -= square_size;
                body.Add(new BodyPart(this.parent_plane, spt, Color.Pink, 'r')) ;
            }
        }

        // Move Actions
        private void moveWhole() {
            BodyPart nowPart;
            for (int i = 0; i < this.len; i++)
            {
                nowPart = (BodyPart)(body[i]);
                nowPart.Location = moveBlockForward(nowPart.Location, nowPart.moveDirection);
            }
        }

        private Point moveBlockForward(Point loc, char dr) {
            switch (dr) { 
                case 'r':
                    {
                        loc.X += this.displacement;
                        if (loc.X >= this.parent_plane.Width)
                            loc.X = 0;
                        break;
                    }
                case 'l':
                    {
                        loc.X -= this.displacement;
                        if (loc.X < 0)
                            loc.X = this.parent_plane.Width-this.square_size;
                        break;
                    }
                case 'u':
                    {
                        loc.Y -= this.displacement;
                        if (loc.Y < 0)
                            loc.Y = this.parent_plane.Height - this.square_size;
                        break;
                    }
                case 'd':
                    {
                        loc.Y += this.displacement;
                        if (loc.Y >= this.parent_plane.Height)
                            loc.Y = 0;
                        break;
                    }
                    
            }
            return loc;
        }
        private Point moveBlockBackward(Point loc, char dr) { return moveBlockForward(loc, BasicParams.getOpDr(dr)); }


        // Turn Actions //
        private void checkTurns() {
            int nowRank;
            BodyPart nowPart;
            for (int i = 0; i < this.turns.Count;) {
                nowRank = this.getTurnRank((TurnProperty)turns[i]);
                nowPart = (BodyPart)(body[nowRank]);
                nowPart.moveDirection = this.getTurnDirection((TurnProperty)turns[i]);
                if (nowRank == this.len - 1) { this.turns.Remove(turns[i]); }
                else { this.turnNext((TurnProperty)turns[i++]); }
            }
        }

        private char getTurnDirection(TurnProperty t) { return t.getDirection(); }
        private int getTurnRank(TurnProperty t) { return t.getRank(); }
        private void turnNext(TurnProperty t) { t.next(); }
        // add a turn
        public void addTurn(char dr) {
            TurnProperty tp = new TurnProperty(dr);
            this.turns.Add(tp);
        }
        // read head's moving direction
        public char getHeadDirection() {
            BodyPart head = (BodyPart)body[0];
            return head.moveDirection;
        }
        public Point getHeadLoc()
        {
            BodyPart head = (BodyPart)body[0];
            return head.Location;
        }


        // Eat Itself Judgement //
        public bool eatSelf() {
            Point headLoc = getHeadLoc();
            BodyPart nowPart;
            for (int i = 1; i < len; i++) {
                nowPart = (BodyPart)body[i];
                if (headLoc.Equals(nowPart.Location))
                    return true;
            }
            return false;
        }

        // Eat Prey Judgement //
        public bool eatPrey(ArrayList preys) {
            Point headLoc = getHeadLoc();
            foreach (Prey prey in preys) {
                
                if (headLoc.Equals(prey.getLoc()))
                {
                    addBody();
                    prey.generateAccessibleLoc();
                    return true;
                }
            }
            return false;
        }

        // Add a part of body //
        public void addBody() {
            BodyPart tail = (BodyPart)body[len-1];
            body.Add(new BodyPart(this.parent_plane, this.moveBlockBackward(tail.Location, tail.moveDirection), 
                                  Color.Pink, tail.moveDirection));
            len++;
        }

        // actions by timer //
        public void actByTime(ArrayList preys)
        {
            checkTurns();
            moveWhole();
            eatPrey(preys);
            eatSelf();
        }
    }
}
