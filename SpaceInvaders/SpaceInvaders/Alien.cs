using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace SpaceInvaders
{
    public class Alien
    {
        public Rectangle displayArea;

        private Color randomColor;

        private static readonly Random random = new Random();


//******ALIEN
        public Alien(Rectangle gameplayArea, int alienPosition)
        {
            //generating the aliens with random colors
            //with velocity of 20
            //hieght and width ar 20
            Random random = new Random();

            XVelocity =  20;

            displayArea.Height = 20;
            displayArea.Width = 20;

            displayArea.X = (gameplayArea.Width / 2 - this.displayArea.Width / 2) + alienPosition;
            displayArea.Y = 20;

            randomColor = GetRandomColor();
        }

//*******MOVE ALIEN
        public void moveAlien()
        {
            displayArea.X += XVelocity;
            displayArea.Y += YVelocity;
        }

//******WALL COLLISION
        public bool CheckWallCollide(Rectangle gameplayArea)
        {
            //if the alien is at the furtherst right position on the screen
            //made -30 because I do not want it to go all the way to the edge
            if (displayArea.X + displayArea.Width >= gameplayArea.Width - 30)
            {
                return true;
            }
                //if the alien is at the furtherst left position
            else if(displayArea.X <= 30)
            {
                return true;
            }
            return false;
        }

//******DRAW ALIEN
        public void drawAlien(Graphics graphics)
        {
            //drawing aliens 
            //calling on "SolidBrush"
            using (SolidBrush brush = new SolidBrush(randomColor))
            {
                graphics.FillRectangle(brush, displayArea);
            }
        }

//*********MOVE DOWN
        public void MoveDown(int y)
        {
            //displaying aliens in upper left corner and includes "y" parameter
            this.displayArea.Y = this.displayArea.Y + y;
        }

//*******X VELOCITY
        public int XVelocity { get; set; }
        public int YVelocity { get; set; }
       
       

//********RANDOM COLOR
        private Color GetRandomColor()
        {
            //returns random colors using 32 bit integers
            return Color.FromArgb(255, random.Next(255), random.Next(255), random.Next(255));
        }
    }

    
}
