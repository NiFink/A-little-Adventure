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
    public partial class InGame3 : Form
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

        public int bossspeed = 0;
        public bool canstartBoss = true;

        public int bossdirection = 0;
        public int bossdirection2 = 0;
        public int startFireball = 0;
        public int speedfireball = 0;

        private int _tickBoss;
        private int _tickBoss2;

        private int _tickFireball;
        // von den Gegner die variablen.

        //Animation von Link
        private int _ticks;

        // truhen variable
        bool chestopen = false;
        bool bosschest = false;
        #endregion

        //----------------------------------------\\

        public InGame3(gamecontroller gct0, int layout = 0)
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
        private void InGame3_Load(object sender, EventArgs e)
        {
            gct.lvl = 3;

   

            if (gct.load0 == true)
            {
                gct.setLocationLoad();

            }
            else
            {
                Link.Top = gct.linkSpawnY;
                Link.Left = gct.linkSpawnX;
            }

            gct.loadKey();
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


        private void tmLink_Tick(object sender, EventArgs e)
        {
            // Wenn Link nach links/... läuft bekommt er jede sekunde ein neues Bild, für eine flüssige Animation.

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

            #region Boss

            gct.moveboss2(bossdirection2);
            gct.moveboss(bossdirection);
            gct.bossCollision();
            if (makeaction == true && bosschest == false && pbBC_field.Bounds.IntersectsWith(Link.Bounds))
            {
                // Wenn man vor einer truhe "E" drückt ist es eine offenen chest.
                bosschest = true;
                makeaction = false;

                gct.getBosschest();

                pbBosschest.BackgroundImage = Properties.Resources.Chest_Boss_open;
                pbBosschest.Width = 40; 
                pbBosschest.Height = 56; 
                pbBosschest.Left = 576;
                pbBosschest.Top = 144;
            }

            #endregion

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
                        pbchest_closed_1.Left = 728;
                        pbchest_closed_1.Top = 80;
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


                #region Boss
                if (picture is PictureBox && picture.Tag == "AktivateBoss")
                {
                    if (((PictureBox)picture).Bounds.IntersectsWith(Link.Bounds) && canstartBoss == true)
                    {
                        canstartBoss = false;
                        bossdirection = 1;
                        bossdirection2 = 3;
                        bossspeed = 2;

                        pbBossCrystal1.Left = 720;
                        pbBossCrystal1.Top = 352;

                        gct.stopMusic();
                        gct.playMusic(2);
                    }
                }

                if (picture is PictureBox && picture.Tag == "BossCrystal")
                {
                    if (((PictureBox)picture).Bounds.IntersectsWith(Link.Bounds))
                    {
                        Link.Left = Link0.X;
                        Link.Top = Link0.Y;
                    }
                    if (((PictureBox)picture).Bounds.IntersectsWith(pbArrow.Bounds))
                    {
                        gct.fightBoss(1, 1);                      
                    }

                }

                if (picture is PictureBox && picture.Tag == "Bossenemy")
                {

                    if (((PictureBox)picture).Bounds.IntersectsWith(Link.Bounds) && attack == false)
                    {
                        // respawn
                        Link.Left = gct.safepointL;
                        Link.Top = gct.safepointT;

                        gct.takedamage(1);
                    }
                }
                #endregion


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

            if (pbToLvl2f3.Bounds.IntersectsWith(Link.Bounds))
            {
                gct.lvl = 2;
                gct.lvlBack = 3;
                gct.load0 = false;

                
                if (gct.bossmusic == true)
                {
                    gct.stopMusic();
                    gct.bossmusic = false;
                }

                gct.setLocation();

                gct.showInGame2();

                gct.hideInGame3();

            }
            #endregion

        }


        //----------------------------------------\\

        private void tmBoss_Tick(object sender, EventArgs e)
        {
            #region Boss animation
            if (bossdirection == 1)
            {
                _tickBoss++;

                if (_tickBoss > 4)
                {
                    _tickBoss = 0;
                }


                if (_tickBoss == 1)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_right2;
                }
                if (_tickBoss == 2)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_right3;
                }
                if (_tickBoss == 3)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_right4;
                }
                if (_tickBoss == 4)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_right5;
                }
            }
            if (bossdirection == 2)
            {
                _tickBoss++;

                if (_tickBoss >= 5)
                {
                    _tickBoss = 0;
                }

                if (_tickBoss == 1)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_left2;
                }
                if (_tickBoss == 2)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_left3;
                }
                if (_tickBoss == 3)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_left4;
                }
                if (_tickBoss == 4)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_left5;
                }
            }
            if (bossdirection == 3)
            {
                _tickBoss++;

                if (_tickBoss >= 5)
                {
                    _tickBoss = 0;
                }



                if (_tickBoss == 1)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_down2;
                }
                if (_tickBoss == 2)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_down3;
                }
                if (_tickBoss == 3)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_down4;
                }
                if (_tickBoss == 4)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_down5;
                }

            }
            if (bossdirection == 4)
            {
                _tickBoss++;

                if (_tickBoss >= 5)
                {
                    _tickBoss = 0;
                }


                if (_tickBoss == 1)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_up2;
                }
                if (_tickBoss == 2)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_up3;
                }
                if (_tickBoss == 3)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_up4;
                }
                if (_tickBoss == 4)
                {
                    pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_up5;
                }

            }

            if (bossdirection2 == 1)
            {
                _tickBoss2++;

                if (_tickBoss2 > 4)
                {
                    _tickBoss2 = 0;
                }


                if (_tickBoss2 == 1)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_right2;
                }
                if (_tickBoss2 == 2)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_right3;
                }
                if (_tickBoss2 == 3)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_right4;
                }
                if (_tickBoss2 == 4)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_right5;
                }
            }
            if (bossdirection2 == 2)
            {
                _tickBoss2++;

                if (_tickBoss2 >= 5)
                {
                    _tickBoss2 = 0;
                }

                if (_tickBoss2 == 1)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_left2;
                }
                if (_tickBoss2 == 2)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_left3;
                }
                if (_tickBoss2 == 3)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_left4;
                }
                if (_tickBoss2 == 4)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_left5;
                }
            }
            if (bossdirection2 == 3)
            {
                _tickBoss2++;

                if (_tickBoss2 >= 5)
                {
                    _tickBoss2 = 0;
                }



                if (_tickBoss2 == 1)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_down2;
                }
                if (_tickBoss2 == 2)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_down3;
                }
                if (_tickBoss2 == 3)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_down4;
                }
                if (_tickBoss2 == 4)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_down5;
                }

            }
            if (bossdirection2 == 4)
            {
                _tickBoss2++;

                if (_tickBoss2 >= 5)
                {
                    _tickBoss2 = 0;
                }


                if (_tickBoss2 == 1)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_up2;
                }
                if (_tickBoss2 == 2)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_up3;
                }
                if (_tickBoss2 == 3)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_up4;
                }
                if (_tickBoss2 == 4)
                {
                    pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_up5;
                }

            }
            #endregion

            #region fireball

            if (startFireball == 1)
            {

                _tickFireball++;
                speedfireball = 10;

                foreach (Control picture in this.Controls)
                {
                    if (picture is PictureBox && picture.Tag == "fireball")
                    {
                        picture.Visible = true;
                        picture.Left += speedfireball;

                        if (_tickFireball >= 13)
                        {
                            _tickFireball = 8;
                        }
                        if (_tickFireball == 1)
                        {
                            picture.BackgroundImage = Properties.Resources.Fireball_right1;

                        }
                        if (_tickFireball == 2)
                        {
                            picture.BackgroundImage = Properties.Resources.Fireball_right2;


                            picture.Width = 48;
                            picture.Height = 24;

                        }
                        if (_tickFireball == 3)
                        {
                            picture.BackgroundImage = Properties.Resources.Fireball_right3;
                        }
                        if (_tickFireball == 4)
                        {
                            picture.BackgroundImage = Properties.Resources.Fireball_right4;

                        }
                        if (_tickFireball == 5)
                        {
                            picture.BackgroundImage = Properties.Resources.Fireball_right5;

                        }
                        if (_tickFireball == 6)
                        {
                            picture.BackgroundImage = Properties.Resources.Fireball_right6;
                            picture.Width = 80;
                            picture.Height = 32;
                        }
                        if (_tickFireball == 7)
                        {
                            picture.BackgroundImage = Properties.Resources.Fireball_right7;
                        }
                        if (_tickFireball == 8)
                        {
                            picture.BackgroundImage = Properties.Resources.Fireball_right8;
                        }
                        if (_tickFireball == 9)
                        {
                            picture.BackgroundImage = Properties.Resources.Fireball_right9;
                        }
                        if (_tickFireball == 10)
                        {
                            picture.BackgroundImage = Properties.Resources.Fireball_right10;

                        }
                        if (_tickFireball == 11)
                        {
                            picture.BackgroundImage = Properties.Resources.Fireball_right11;
                        }
                        if (_tickFireball == 12)
                        {
                            picture.BackgroundImage = Properties.Resources.Fireball_right12;
                        }


                        if (((PictureBox)picture).Bounds.IntersectsWith(Link.Bounds))
                        {
                            Link.Left = gct.safepointL;
                            Link.Top = gct.safepointT;
                            gct.takedamage(2);
                        }
                    }
                }

            }

            #endregion
        }

        //----------------------------------------\\

        private void btInGame3Menu_Click(object sender, EventArgs e)
        {
            canstartBoss = true;
            bossdirection = 0;
            bossdirection2 = 0;
            bossspeed = 0;

            gct.stopMusic();
            gct.showMenu();
            gct.ingame3.Hide();
        }


    }
}
