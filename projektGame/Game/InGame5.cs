using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektGame.Game
{
    public partial class InGame5 : Form
    {
        #region variables
        gamecontroller gct = null;

        // Variablen definierren für die Tastatur
        bool goup = false;
        bool godown = false;
        bool goleft = false;
        bool goright = false;

        bool makeaction = false;
        bool attack = false;

        bool arrow = false;
        int arrowspeed = 0;
        bool arrowU = false;
        bool arrowD = false;
        bool arrowL = false;
        bool arrowR = false;
        // ... für den generelle schnelligkeit 
        int speed = 3;

        //Animation von Link
        private int _ticks;

        // truhen variable
        bool chestopen = false;
        #endregion

        //----------------------------------------\\

        public InGame5(gamecontroller gct0, int layout = 0)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            lbGameover.Visible = false;
            tmLink.Start();

            gct = gct0;

            lbScore.Text = gct.score.ToString();

        }

        //----------------------------------------\\

        // das Link an seinem Spawn auch steht mit keinem schaden und der Timer 1 wird gestartet
        private void InGame5_Load(object sender, EventArgs e)
        {
            gct.lvl = 5;
            gct.lvlBack = 5;

            gct.loadKey();

            if (gct.load0 == true)
            {
                gct.setLocationLoad();
            }
            else
            {
                Link.Top = gct.linkSpawnY;
                Link.Left = gct.linkSpawnX;
            }

            gct.countPoint();
            gct.takedamage(0);

            lbSavepoint.Text = gct.linkSpawnY.ToString() + "/" + gct.linkSpawnX.ToString();

            tmMain.Start();
        }

        //----------------------------------------\\

        #region key up/down  events von Link 
        private void keyisdown(object sender, KeyEventArgs e)
        {
            // die einzelnen bewegung von Link mit der veränderung des Bildes.

            if (e.KeyCode == Keys.A)
            {
                goleft = true;
                if (arrowD == false && arrowR == false && arrowU == false)
                {
                    arrowL = true;
                }
            }
            if (e.KeyCode == Keys.D)
            {
                goright = true;
                if (arrowD == false && arrowL == false && arrowU == false)
                {
                    arrowR = true;
                }
            }
            if (e.KeyCode == Keys.W)
            {
                goup = true;
                if (arrowD == false && arrowL == false && arrowR == false)
                {
                    arrowU = true;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                godown = true;
                if (arrowU == false && arrowL == false && arrowU == false)
                {
                    arrowD = true;
                }
            }


            //Aktionenknopf
            if (e.KeyCode == Keys.E)
            {
                makeaction = true;
            }


            #region attack
            // Angriff
            if (e.KeyCode == Keys.Q)
            {
                attack = true;
                arrow = true;
                goright = false;
                goup = false;
                godown = false;
                goleft = false;
            }


            #endregion
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            // wenn man aufhört zu drücken soll er stehen bleiben


            if (e.KeyCode == Keys.A)
            {
                goleft = false;

            }
            if (e.KeyCode == Keys.D)
            {
                goright = false;

            }
            if (e.KeyCode == Keys.W)
            {
                goup = false;

            }
            if (e.KeyCode == Keys.S)
            {
                godown = false;

            }


            if (e.KeyCode == Keys.E)
            {
                makeaction = false;
            }
        }
        #endregion


        //Link animation der Laufbewegung
        private void tmLink_Tick(object sender, EventArgs e)
        {

            if (goleft == true)
            {
                _ticks++;

                if (_ticks >= 11)
                {
                    _ticks = 0;


                }

                if (_ticks == 1)
                {
                    Link.BackgroundImage = Properties.Resources.Link_left1;
                }
                if (_ticks == 2)
                {
                    Link.BackgroundImage = Properties.Resources.Link_left2;
                }

                if (_ticks == 3)
                {
                    Link.BackgroundImage = Properties.Resources.Link_left3;
                }
                if (_ticks == 4)
                {
                    Link.BackgroundImage = Properties.Resources.Link_left4;
                }
                if (_ticks == 5)
                {
                    Link.BackgroundImage = Properties.Resources.Link_left5;
                }
                if (_ticks == 6)
                {
                    Link.BackgroundImage = Properties.Resources.Link_left6;
                }

                if (_ticks == 7)
                {
                    Link.BackgroundImage = Properties.Resources.Link_left7;
                }
                if (_ticks == 8)
                {
                    Link.BackgroundImage = Properties.Resources.Link_left8;
                }
                if (_ticks == 9)
                {
                    Link.BackgroundImage = Properties.Resources.Link_left9;
                }
                if (_ticks == 10)
                {
                    Link.BackgroundImage = Properties.Resources.Link_left10;
                }



            }
            if (goright == true)
            {
                _ticks++;

                if (_ticks > 10)
                {
                    _ticks = 0;

                }

                if (_ticks == 1)
                {
                    Link.BackgroundImage = Properties.Resources.Link_right1;
                }
                if (_ticks == 2)
                {
                    Link.BackgroundImage = Properties.Resources.Link_right2;
                }

                if (_ticks == 3)
                {
                    Link.BackgroundImage = Properties.Resources.Link_right3;
                }
                if (_ticks == 4)
                {
                    Link.BackgroundImage = Properties.Resources.Link_right4;
                }
                if (_ticks == 5)
                {
                    Link.BackgroundImage = Properties.Resources.Link_right5;
                }
                if (_ticks == 6)
                {
                    Link.BackgroundImage = Properties.Resources.Link_right6;
                }

                if (_ticks == 7)
                {
                    Link.BackgroundImage = Properties.Resources.Link_right7;
                }
                if (_ticks == 8)
                {
                    Link.BackgroundImage = Properties.Resources.Link_right8;
                }
                if (_ticks == 9)
                {
                    Link.BackgroundImage = Properties.Resources.Link_right9;
                }
                if (_ticks == 10)
                {
                    Link.BackgroundImage = Properties.Resources.Link_right10;
                }
            }
            if (goup == true)
            {
                _ticks++;

                if (_ticks > 10)
                {
                    _ticks = 0;

                }

                if (_ticks == 1)
                {
                    Link.BackgroundImage = Properties.Resources.Link_up1;
                }
                if (_ticks == 2)
                {
                    Link.BackgroundImage = Properties.Resources.Link_up2;
                }

                if (_ticks == 3)
                {
                    Link.BackgroundImage = Properties.Resources.Link_up3;
                }
                if (_ticks == 4)
                {
                    Link.BackgroundImage = Properties.Resources.Link_up4;
                }
                if (_ticks == 5)
                {
                    Link.BackgroundImage = Properties.Resources.Link_up5;
                }
                if (_ticks == 6)
                {
                    Link.BackgroundImage = Properties.Resources.Link_up6;
                }

                if (_ticks == 7)
                {
                    Link.BackgroundImage = Properties.Resources.Link_up7;
                }
                if (_ticks == 8)
                {
                    Link.BackgroundImage = Properties.Resources.Link_up8;
                }
                if (_ticks == 9)
                {
                    Link.BackgroundImage = Properties.Resources.Link_up9;
                }
                if (_ticks == 10)
                {
                    Link.BackgroundImage = Properties.Resources.Link_up10;
                }

            }
            if (godown == true)
            {
                _ticks++;

                if (_ticks > 10)
                {
                    _ticks = 0;

                }

                if (_ticks == 1)
                {
                    Link.BackgroundImage = Properties.Resources.Link_down1;
                }
                if (_ticks == 2)
                {
                    Link.BackgroundImage = Properties.Resources.Link_down2;
                }

                if (_ticks == 3)
                {
                    Link.BackgroundImage = Properties.Resources.Link_down3;
                }
                if (_ticks == 4)
                {
                    Link.BackgroundImage = Properties.Resources.Link_down4;
                }
                if (_ticks == 5)
                {
                    Link.BackgroundImage = Properties.Resources.Link_down5;
                }
                if (_ticks == 6)
                {
                    Link.BackgroundImage = Properties.Resources.Link_down6;
                }

                if (_ticks == 7)
                {
                    Link.BackgroundImage = Properties.Resources.Link_down7;
                }
                if (_ticks == 8)
                {
                    Link.BackgroundImage = Properties.Resources.Link_down8;
                }
                if (_ticks == 9)
                {
                    Link.BackgroundImage = Properties.Resources.Link_down9;
                }
                if (_ticks == 10)
                {
                    Link.BackgroundImage = Properties.Resources.Link_down10;
                }
            }
        }

        //----------------------------------------\\

        //Steuert Das ganze spiel geschehen außen rum
        private void tmMain_Tick(object sender, EventArgs e)
        {
            Point Link0 = new Point(Link.Left, Link.Top);

            //----------------------------------------\\

            #region Movement from Link and the definition of the direction
            if (goleft)
            {
                Link.Left = Link.Left - speed;
                godown = false;
                goup = false;
                //bewegung von Link nach links
            }
            if (goright)
            {
                Link.Left += speed;
                godown = false;
                goup = false;
                //bewegung rechts
            }
            if (goup)
            {
                Link.Top -= speed;
                //bewegung hoch
            }

            if (godown)
            {
                Link.Top += speed;
                //bewegung runter
            }


            if (goleft || goright || goup || godown)
            {
                lbGameover.Visible = false;
            }
            #endregion

            //----------------------------------------\\

            #region Arrow
            if (attack == true)
            {
                if (arrow == true)
                {
                    pbArrow.Left = Link.Left;
                    pbArrow.Top = Link.Top;
                    arrowL = false;
                    arrowR = false;
                    arrowU = false;
                    arrowD = false;
                    arrow = false;
                }

                pbArrow.Visible = true;

                if (arrowL == true)
                {
                    arrowspeed = 7;
                    pbArrow.Left -= arrowspeed;

                    arrowR = false;
                    arrowU = false;
                    arrowD = false;

                    pbArrow.Width = 32;
                    pbArrow.Height = 16;
                    pbArrow.BackgroundImage = Properties.Resources.Arrow_left;
                }
                else if (arrowR == true)
                {
                    arrowspeed = 7;
                    pbArrow.Left += arrowspeed;
                    arrowL = false;
                    arrowU = false;
                    arrowD = false;

                    pbArrow.Width = 32;
                    pbArrow.Height = 16;
                    pbArrow.BackgroundImage = Properties.Resources.Arrow_right;
                }
                else if (arrowU == true)
                {
                    arrowspeed = 7;
                    pbArrow.Top -= arrowspeed;

                    arrowL = false;
                    arrowR = false;
                    arrowD = false;

                    pbArrow.Width = 16;
                    pbArrow.Height = 32;
                    pbArrow.BackgroundImage = Properties.Resources.Arrow_up;
                }
                else if (arrowD == true)
                {
                    arrowspeed = 7;
                    pbArrow.Top += arrowspeed;

                    arrowL = false;
                    arrowR = false;
                    arrowU = false;

                    pbArrow.Width = 16;
                    pbArrow.Height = 32;
                    pbArrow.BackgroundImage = Properties.Resources.Arrow_down;
                }
            }
            #endregion

            //----------------------------------------\\

            #region Collision
            foreach (Control picture in this.Controls)
            {
                // das Link punkte bekommt so wie schaden bekommt oder macht sowie das er nicht durch wände laufen kann
                if (picture is PictureBox && picture.Tag == "collider")
                {
                    // Alle die denn "Tag" "collider" haben werden;
                    if (((PictureBox)picture).Bounds.IntersectsWith(Link.Bounds))
                    {
                        // das man nicht durch Gegenstände laufen kann oder wände
                        Link.Left = Link0.X;
                        Link.Top = Link0.Y;
                        // wird die position gespeicher wenn man kollidiert
                    }
                    if (((PictureBox)picture).Bounds.IntersectsWith(pbArrow.Bounds))
                    {
                        attack = false;
                        pbArrow.Left = 984;
                        pbArrow.Top = 200;
                        arrowspeed = 0;
                        pbArrow.Visible = false;
                    }
                }


                if (picture is PictureBox && picture.Tag == "action")
                {
                    // Alle die denn "Tag" "action" haben werden;
                    if (makeaction == true && chestopen == false && ((PictureBox)picture).Bounds.IntersectsWith(Link.Bounds))
                    {
                        // Wenn man vor einer truhe "E" drückt bekommt man + 10 und das bild ändert sich zu einer offenen chest.
                        pbchest_closed_1.BackgroundImage = Properties.Resources.Chest_open_1;
                        gct.scorePlus(10);
                        chestopen = true;
                        makeaction = false;
                        pbchest_closed_1.Width = 36;
                        pbchest_closed_1.Height = 47;
                        pbchest_closed_1.Left = 168;
                        pbchest_closed_1.Top = 496;
                    }
                }


                if (picture is PictureBox && picture.Tag == "coin")
                {
                    if (((PictureBox)picture).Bounds.IntersectsWith(Link.Bounds))
                    {
                        // er soll verschwinden wenn er berührt wirdund bekommt +1.
                        ((PictureBox)picture).Visible = false;
                        picture.Tag = "";
                        gct.scorePlus(1);
                    }
                }


                if (picture is PictureBox && picture.Tag == "stair")
                {

                    if (((PictureBox)picture).Bounds.IntersectsWith(Link.Bounds) && makeaction == true)
                    {
                        speed = 1;

                    }
                    else if (((PictureBox)picture).Bounds.IntersectsWith(Link.Bounds) && makeaction == false)
                    {
                        Link.Left = Link0.X;
                        Link.Top = Link0.Y;
                    }
                    if (((PictureBox)picture).Bounds.IntersectsWith(Link.Bounds))
                    {
                        speed = 3;
                    }
                }
            }

            #region LevelUp
            if (pbToLvl4f5.Bounds.IntersectsWith(Link.Bounds))
            {
                gct.lvl = 4;
                gct.lvlBack = 5;
                gct.load0 = false;

                gct.setLocation();

                gct.showInGame4();

                gct.hideInGame5();

            }
            if (pbToLvl51f5.Bounds.IntersectsWith(Link.Bounds))
            {
                gct.lvl = 51;
                gct.lvlBack = 5;
                gct.load0 = false;

                gct.setLocation();

                gct.showInGame51();

                gct.hideInGame5();

            }
            #endregion

            #region ExtraHeart
            if (pbExtraHeart.Bounds.IntersectsWith(Link.Bounds) && gct.health <= 2)
            {
                gct.getExtraHeart(5);
            }
            #endregion

            #endregion
            //----------------------------------------\\
        }


        //----------------------------------------\\

        private void btInGame5Menu_Click(object sender, EventArgs e)
        {
            gct.showMenu();
            gct.ingame5.Hide();
        }


        //----------------------------------------\\
    }
}
