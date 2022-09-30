using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektGame.Menus
{
    public partial class Mainmenu : Form
    {
        gamecontroller gct = null;
        public Mainmenu(gamecontroller gct0)
        {
            InitializeComponent();
            gct = gct0;
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {
            
        }
        

        bool load0 = false;

        private void goToLevel()
        {
            btStart.Visible = true;

            lbName.Left = 112;
            lbName.Top = 184;

            tbName.Visible = false;
            lbName2.Text = tbName.Text;
            lbName2.Visible = true;

            btLoadProfile.Visible = false;
            btBackLauncher.Visible = true;

            lbDiagnosis.Visible = false;
            btLevel.Visible = false;
        }

        //--------------------\\

        #region Button        

        private void btNewPlayer_Click(object sender, EventArgs e)
        {
            gct.load0 = false;
            lbName.Visible = true;
            tbName.Visible = true;
            btLevel.Visible = true;
            btBackLauncher.Visible = true;

            lbName.Text = "New Player:";
            btNewPlayer.Visible = false;
            btOldPlayer.Visible = false;
        }

        private void btOldPlayer_Click(object sender, EventArgs e)
        {
            load0 = true;
            lbName.Visible = true;
            tbName.Visible = true;
            btBackLauncher.Visible = true;

            lbName.Text = "Name:";
            btLoadProfile.Visible = true;

            btNewPlayer.Visible = false;
            btOldPlayer.Visible = false;

        }

        private void btOptions_Click(object sender, EventArgs e)
        {
            gct.showOptions();

            this.Close();
        }     

        private void btBackLauncher_Click(object sender, EventArgs e)
        {

            {
                if (btStart.Visible == true && load0 == false)
                {

                    btStart.Visible = false;

                    lbName.Left = 100;
                    lbName.Top = 264;

                    tbName.Visible = true;

                    lbName2.Visible = false;

                    btLevel.Visible = true;

                }

                else if (btStart.Visible == true && load0 == true)
                {


                    btLoadProfile.Visible = true;

                    btStart.Visible = false;

                    tbName.Visible = true;
                    lbName2.Visible = false;
                    lbName.Left = 100;
                    lbName.Top = 264;


                }

                else if (btLevel.Visible == true)
                {
                    load0 = false;
                    btNewPlayer.Visible = true;
                    btOldPlayer.Visible = true;

                    btBackLauncher.Visible = false;
                    lbDiagnosis.Visible = false;

                    tbName.Visible = false;
                    lbName2.Visible = false;
                    //btBackLauncher.Visible = false;
                    lbName.Visible = false;
                    btLevel.Visible = false;

                    btLoadProfile.Visible = false;

                }

                else if (btLoadProfile.Visible == true)
                {
                    load0 = false;
                    btNewPlayer.Visible = true;
                    btOldPlayer.Visible = true;

                    btBackLauncher.Visible = false;
                    lbDiagnosis.Visible = false;
                    tbName.Visible = false;
                    lbName2.Visible = false;
                    //btBackLauncher.Visible = false;
                    lbName.Visible = false;
                    btLevel.Visible = false;

                    btLoadProfile.Visible = false;

                }



            }
        }

        private void btLevel_Click(object sender, EventArgs e)
        {
            gct.setname(tbName.Text);

            if (gct.isPlayerAlredyExisting() == false)
            {
                goToLevel();
                gct.goNewPlayer();
            }

        }

        private void btLoadProfile_Click(object sender, EventArgs e)
        {
            gct.setname(tbName.Text);


            if (gct.isPlayerExisting() == true)
            {
                gct.load();
                goToLevel();
            }

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            gct.setname(lbName2.Text);


            if (gct.lvl == 1)
            {
                gct.showInGame();
            }
            if (gct.lvl == 2)
            {
                gct.showInGame2();
            }
            if (gct.lvl == 3)
            {
                gct.showInGame3();
            }
            if (gct.lvl == 4)
            {
                gct.showInGame4();
            }
            if (gct.lvl == 5)
            {
                gct.showInGame5();
            }
            if (gct.lvl == 51)
            {
                gct.showInGame51();
            }
            if (gct.lvl == 6)
            {
                gct.showInGame6();
            }
            if (gct.lvl == 7)
            {
                gct.showInGame7();
            }
            gct.hideMainMenu();
        }

        private void btLauncherExit_Click(object sender, EventArgs e)
        {
            gamecontroller.quit();
        }
        #endregion

        //------------------\\

    }
}
