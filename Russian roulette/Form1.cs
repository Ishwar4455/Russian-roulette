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
using System.IO;
using System.Reflection;

namespace Russian_roulette
{
    public partial class Restart:Form
    {


        donali G1 = new donali();// Defining the object (G1) of the Game Class

        public Restart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
            
        {
            //coding for shoot sound//
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_roulette.Properties.Resources.shoot);
            snd.Play();

            btn_Load.Enabled = false;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = true;
            btn_Shootaway.Enabled = true;
            //coding for images//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Russian_roulette.Resources.bobby.gif");
            Bitmap bmp = new Bitmap(myStream);
            pictureBox1.Image = bmp;
        }

        
        private void Button1_Click(object sender, EventArgs e)
        {


            {

                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_roulette.Properties.Resources.gun_cocking_02);
                snd.Play();

                //Calling Load function from Game Class
                btn_Load.Enabled = false; // Disabling Load button
                btn_Spin.Enabled = true;
                btn_Shoot.Enabled = false;
                btn_Shootaway.Enabled = false;
                //coding for images//
                Assembly myAssembly = Assembly.GetExecutingAssembly();
                Stream myStream = myAssembly.GetManifestResourceStream("Russian_roulette.Resources.load.gif");
                Bitmap bmp = new Bitmap(myStream);
                pictureBox1.Image = bmp;
                
            }
            

        }

        private void Btn_Spin_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_roulette.Properties.Resources.lovee);
            snd.Play();


            btn_Load.Enabled = false;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = true;
            btn_Shootaway.Enabled = true;
            //coding for images//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Russian_roulette.Resources.spin.gif");
            Bitmap bmp = new Bitmap(myStream);
            pictureBox1.Image = bmp;

        }

        private void Btn_Shootaway_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_roulette.Properties.Resources.jonn);
            snd.Play();
            btn_Load.Enabled = false;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = true;
            btn_Shootaway.Enabled = true;
            //coding for images//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Russian_roulette.Resources.shootaway.gif");
            Bitmap bmp = new Bitmap(myStream);
            pictureBox1.Image = bmp;
        }

        private void Playagain_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            btn_Load.Enabled = true;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = false;
            btn_Shootaway.Enabled = false;

        }
    }
}
        