using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(3);
            Porcentaje.Text = progressBar1.Value.ToString() + "%";

            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.ShowDialog();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
