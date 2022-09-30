using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektGame
{
    public partial class Menu : Form
    {

        gamecontroller gct = null;

        //------------------\\

        public Menu(gamecontroller gct0)
        {
            InitializeComponent();

            gct = gct0;
        }


        //------------------\\

        #region buttons
        private void btMenuContinue_Click(object sender, EventArgs e)
        {
            gct.load();
            if (gct.lvl == 1)
            {
                gct.showInGame();
            }
            else if (gct.lvl == 2)
            {
                gct.showInGame2();
            }
            else if (gct.lvl == 3)
            {
                gct.showInGame3();
            }
            else if (gct.lvl == 4)
            {
                gct.showInGame4();
            }
            else if (gct.lvl == 5)
            {
                gct.showInGame5();
            }
            else if (gct.lvl == 51)
            {
                gct.showInGame51();
            }
            else if (gct.lvl == 6)
            {
                gct.showInGame6();
            }
            else if (gct.lvl == 7)
            {
                gct.showInGame7();
            }

            this.Close();
        }

        //------------------\\

        private void btMenuSave_Click(object sender, EventArgs e)
        {
            gct.save();

            pbseeSave.BackColor = Color.Green;
        }

        //------------------\\

        private void btMenuOpt_Click(object sender, EventArgs e)
        {
            gct.showOptions(1);
              
        }

        //------------------\\

        private void btMenuLau_Click(object sender, EventArgs e)
        {
            gct.showMainMenu();

            gct.hideInGame();
            gct.hideMenu();
            gct.hideOptions();
        }
        #endregion

        //------------------\\

    }
}
