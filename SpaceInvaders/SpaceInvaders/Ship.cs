using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace SpaceInvaders
{
    class Ship
    {
        //Rectangle defined as display area
        private Rectangle displayArea;
        private int leftBounds;
        private int rightBounds;

        private static readonly int shipHeight = 20;
        private static readonly int shipOffset = 60;


//******ENUM DIRECTION
        public enum Direction
        {
            //ship moves left and right
            Left,
            Right,
        }

//*****SHIP
        public Ship(Rectangle gameplayArea)
        {
            //display area of coords and demensions
            displayArea.Height = shipHeight;
            displayArea.Width = gameplayArea.Width / 15;
            displayArea.X = gameplayArea.Width / 2 - this.displayArea.Width / 2;
            displayArea.Y = gameplayArea.Bottom - 50;

            //intilizing the left and right bounds
            this.leftBounds = gameplayArea.Left;
            this.rightBounds = gameplayArea.Right;
        }

//******MOVE SHIP
        public void moveShip(Direction direction)
        {
            switch(direction)
            {
                    //LEFT
                case Direction.Left:
                    {
                        if (displayArea.X < 100)
                        {
                            displayArea.X = 0;
                        }
                        else
                        {
                            displayArea.X -= shipOffset;
                        }
                        break;
                    }

                    //RIGHT
                case Direction.Right:
                        {
                            if(displayArea.Right >= rightBounds - displayArea.Width)
                            {
                                displayArea.X = rightBounds - displayArea.Width;
                            }
                            else
                            {
                                displayArea.X += shipOffset;
                            }
                            break;
                        }
            }//end switch     
        }//end moveShip


//*******DRAW SHIP
        //Encapsulates a GDI drawing surface
        public void drawShip(Graphics graphics)
        {
            //fill in the ship with the color green
            using (SolidBrush brush = new SolidBrush(Color.Green))
                graphics.FillRectangle(brush, displayArea);
        }


//******RECTANGLE DISPLAY AREA
        public Rectangle DisplayArea
        {
            get
            {
                return displayArea;
            }
        }
    }//end Ship

}//end nameSpace
