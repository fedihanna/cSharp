using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        Ship ship;
        HashSet<Bullet> bullets = new HashSet<Bullet>();
        List<Alien> aliens = new List<Alien>();
        Rectangle bulletDisplay = new Rectangle(0, 0, 400, 400);
        int aliensDead = 0;
        int tickCount = 0;
        int maxTicks = 5;

        private bool gameOver = false;

        //*****INITIALIZE
        public Form1()
        {
            InitializeComponent();
            LoadAliens();
            animationTimer.Start();
        }


        //******ADJUST WINDOW TO FIT SCREEN
        private void FitScreen()
        {
            this.WindowState = FormWindowState.Maximized;
        }


        //******FORM PAINT
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //using the PaintEventArgs with Graphics
            ship.drawShip(e.Graphics);
            foreach (Bullet bullet in bullets)
            {
                bullet.drawBullet(e.Graphics);
            }

            foreach (Alien alien in aliens)
            {
                alien.drawAlien(e.Graphics);
            }

//********TRYIING TO DISPLAY IMAGES (NOT WORKING)
            
            //Image image = Image.FromFile("alienOne.jpg");
            //Bitmap bitmap = new Bitmap(image, new Size(420, 262));
            //Point onScreen = new Point(100, 100);
            //e.Graphics.DrawImage(bitmap, onScreen);

            //using IMPACT font size 16 (white)
            //to display bullet shot score
            //display aliens dead score
            Font drawFont = new Font("Impact", 20);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            e.Graphics.DrawString(String.Format(" Bullets Shot: {0}\n ", bullets.Count.ToString()), drawFont, drawBrush, 0, 0);
            e.Graphics.DrawString(String.Format("\n Aliens Dead: {0}\n", aliensDead), drawFont, drawBrush, 0, 0);


            //game over display
            if (gameOver)
            {

                animationTimer.Stop();
                e.Graphics.DrawString("Game Over", drawFont, drawBrush,
                    this.DisplayRectangle.Width / 2,
                    this.DisplayRectangle.Height / 3);

                e.Graphics.DrawString("Press Space To Play Again", drawFont, drawBrush,
                   this.DisplayRectangle.Width / 2,
                   this.DisplayRectangle.Height / 2);
            }
        }



        //*********KEY DOWN
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData.ToString())
            {
                case "Left":
                    {
                        if (animationTimer.Enabled)
                            ship.moveShip(Ship.Direction.Left);
                        break;
                    }

                case "Right":
                    {
                        if (animationTimer.Enabled)
                            ship.moveShip(Ship.Direction.Right);
                        break;
                    }

                case "Space":
                    {
                        if (!gameOver)
                        {
                            if (animationTimer.Enabled)
                                shootBullets();
                            // LoadAliens();                                                  
                        }

                        else
                        {
                            ResetGame();
                        }
                        break;
                    }
            }
        }


//********RESET GAME
        public void ResetGame()
        {
             bullets = new HashSet<Bullet>();
             aliens = new List<Alien>();
             aliensDead = 0;
             gameOver = false;

             LoadAliens();
             animationTimer.Start();
        }

        //******FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {

            //PictureBox pb1 = new PictureBox();
            //pb1.ImageLocation = @"E:\IT COURSE 2015-16 (PART 4)\PROG 2200 Michael Caines\SpaceInvaders\alienOne.jpg";
            //pb1.SizeMode = PictureBoxSizeMode.AutoSize;

            //the game over dispaly and its location
            Size size = new Size(200, 50);
            Point gameOverMessageArea = new Point((int)(this.DisplayRectangle.Width / 2 - size.Width / 2),
                (int)(this.DisplayRectangle.Height / 2 - size.Height / 2));

            FitScreen();

            //displaying the ship when form loads
            ship = new Ship(this.DisplayRectangle);
        }

        //*******SHOOT BULLETS
        private void shootBullets()
        {
            bullets.Add(new Bullet(this.DisplayRectangle, ship.DisplayArea.X));
        }


        //********LOAD ALIENS
        private void LoadAliens()
        {

            //going through a loop of 40 aliens in each row
            for (int i = 0; i <= 20; i++)
            {
                aliens.Add(new Alien(this.DisplayRectangle, i * 30));
            }
        }


        //*******TIMER
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            //when no more aliens ...game is over
            if (aliens.Count() == 0)
            {
                gameOver = true;
            }

            foreach (Bullet bullet in bullets)
            {
                bullet.Move();
            }


            //tickCount++;

            //if (tickCount > maxTicks)
            //{
                tickCount = 0;
                //x goes through alien count
                //if its greater than 0 
                //display the aliens
                for (int x = 0; (x < aliens.Count()) && aliens.Count() > 0; x++)
                {

                    //when the game is over
                    //we want the aliens to display at this coord 
                    //so the game can start again
                    if (aliens[x].displayArea.Y > this.DisplayRectangle.Height - 65)
                    {
                        gameOver = true;
                        break;
                    }
                    foreach (Bullet bullet in bullets)
                    {
                        //*****ALGORITHIM FOR THE BULLETS HITTING ALIENS
                        //if the bullet is @ coord X
                        //is greater than the alien @ coord X
                        if (bullet.displayArea.X >= aliens[x].displayArea.X && (bullet.displayArea.X <= (aliens[x].displayArea.X + aliens[x].displayArea.Width)))
                        {
                            if ((bullet.displayArea.Y <= (aliens[x].displayArea.Y + aliens[x].displayArea.Height)) && bullet.displayArea.Y >= aliens[x].displayArea.Y)
                            {
                                aliens.RemoveAt(x);
                                aliensDead++;
                                break;
                            }
                        }
                    }
                }

                //******WALL COLLOSIONS FOR ALIENS
                foreach (Alien alien in aliens)
                {
                    if (alien.CheckWallCollide(this.DisplayRectangle))
                    {
                        foreach (Alien cAlien in aliens)
                        {
                            //correcting the postions after the right side collide
                            cAlien.XVelocity = -cAlien.XVelocity;

                            //corrects the position after a right side collide
                            //why the right side need smore attention
                            //is a mystery to me
                            //the videos had no sound...so i am a little confused
                            //in class we had to spend a lot time on the paddle
                            //when it hit the right side
                            //only way it works is if i move it down 30 per sec
                            //anything more than 30 causes the aliens to go straight to the bottom.
                            if ((cAlien.displayArea.X != alien.displayArea.X) && alien.displayArea.X > 30)
                            {
                                //it must be moved twice 
                                //because when it bounces back in the left direction it seems to be 
                                //changing velocity and overlapping
                                cAlien.moveAlien();
                                cAlien.moveAlien();
                            }
                            //move row of aliens down 30 per sec
                            cAlien.MoveDown(30);
                        }
                    }
                    alien.moveAlien();
                }
            //}
            Invalidate();
        }
    }
}