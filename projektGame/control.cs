using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace projektGame
{
    public class control
    {
        /*
        InGame game = null;

        Adventure mainmenu = null;

        //-----------------------\\

        int health = 3;


        //-----------------------\\

        public control(InGame game0)
        {
            game = game0;
        }

        public control(Adventure adventure0)
        {
            mainmenu = adventure0;
        }

        //-----------------------\\


        public void takedamage(int damage)
        {
            health = health - damage;
            if(health <= 0)
            {
                die();
            }
            if (health == 1)
            {
                game.pbHeart2.Visible = false;
            }
            if (health == 2)
            {
                game.pbHeart3.Visible = false;               
            }

        }
        


        public void die()
        {          
            game.lbScore.Text = "0";

            game.lbGameover.Text = "GAME OVER";
            game.lbGameover.Visible = true;

           

            health = 3;
            game.pbHeart1.Visible = true;
            game.pbHeart2.Visible = true;
            game.pbHeart3.Visible = true;

            safepointL = 550;
            safepointT = 250;
        }


        //-----------------------\\

        #region save and load

        private string name;
        public void setname(string pName)
        {
            name = pName;
        }

        public void save()
        {

            string path = Application.StartupPath + @"\Playerlist\" + name + ".txt";

            string content = ":" + (game.Link.Location.X).ToString() + (game.Link.Location.Y).ToString();

            /*
            File.WriteAllText(pathPlayer, save);
            */
        /*
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(content);
            sw.Dispose();

        }




        public void load()
        {
            
            string path = Directory.GetCurrentDirectory();
            string pathSpeicher = Path.Combine(path + @"\Playerlist\" + name + ".txt");


            try
            {
                string pos = File.ReadLines(pathSpeicher).Skip(0).Take(1).First();

                string[] posXY = (pos.Split(':'));

                int x = Convert.ToInt32(posXY[0]);
                int y = Convert.ToInt32(posXY[1]);

                void Linkloadpos()
                {
                    game.Link.Top = y;
                    game.Link.Top = x;
                }

                Linkloadpos();


                mainmenu.btLevel.PerformClick();

            }
            catch (FileNotFoundException)
            {
                mainmenu.lbDiagnosis.Text = "This User, doesn't exist";
            }
        }
        #endregion 



    */

    }
}