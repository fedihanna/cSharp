using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Bullet
    {
        public Rectangle displayArea;
        private int leftBounds;
        private int rightBounds;

        //specs of the bullet
        private static readonly int bulletHeight = 17;
        private static readonly int bulletWidth = 1;
        private static readonly int bulletOffSet = 50;


        public enum BulletDirection
        {
            //althought the bullet travels in Y direction
            //it must be attached to the ship
           Left,
            Right
        }

//******BULLET
         public Bullet(Rectangle gameplayArea, int shipXPosition)
        { 
             //postion of the bullet when atached to ship
            this.YVelocity = -20; //bullet speed

            displayArea.Height = bulletHeight;
            displayArea.Width = bulletWidth;
            displayArea.Width = gameplayArea.Width / 270;
            displayArea.X = shipXPosition + 50;
            displayArea.Y = gameplayArea.Bottom - 50;

            this.leftBounds = gameplayArea.Left;
            this.rightBounds = gameplayArea.Right;
        }


//******DRAW BULLET
        public void drawBullet(Graphics graphics)
         {
             //fill in the rectangle the color white
             using (SolidBrush brush = new SolidBrush(Color.Yellow))
                 graphics.FillRectangle(brush, displayArea);
         }


//*******MOVE
        public void Move()
        {
            this.displayArea.X += XVelocity;
            this.displayArea.Y += YVelocity;
        }


//******MOVE BULLETS WITH SHIP
        public void moveBulletsWithShip(BulletDirection bullDirection)
        {
         
             switch (bullDirection)
            {
                //LEFT
                case BulletDirection.Left:
                    {
                        if (displayArea.X < 100)
                        {
                            displayArea.X = 0;
                        }
                        else
                        {
                            displayArea.X -= bulletOffSet;
                        }
                        break;
                    }

                //RIGHT
                case BulletDirection.Right:
                    {
                        if (displayArea.Right >= rightBounds - displayArea.Width)
                        {
                            displayArea.X = rightBounds - displayArea.Width;
                        }
                        else
                        {
                            displayArea.X += bulletOffSet;
                        }
                        break;
                    }

            }//end switch            
        }//end moveBulletWithShip


        public int XVelocity
        {
            get;
            set;
        }

        public int YVelocity
        {
            get;
            set;
        }
     }  
}

   


