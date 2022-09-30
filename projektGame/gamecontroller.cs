using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using WMPLib;
using projektGame.Game;
using projektGame.Menus;

namespace projektGame
{
    public partial class gamecontroller : Form
    {

        //als platz halter
        Mainmenu mainmenu = null;
        Menu menu = null;
        Options options = null;
        public InGame ingame = null;
        public InGame2 ingame2 = null;
        public InGame3 ingame3 = null;
        public InGame4 ingame4 = null;
        public InGame5 ingame5 = null;
        public InGame51 ingame51 = null;
        public InGame6 ingame6 = null;
        public InGame7 ingame7 = null;
        public static WMPLib.WindowsMediaPlayer simpleSound = new WMPLib.WindowsMediaPlayer();

        //------------------\\
        #region Variablen
        public int lvlBack = 1;

        public string name = string.Empty;


        public int health = 3;
        int enemyhealth = 2;
        int enemy2health = 2;

        public int bosshealth = 5;
        public int moveboss1 = 1;


        public int linkSpawnX = 301;
        public int linkSpawnY = 186;

        public int score = 0;

        public int linkLocationL;
        public int linkLocationT;

        public int safepointL = 301;
        public int safepointT = 186;

        public int lvl = 1;

        public bool key1 = false;

        public bool load0 = false;

        public bool bossmusic = false;
        #endregion

        //------------------\\

        #region Form load and Quit
        public gamecontroller()
        {
            InitializeComponent();
        }

        //------------------\\

        private async void controller_Load(object sender, EventArgs e)
        {
            await Task.Delay(10);
            this.Hide();

            showMainMenu();
        }


        public static void quit()
        {
            Application.Exit();
        }
        #endregion

        //------------------\\

        #region Forms show/hide

        public void showMainMenu()
        {
            if (mainmenu != null)
            {
                mainmenu = null;
            }

            mainmenu = new Mainmenu(this);
            mainmenu.Show();
        }
        public void hideMainMenu()
        {
            if (mainmenu != null)
            {
                mainmenu.Hide();
                mainmenu.Dispose();
                mainmenu = null;
            }
        }

        //------------------\\

        public void showInGame()
        {

            if (ingame != null)
            {
                ingame = null;
            }

            ingame = new InGame(this);
            ingame.Show();
        }
        public void hideInGame()
        {
            if (ingame != null)
            {
                ingame.Hide();
                ingame.Dispose();
                ingame = null;
            }
        }

        //------------------\\

        public void showOptions(int index = 0)
        {
            if (options != null)
            {
                options = null;
            }

            options = new Options(this, index);
            options.Show();
        }
        public void hideOptions()
        {
            if (options != null)
            {
                options.Hide();
                options.Dispose();
                options = null;
            }
        }

        //------------------\\

        public void showMenu()
        {
            if (menu != null)
            {
                menu = null;
            }

            menu = new Menu(this);
            menu.Show();
        }
        public void hideMenu()
        {
            if (menu != null)
            {
                menu.Hide();
                menu.Dispose();
                menu = null;
            }
        }

        //------------------\\

        public void showInGame2()
        {
            if (ingame2 != null)
            {
                ingame2 = null;
            }

            ingame2 = new InGame2(this);
            ingame2.Show();
        }
        public void hideInGame2()
        {
            if (ingame2 != null)
            {
                ingame2.Hide();
                ingame2.Dispose();
                ingame2 = null;
            }
        }

        //------------------\\

        public void showInGame3()
        {

            if (ingame3 != null)
            {
                ingame3 = null;
            }

            ingame3 = new InGame3(this);
            ingame3.Show();
        }
        public void hideInGame3()
        {
            if (ingame3 != null)
            {
                ingame3.Hide();
                ingame3.Dispose();
                ingame3 = null;
            }
        }

        //------------------\\

        public void showInGame4()
        {

            if (ingame4 != null)
            {
                ingame4 = null;
            }

            ingame4 = new InGame4(this);
            ingame4.Show();
        }
        public void hideInGame4()
        {
            if (ingame4 != null)
            {
                ingame4.Hide();
                ingame4.Dispose();
                ingame4 = null;
            }
        }

        //------------------\\

        public void showInGame5()
        {

            if (ingame5 != null)
            {
                ingame5 = null;
            }

            ingame5 = new InGame5(this);
            ingame5.Show();
        }
        public void hideInGame5()
        {
            if (ingame5 != null)
            {
                ingame5.Hide();
                ingame5.Dispose();
                ingame5 = null;
            }
        }

        //------------------\\

        public void showInGame51()
        {

            if (ingame51 != null)
            {
                ingame51 = null;
            }

            ingame51 = new InGame51(this);
            ingame51.Show();
        }
        public void hideInGame51()
        {
            if (ingame51 != null)
            {
                ingame51.Hide();
                ingame51.Dispose();
                ingame51 = null;
            }
        }

        //------------------\\

        public void showInGame6()
        {

            if (ingame6 != null)
            {
                ingame6 = null;
            }

            ingame6 = new InGame6(this);
            ingame6.Show();
        }
        public void hideInGame6()
        {
            if (ingame6 != null)
            {
                ingame6.Hide();
                ingame6.Dispose();
                ingame6 = null;
            }
        }

        //------------------\\

        public void showInGame7()
        {

            if (ingame7 != null)
            {
                ingame7 = null;
            }

            ingame7 = new InGame7(this);
            ingame7.Show();
        }
        public void hideInGame7()
        {
            if (ingame7 != null)
            {
                ingame7.Hide();
                ingame7.Dispose();
                ingame7 = null;
            }
        }
        #endregion

        //------------------\\

        #region save and load
        public void setname(string pName)
        {
            name = pName;
        }

        public void load()
        {
            // Ort wo man lädt wird mit dem name definiert
            string path = Application.StartupPath + @"\Playerlist\" + name + ".txt";

            try
            {
                string pos = File.ReadLines(path).Skip(0).Take(1).First();
                string[] posXY = pos.Split(':');

                int X = Convert.ToInt32(posXY[0]);
                int Y = Convert.ToInt32(posXY[1]);
                int score0 = Convert.ToInt32(posXY[2]);
                int health0 = Convert.ToInt32(posXY[3]);
                int lvl0 = Convert.ToInt32(posXY[4]);
                bool key0 = Convert.ToBoolean(posXY[5]);

                linkLocationL = X;
                linkLocationT = Y;
                score = score0;
                health = health0;
                lvl = lvl0;
                key1 = key0;

                load0 = true;


                //Das gleich weiter gemacht wird und man nicht nochmal auf lblevel gedrückt werden muss
                if (mainmenu != null)
                {
                    mainmenu.btLevel.PerformClick();
                }


            } // Falls der Name nicht vorhanden ist
            catch (Exception e)
            {
                if (mainmenu != null)
                {
                    mainmenu.lbDiagnosis.Text = e.ToString();
                }

                if (menu != null)
                {
                    menu.lbDiagnosis.Text = e.ToString();
                }


                return;
            }

        }

        public bool isPlayerAlredyExisting()
        {
            string path = Application.StartupPath + @"\Playerlist\" + name + ".txt";

            if (File.Exists(path) == true)
            {
                mainmenu.lbDiagnosis.Visible = true;
                mainmenu.lbDiagnosis.Text = "This Player is already exists";
                return true;

            }
            else
            {
                mainmenu.lbDiagnosis.Visible = true;

                mainmenu.lbDiagnosis.Text = "This Player is already exists";
                return false;
            }

        }
        public bool isPlayerExisting()
        {
            string path = Application.StartupPath + @"\Playerlist\" + name + ".txt";

            if (File.Exists(path) == true)
            {
                mainmenu.lbDiagnosis.Text = "true";
                return true;

            }
            else
            {
                mainmenu.lbDiagnosis.Visible = true;

                mainmenu.lbDiagnosis.Text = "This Player does NOT exist";
                return false;
            }


        }
        public void save()
        {
            setLocationSave();
            // Ort wo man abspeichert wird mit dem name definiert
            string path = Application.StartupPath + @"\Playerlist\" + name + ".txt";

            // Welche Attribute abgespeichert werden sollen
            string content = (linkLocationL).ToString() + ":" + (linkLocationT).ToString() + ":" + (score).ToString() + ":" + (health).ToString() + ":" + (lvl).ToString() + ":" + (key1).ToString();


            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(content);
            sw.Dispose();
        }
        #endregion

        //------------------\\

        #region Location
        public void goNewPlayer()
        {
            lvl = 1;
            score = 0;
            safepointL = linkSpawnX;
            safepointT = linkSpawnY;
            health = 3;
        }

        public void setLocation()
        {
            if (lvl == 1 && lvlBack == 1)
            {
                safepointL = 301;
                safepointT = 186;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 1 && lvlBack == 2)
            {
                safepointL = 816;
                safepointT = 24;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 2 && lvlBack == 2)
            {
                safepointL = 821;
                safepointT = 687;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 2 && lvlBack == 3)
            {
                safepointL = 968;
                safepointT = 320;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 2 && lvlBack == 4)
            {
                safepointL = 824;
                safepointT = 8;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 3)
            {
                safepointL = 64;
                safepointT = 296;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 4 && lvlBack == 2)
            {
                safepointL = 808;
                safepointT = 672;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 4 && lvlBack == 5)
            {
                safepointL = 360;
                safepointT = 120;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 4 && lvlBack == 6)
            {
                safepointL = 920;
                safepointT = 48;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 5 && lvlBack == 4)
            {
                safepointL = 480;
                safepointT = 560;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 5 && lvlBack == 51)
            {
                safepointL = 152;
                safepointT = 64;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 51 && lvlBack == 5)
            {
                safepointL = 152;
                safepointT = 600;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 51 && lvlBack == 7)
            {
                safepointL = 912; 
                safepointT = 112;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 6 && lvlBack == 4)
            {
                safepointL = 232;
                safepointT = 608;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }          
            if (lvl == 6 && lvlBack == 7)
            {
                safepointL = 224; 
                safepointT = 24;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 7 && lvlBack == 6)
            {
                safepointL = 224; 
                safepointT = 576;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }
            if (lvl == 7 && lvlBack == 51)
            {
                safepointL = 16; 
                safepointT = 296;
                linkSpawnX = safepointL;
                linkSpawnY = safepointT;
            }

        }

        public void setLocationSave()
        {
            if (lvl == 1)
            {
                linkLocationL = ingame.Link.Location.X;
                linkLocationT = ingame.Link.Location.Y;
            }

            if (lvl == 2)
            {
                linkLocationL = ingame2.Link.Location.X;
                linkLocationT = ingame2.Link.Location.Y;
            }

            if (lvl == 3)
            {
                linkLocationL = 64;
                linkLocationT = 296;
            }
            if (lvl == 4)
            {
                linkLocationL = ingame4.Link.Location.X;
                linkLocationT = ingame4.Link.Location.Y;
            }
            if (lvl == 5)
            {
                linkLocationL = ingame5.Link.Location.X;
                linkLocationT = ingame5.Link.Location.Y;
            }
            if (lvl == 51)
            {
                linkLocationL = ingame51.Link.Location.X;
                linkLocationT = ingame51.Link.Location.Y;
            }
            if (lvl == 6)
            {
                linkLocationL = ingame6.Link.Location.X;
                linkLocationT = ingame6.Link.Location.Y;
            }
            if (lvl == 7)
            {
                linkLocationL = ingame7.Link.Location.X;
                linkLocationT = ingame7.Link.Location.Y;
            }

        }

        public void setLocationLoad()
        {
            if (lvl == 1)
            {
                ingame.Link.Left = linkLocationL;
                ingame.Link.Top = linkLocationT;
            }

            if (lvl == 2)
            {
                ingame2.Link.Left = linkLocationL;
                ingame2.Link.Top = linkLocationT;
            }
            if (lvl == 3)
            {
                ingame3.Link.Left = linkLocationL;
                ingame3.Link.Top = linkLocationT;
            }
            if (lvl == 4)
            {
                ingame4.Link.Left = linkLocationL;
                ingame4.Link.Top = linkLocationT;
            }
            if (lvl == 5)
            {
                ingame5.Link.Left = linkLocationL;
                ingame5.Link.Top = linkLocationT;
            }
            if (lvl == 51)
            {
                ingame51.Link.Left = linkLocationL;
                ingame51.Link.Top = linkLocationT;
            }
            if (lvl == 6)
            {
                ingame6.Link.Left = linkLocationL;
                ingame6.Link.Top = linkLocationT;
            }
            if (lvl == 7)
            {
                ingame7.Link.Left = linkLocationL;
                ingame7.Link.Top = linkLocationT;
            }
        }
        #endregion

        //------------------\\

        #region Damage, Boss, Score, Item

        #region Damage
        public void takedamage(int damage)
        {
            if (lvl == 1)
            {
                health = health - damage;
                if (health <= 0)
                {
                    die();
                }
                if (health == 1)
                {
                    ingame.pbHeart2.Visible = false;
                    ingame.pbHeart3.Visible = false;

                }
                if (health == 2)
                {
                    ingame.pbHeart3.Visible = false;
                }
            }
            if (lvl == 2)
            {
                health = health - damage;
                if (health <= 0)
                {
                    die();
                }
                if (health == 1)
                {
                    ingame2.pbHeart2.Visible = false;
                    ingame2.pbHeart3.Visible = false;

                }
                if (health == 2)
                {
                    ingame2.pbHeart3.Visible = false;
                }
            }
            if (lvl == 3)
            {
                health = health - damage;
                if (health <= 0)
                {
                    die();
                }
                if (health == 1)
                {
                    ingame3.pbHeart2.Visible = false;
                    ingame3.pbHeart3.Visible = false;

                }
                if (health == 2)
                {
                    ingame3.pbHeart3.Visible = false;
                }
            }
            if (lvl == 5)
            {
                health = health - damage;
                if (health <= 0)
                {
                    die();
                }
                if (health == 1)
                {
                    ingame5.pbHeart2.Visible = false;
                    ingame5.pbHeart3.Visible = false;

                }
                if (health == 2)
                {
                    ingame5.pbHeart3.Visible = false;
                }
            }
            if (lvl == 6)
            {
                health = health - damage;
                if (health <= 0)
                {
                    die();
                }
                if (health == 1)
                {
                    ingame6.pbHeart2.Visible = false;
                    ingame6.pbHeart3.Visible = false;

                }
                if (health == 2)
                {
                    ingame6.pbHeart3.Visible = false;
                }
            }
        }
        public void die(int enemy = 0)
        {

            score = 0;
            health = 3;

            if (lvl == 1)
            {
                showInGame();

                ingame.lbScore.Text = "0";

                ingame.lbGameover.Visible = true;

                ingame.pbHeart1.Visible = true;
                ingame.pbHeart2.Visible = true;
                ingame.pbHeart3.Visible = true;
                hideInGame();
            }
            if (lvl == 2)
            {
                lvl = 1;
                showInGame();

                ingame.lbScore.Text = "0";

                ingame.lbGameover.Visible = true;


                ingame.pbHeart1.Visible = true;
                ingame.pbHeart2.Visible = true;
                ingame.pbHeart3.Visible = true;
                hideInGame2();
            }
            if (lvl == 3)
            {
                showInGame();
                lvl = 1;
                ingame.lbScore.Text = "0";

                ingame.lbGameover.Visible = true;


                ingame.pbHeart1.Visible = true;
                ingame.pbHeart2.Visible = true;
                ingame.pbHeart3.Visible = true;
                hideInGame3();
            }
            if (lvl == 5)
            {
                showInGame();
                lvl = 1;
                ingame.lbScore.Text = "0";

                ingame.lbGameover.Visible = true;


                ingame.pbHeart1.Visible = true;
                ingame.pbHeart2.Visible = true;
                ingame.pbHeart3.Visible = true;
                hideInGame5();
            }
            if (lvl == 6)
            {
                showInGame();
                lvl = 1;
                ingame.lbScore.Text = "0";

                ingame.lbGameover.Visible = true;


                ingame.pbHeart1.Visible = true;
                ingame.pbHeart2.Visible = true;
                ingame.pbHeart3.Visible = true;
                hideInGame5();
            }

        }

        //------------------\\

        public void setEnemyhealth()
        {
            enemyhealth = 2;
            enemy2health = 2;
        }

        public void makedamage(int damage0, int enemy0)
        {
            switch (enemy0)
            {
                //Erster gegner 
                case 1:
                    if (lvl == 1)
                    {
                        enemyhealth = enemyhealth - damage0;
                        if (enemyhealth <= 0)
                        {
                            enemydie(1);
                        }
                        if (enemyhealth == 1)
                        {
                            ingame.pbEnemy1Heart2.Visible = false;
                            ingame.pbEnemy1.BackgroundImage = Properties.Resources.Enemy_1_right;
                        }
                    }
                    if (lvl == 2)
                    {
                        enemyhealth = enemyhealth - damage0;
                        if (enemyhealth <= 0)
                        {
                            enemydie(1);
                        }
                        if (enemyhealth == 1)
                        {
                            ingame2.pbEnemy1Heart2.Visible = false;

                        }
                    }
                    break;

                //Zweiter gegner
                case 2:
                    if (lvl == 2)
                    {
                        enemy2health = enemy2health - damage0;
                        if (enemy2health <= 0)
                        {
                            enemydie(2);
                        }
                        if (enemy2health == 1)
                        {
                            ingame2.pbEnemy2Heart2.Visible = false;

                        }
                    }
                    break;

                case 3:

                    break;
            }
        }

        public void enemydie(int enemy = 1)
        {
            switch (enemy)
            {
                case 1:
                    if (lvl == 1)
                    {
                        ingame.pbEnemy1.Visible = false;
                        ingame.pbEnemy1.Left = 0;
                        ingame.pbEnemy1.Top = 0;
                        ingame.enemy1speed = 0;
                        ingame.enemy1heart = 0;
                        ingame.pbEnemy1Heart1.Visible = false;
                        ingame.pbEnemy1Heart2.Visible = false;
                    }

                    if (lvl == 2)
                    {
                        ingame2.pbEnemy1.Visible = false;
                        ingame2.pbEnemy1.Left = 0;
                        ingame2.pbEnemy1.Top = 0;
                        ingame2.enemy1speed = 0;
                        ingame2.enemy1heart = 0;
                        ingame2.pbEnemy1Heart1.Visible = false;
                        ingame2.pbEnemy1Heart2.Visible = false;
                    }
                    break;

                case 2:
                    if (lvl == 2)
                    {

                        ingame2.pbEnemy2.Visible = false;
                        ingame2.pbEnemy2.Left = 0;
                        ingame2.pbEnemy2.Top = 0;
                        ingame2.enemy2speed = 0;
                        ingame2.enemy2heart = 0;
                        ingame2.pbEnemy2Heart1.Visible = false;
                        ingame2.pbEnemy2Heart2.Visible = false;
                    }
                    break;

            }

        }
        #endregion

        //------------------\\

        #region Boss
        public void moveboss(int index = 0)
        {


            switch (index)
            {
                case 0:
                    break;
                case 1:
                    ingame3.pbBoss1.Left += ingame3.bossspeed;
                    break;
                case 2:
                    ingame3.pbBoss1.Left -= ingame3.bossspeed;
                    break;
                case 3:
                    ingame3.pbBoss1.Top += ingame3.bossspeed;
                    break;
                case 4:
                    ingame3.pbBoss1.Top -= ingame3.bossspeed;
                    break;
            }
        }

        public void moveboss2(int index = 0)
        {


            switch (index)
            {
                case 0:
                    break;
                case 1:
                    ingame3.pbBoss2.Left += ingame3.bossspeed;
                    break;
                case 2:
                    ingame3.pbBoss2.Left -= ingame3.bossspeed;
                    break;
                case 3:
                    ingame3.pbBoss2.Top += ingame3.bossspeed;
                    break;
                case 4:
                    ingame3.pbBoss2.Top -= ingame3.bossspeed;
                    break;
            }
        }

        public void bossCollision()
        {

            ingame3.tmBoss.Start();

            #region Boss1
            if (ingame3.pbBoss1.Bounds.IntersectsWith(ingame3.Boss1Wall1.Bounds))
            {
                ingame3.bossdirection = 4;
            }
            if (ingame3.pbBoss1.Bounds.IntersectsWith(ingame3.Boss1Wall2.Bounds))
            {
                ingame3.bossdirection = 2;
            }
            if (ingame3.pbBoss1.Bounds.IntersectsWith(ingame3.Boss1Wall3.Bounds))
            {
                ingame3.bossdirection = 3;
            }
            if (ingame3.pbBoss1.Bounds.IntersectsWith(ingame3.Boss1Wall4.Bounds))
            {
                ingame3.bossdirection = 2;
            }
            if (ingame3.pbBoss1.Bounds.IntersectsWith(ingame3.Boss1Wall5.Bounds))
            {
                ingame3.bossdirection = 4;
            }
            if (ingame3.pbBoss1.Bounds.IntersectsWith(ingame3.Boss1Wall6.Bounds))
            {
                ingame3.bossdirection = 2;
            }
            if (ingame3.pbBoss1.Bounds.IntersectsWith(ingame3.Boss1Wall7.Bounds))
            {
                ingame3.bossdirection = 3;
            }
            if (ingame3.pbBoss1.Bounds.IntersectsWith(ingame3.Boss1Wall8.Bounds))
            {
                ingame3.bossdirection = 1;
            }
            #endregion

            #region boss2

            if (ingame3.pbBoss2.Bounds.IntersectsWith(ingame3.Boss2Wall1.Bounds))
            {
                ingame3.bossdirection2 = 2;
            }

            if (ingame3.pbBoss2.Bounds.IntersectsWith(ingame3.Boss2Wall2.Bounds))
            {
                ingame3.bossdirection2 = 4;
            }

            if (ingame3.pbBoss2.Bounds.IntersectsWith(ingame3.Boss2Wall3.Bounds))
            {
                ingame3.bossdirection2 = 2;
            }

            if (ingame3.pbBoss2.Bounds.IntersectsWith(ingame3.Boss2Wall4.Bounds))
            {
                ingame3.bossdirection2 = 3;
            }

            if (ingame3.pbBoss2.Bounds.IntersectsWith(ingame3.Boss2Wall5.Bounds))
            {
                ingame3.bossdirection2 = 2;
            }
            if (ingame3.pbBoss2.Bounds.IntersectsWith(ingame3.Boss2Wall6.Bounds))
            {
                ingame3.bossdirection2 = 3;
            }

            if (ingame3.pbBoss2.Bounds.IntersectsWith(ingame3.Boss2Wall7.Bounds))
            {
                ingame3.bossdirection2 = 1;
            }

            if (ingame3.pbBoss2.Bounds.IntersectsWith(ingame3.Boss2Wall8.Bounds))
            {
                ingame3.bossdirection2 = 4;
            }
            if (ingame3.pbBoss2.Bounds.IntersectsWith(ingame3.Boss2Wall9.Bounds))
            {
                ingame3.bossdirection2 = 1;
            }
            if (ingame3.pbBoss2.Bounds.IntersectsWith(ingame3.Boss2Wall10.Bounds))
            {
                ingame3.bossdirection2 = 3;
            }
            if (ingame3.pbBoss2.Bounds.IntersectsWith(ingame3.Boss2Wall11.Bounds))
            {
                ingame3.bossdirection2 = 2;
            }

            #endregion
        }

        public void fightBoss(int damage0, int index = 1)
        {
            switch (index)
            {
                case 1:

                    bosshealth = bosshealth - damage0;

                    if (bosshealth == 0)
                    {
                        ingame3.pbBosschest.Visible = true;
                        ingame3.pbBosschest.Tag = "collider";

                        ingame3.lbMiniBoss.Text = "Defeated";
                        ingame3.pbBossCrystal1.Visible = false;
                        ingame3.pbBossCrystal1.Tag = "";

                        ingame3.pbBossHeart1.Visible = false;
                        ingame3.pbBossHeart2.Visible = false;
                        ingame3.pbBossHeart3.Visible = false;
                        ingame3.pbBossHeart4.Visible = false;
                        ingame3.pbBossHeart5.Visible = false;

                        ingame3.pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_broke;
                        ingame3.pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_broke;
                    }
                    if (bosshealth == 1)
                    {
                        ingame3.bossdirection = 0;
                        ingame3.bossdirection2 = 0;
                        ingame3.bossspeed = 0;

                        ingame3.pbBoss1.Left = 176;
                        ingame3.pbBoss1.Top = 72;

                        ingame3.pbBoss2.Left = 184;
                        ingame3.pbBoss2.Top = 480;

                        ingame3.pbBossCrystal1.Left = 592;
                        ingame3.pbBossCrystal1.Top = 192;

                        ingame3.pbBoss2.BackgroundImage = Properties.Resources.MiniBoss_rage_right;
                        ingame3.pbBoss1.BackgroundImage = Properties.Resources.MiniBoss_rage_right;

                        ingame3.startFireball = 1;

                        ingame3.pbBossHeart2.Visible = false;
                    }
                    if (bosshealth == 2)
                    {
                        ingame3.pbBossCrystal1.Left = 888;
                        ingame3.pbBossCrystal1.Top = 160;
                        ingame3.bossspeed = 3;
                        ingame3.pbBossHeart3.Visible = false;
                    }
                    if (bosshealth == 3)
                    {
                        ingame3.pbBossCrystal1.Left = 616;
                        ingame3.pbBossCrystal1.Top = 584;
                        ingame3.bossspeed = 2;
                        ingame3.pbBossHeart4.Visible = false;
                    }
                    if (bosshealth == 4)
                    {
                        ingame3.pbBossCrystal1.Left = 208;
                        ingame3.pbBossCrystal1.Top = 232;
                        ingame3.bossspeed = 1;
                        ingame3.pbBossHeart5.Visible = false;
                    }

                    break;
            }
        }

        public void getBosschest()
        {
            getItem(1);
            scorePlus(20);
        }
        #endregion

        //------------------\\

        #region Score
        public void offEnemy(int index = 1)
        {
            switch (index)
            {
                case 1:
                    ingame.pbEnemy1.Visible = false;
                    ingame.pbEnemy1Heart1.Visible = false;
                    ingame.pbEnemy1Heart2.Visible = false;
                    ingame.pbEnemy1.Tag = "";
                    break;
                case 2:
                    ingame2.pbEnemy1.Visible = false;
                    ingame2.pbEnemy1Heart1.Visible = false;
                    ingame2.pbEnemy1Heart2.Visible = false;
                    ingame2.pbEnemy1.Tag = "";
                    break;
                case 3:
                    ingame2.pbEnemy2.Visible = false;
                    ingame2.pbEnemy2Heart1.Visible = false;
                    ingame2.pbEnemy2Heart2.Visible = false;
                    ingame2.pbEnemy2.Tag = "";
                    break;
            }
        }
        public void offChest(int index = 1)
        {
            switch (index)
            {
                case 1:
                    ingame.pbchest_closed_1.BackgroundImage = Properties.Resources.Chest_open_1;
                    ingame.pbchest_closed_1.Tag = "";
                    ingame.pbchest_closed_1.Width = 36;
                    ingame.pbchest_closed_1.Height = 47;
                    break;
                case 2:
                    ingame2.pbchest_closed_1.BackgroundImage = Properties.Resources.Chest_open_1;
                    ingame2.pbchest_closed_1.Tag = "";
                    ingame2.pbchest_closed_1.Width = 36;
                    ingame2.pbchest_closed_1.Height = 47;
                    break;
                case 3:
                    ingame3.pbchest_closed_1.BackgroundImage = Properties.Resources.Chest_open_1;
                    ingame3.pbchest_closed_1.Tag = "";
                    ingame3.pbchest_closed_1.Width = 36;
                    ingame3.pbchest_closed_1.Height = 47;
                    break;
                case 4:
                    ingame4.pbchest_closed_1.BackgroundImage = Properties.Resources.Chest_open_1;
                    ingame4.pbchest_closed_1.Tag = "";
                    ingame4.pbchest_closed_1.Width = 36;
                    ingame4.pbchest_closed_1.Height = 47;
                    break;
                case 5:
                    ingame5.pbchest_closed_1.BackgroundImage = Properties.Resources.Chest_open_1;
                    ingame5.pbchest_closed_1.Tag = "";
                    ingame5.pbchest_closed_1.Width = 36;
                    ingame5.pbchest_closed_1.Height = 47;
                    break;
                case 51:
                    ingame51.pbchest_closed_1.BackgroundImage = Properties.Resources.Chest_open_1;
                    ingame51.pbchest_closed_1.Tag = "";
                    ingame51.pbchest_closed_1.Width = 36;
                    ingame51.pbchest_closed_1.Height = 47;
                    break;

            }
        }

        public void offCoin(int index = 1)
        {
            switch (index)
            {
                case 1:
                    ingame.coin1.Visible = false;
                    ingame.coin1.Tag = "";
                    ingame.coin2.Visible = false;
                    ingame.coin2.Tag = "";
                    ingame.coin3.Visible = false;
                    ingame.coin3.Tag = "";
                    ingame.coin4.Visible = false;
                    ingame.coin4.Tag = "";
                    ingame.coin5.Visible = false;
                    ingame.coin5.Tag = "";
                    ingame.coin6.Visible = false;
                    ingame.coin6.Tag = "";
                    ingame.coin7.Visible = false;
                    ingame.coin7.Tag = "";
                    ingame.coin8.Visible = false;
                    ingame.coin8.Tag = "";
                    ingame.coin9.Visible = false;
                    ingame.coin9.Tag = "";
                    ingame.coin10.Visible = false;
                    ingame.coin10.Tag = "";
                    break;
                case 2:
                    ingame2.coin1.Visible = false;
                    ingame2.coin1.Tag = "";
                    ingame2.coin2.Visible = false;
                    ingame2.coin2.Tag = "";
                    ingame2.coin3.Visible = false;
                    ingame2.coin3.Tag = "";
                    ingame2.coin4.Visible = false;
                    ingame2.coin4.Tag = "";
                    ingame2.coin5.Visible = false;
                    ingame2.coin5.Tag = "";
                    ingame2.coin6.Visible = false;
                    ingame2.coin6.Tag = "";
                    ingame2.coin7.Visible = false;
                    ingame2.coin7.Tag = "";
                    ingame2.coin8.Visible = false;
                    ingame2.coin8.Tag = "";
                    ingame2.coin9.Visible = false;
                    ingame2.coin9.Tag = "";
                    ingame2.coin10.Visible = false;
                    ingame2.coin10.Tag = "";
                    break;
                case 3:
                    ingame3.coin1.Visible = false;
                    ingame3.coin1.Tag = "";
                    ingame3.coin2.Visible = false;
                    ingame3.coin2.Tag = "";
                    ingame3.coin3.Visible = false;
                    ingame3.coin3.Tag = "";
                    ingame3.coin4.Visible = false;
                    ingame3.coin4.Tag = "";
                    ingame3.coin5.Visible = false;
                    ingame3.coin5.Tag = "";
                    ingame3.coin6.Visible = false;
                    ingame3.coin6.Tag = "";
                    ingame3.coin7.Visible = false;
                    ingame3.coin7.Tag = "";
                    ingame3.coin8.Visible = false;
                    ingame3.coin8.Tag = "";
                    ingame3.coin9.Visible = false;
                    ingame3.coin9.Tag = "";
                    ingame3.coin10.Visible = false;
                    ingame3.coin10.Tag = "";
                    break;
                case 4:
                    ingame4.coin1.Visible = false;
                    ingame4.coin1.Tag = "";
                    ingame4.coin2.Visible = false;
                    ingame4.coin2.Tag = "";
                    ingame4.coin3.Visible = false;
                    ingame4.coin3.Tag = "";
                    ingame4.coin4.Visible = false;
                    ingame4.coin4.Tag = "";
                    ingame4.coin5.Visible = false;
                    ingame4.coin5.Tag = "";
                    ingame4.coin6.Visible = false;
                    ingame4.coin6.Tag = "";
                    ingame4.coin7.Visible = false;
                    ingame4.coin7.Tag = "";
                    ingame4.coin8.Visible = false;
                    ingame4.coin8.Tag = "";
                    ingame4.coin9.Visible = false;
                    ingame4.coin9.Tag = "";
                    ingame4.coin10.Visible = false;
                    ingame4.coin10.Tag = "";
                    break;
                case 5:
                    ingame5.coin1.Visible = false;
                    ingame5.coin1.Tag = "";
                    ingame5.coin2.Visible = false;
                    ingame5.coin2.Tag = "";
                    ingame5.coin3.Visible = false;
                    ingame5.coin3.Tag = "";
                    ingame5.coin4.Visible = false;
                    ingame5.coin4.Tag = "";
                    ingame5.coin5.Visible = false;
                    ingame5.coin5.Tag = "";
                    ingame5.coin6.Visible = false;
                    ingame5.coin6.Tag = "";
                    ingame5.coin7.Visible = false;
                    ingame5.coin7.Tag = "";
                    ingame5.coin8.Visible = false;
                    ingame5.coin8.Tag = "";
                    ingame5.coin9.Visible = false;
                    ingame5.coin9.Tag = "";
                    ingame5.coin10.Visible = false;
                    ingame5.coin10.Tag = "";
                    break;
                case 51:
                    ingame51.coin1.Visible = false;
                    ingame51.coin1.Tag = "";
                    ingame51.coin2.Visible = false;
                    ingame51.coin2.Tag = "";
                    ingame51.coin3.Visible = false;
                    ingame51.coin3.Tag = "";
                    ingame51.coin4.Visible = false;
                    ingame51.coin4.Tag = "";
                    ingame51.coin5.Visible = false;
                    ingame51.coin5.Tag = "";
                    ingame51.coin6.Visible = false;
                    ingame51.coin6.Tag = "";
                    ingame51.coin7.Visible = false;
                    ingame51.coin7.Tag = "";
                    ingame51.coin8.Visible = false;
                    ingame51.coin8.Tag = "";
                    ingame51.coin9.Visible = false;
                    ingame51.coin9.Tag = "";
                    ingame51.coin10.Visible = false;
                    ingame51.coin10.Tag = "";
                    break;

            }



        }

        public void countPoint()
        {
            if (score >= 10 && score < 20 && lvl == 1)
            {
                offCoin(1);
            }
            else if (score >= 20 && score < 30 && lvl == 1)
            {
                offCoin(1);
                offChest(1);
            }
            else if (score >= 30 && lvl == 1)
            {
                offCoin(1);
                offEnemy(1);
                offChest(1);
            }
            else if (score >= 40 && score < 50 && lvl == 2)
            {
                offCoin(2);
            }
            else if (score >= 50 && score < 60 && lvl == 2)
            {
                offCoin(2);
                offChest(2);
            }
            else if (score >= 60 && lvl == 2)
            {
                offCoin(2);
                offChest(2);

                offEnemy(2);
                offEnemy(3);
            }
            else if (score >= 70 && score < 80 && lvl == 3)
            {
                offCoin(3);
            }
            else if (score >= 80 && score < 90 && lvl == 3)
            {
                offCoin(3);
                offChest(3);
            }
            else if (score >= 100 && score < 110 && lvl == 4)
            {
                offCoin(4);
            }
            else if (score >= 110 && lvl == 4)
            {
                offCoin(4);
                offChest(4);
            }
            else if (score >= 120 && score < 130 && lvl == 5)
            {
                offCoin(5);
            }
            else if (score >= 130 && lvl == 5)
            {
                offCoin(5);
                offChest(5);
            }
            else if (score >= 140 && score < 150 && lvl == 51)
            {
                offCoin(51);
            }
            else if (score >= 150 && lvl == 51)
            {
                offCoin(51);
                offChest(51);
            }

        }

        public void scorePlus(int i)
        {
            score += i;
            if (lvl == 1)
            {
                ingame.lbScore.Text = score.ToString();
            }
            if (lvl == 2)
            {
                ingame2.lbScore.Text = score.ToString();
            }
            if (lvl == 3)
            {
                ingame3.lbScore.Text = score.ToString();
            }
            if (lvl == 4)
            {
                ingame4.lbScore.Text = score.ToString();
            }
            if (lvl == 5)
            {
                ingame5.lbScore.Text = score.ToString();
            }
            if (lvl == 51)
            {
                ingame51.lbScore.Text = score.ToString();
            }
            if (lvl == 6)
            {
                ingame6.lbScore.Text = score.ToString();
            }
            if (lvl == 7)
            {
                ingame7.lbScore.Text = score.ToString();
            }

        }
        #endregion

        //------------------\\

        #region Item

        public void getItem(int index = 0)
        {
            switch (index)
            {
                case 1://Schlüssel
                    key1 = true;
                    loadKey();
                    break;
            }
        }

        public void getExtraHeart(int index)
        {
            switch (index)
            {
                case 1:
                    if (health == 1)
                    {
                        health = health + 1;
                        if (lvl == 5)
                        {
                            ingame5.pbHeart2.Visible = true;
                        }
                    }
                    if (health == 2)
                    {
                        health = health + 1;
                        if (lvl == 5)
                        {
                            ingame5.pbHeart3.Visible = true;
                        }
                    }
                    break;
                case 2:
                    if (health == 1)
                    {
                        health = health + 1;
                        if (lvl == 51)
                        {
                            ingame5.pbHeart2.Visible = true;
                        }
                    }
                    if (health == 2)
                    {
                        health = health + 1;
                        if (lvl == 51)
                        {
                            ingame5.pbHeart3.Visible = true;
                        }
                    }
                    break;
            }

        }

        public void loadKey()
        {
            if (key1 == true)
            {
                if (lvl == 1)
                {
                    ingame.pbkey1.Visible = true;
                }
                if (lvl == 2)
                {
                    ingame2.pbkey1.Visible = true;

                }
                if (lvl == 3)
                {
                    bosshealth = 0;
                    ingame3.pbkey1.Visible = true;
                }
                if (lvl == 4)
                {
                    ingame4.pbkey1.Visible = true;
                }
                if (lvl == 5)
                {
                    ingame5.pbkey1.Visible = true;
                }
                if (lvl == 51)
                {
                    ingame51.pbkey1.Visible = true;
                }
                if (lvl == 6)
                {
                    ingame6.pbkey1.Visible = true;
                }
                if (lvl == 7)
                {
                    ingame7.pbkey1.Visible = true;
                }
            }
        }
        #endregion


        #endregion

        //------------------\\

        #region Music
        public void playMusic(int index = 1)
        {
            switch (index)
            {
                case 1:
                    simpleSound.URL = Application.StartupPath + @"\Music\kakariko-village.wav";
                    simpleSound.controls.play();
                    simpleSound.settings.volume = 10;
                    break;
                case 2:
                    simpleSound.URL = Application.StartupPath + @"\Music\Dungeon Boss.wav";
                    simpleSound.controls.play();
                    bossmusic = true;
                    simpleSound.settings.volume = 5;
                    break;
            }
        }

        public void stopMusic()
        {
            simpleSound.controls.stop();
        }
        #endregion

    }
}
