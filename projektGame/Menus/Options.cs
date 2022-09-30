using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace projektGame
{
    public partial class Options : Form
    {
        

        //public static WMPLib.WindowsMediaPlayer simpleSound = new WMPLib.WindowsMediaPlayer();

        gamecontroller gct = null;

        //----------------------------------------\\

        public Options(gamecontroller gct0, int index = 0)
        {
            InitializeComponent();

            

            gct = gct0;

            switch (index)
            {
                case 0:

                    break;

                case 1:
                    btOptionsContinue.Visible = true;
                    break;
            }
        }

        //----------------------------------------\\

        private void Options_Load(object sender, EventArgs e)
        {

        }

        //----------------------------------------\\

        #region buttons
        //weiter zum Menu 
        private void btOptionsContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //----------------------------------------\\

        // Das man zum Launcher kommt
        private void btOptionsToLau_Click(object sender, EventArgs e)
        {

            gct.showMainMenu();
            gct.hideInGame();
            gct.hideMenu();

            this.Close();

        }

        //----------------------------------------\\

        //Musik an
        private void btMusicOn_Click(object sender, EventArgs e)
        {
            gct.playMusic();
        }


        //----------------------------------------\\

        //Musik aus
        private void btMusicOff_Click(object sender, EventArgs e)
        {            
            gct.stopMusic();
        }
        #endregion

        //----------------------------------------\\

        //Musik steuern in der Lautstärke
        private void trbVolumeMusic_Scroll(object sender, EventArgs e)
        {
            gamecontroller.simpleSound.controls.play();
            gamecontroller.simpleSound.settings.volume = trbVolumeMusic.Value;
        }


        //----------------------------------------\\

    }
}
