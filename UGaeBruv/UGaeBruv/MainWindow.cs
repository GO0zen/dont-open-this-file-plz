using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGaeBruv
{
    public partial class MainWindow : Form
    {
        Random rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BackGroundImage;
        }

        private void YesButton_MouseEnter(object sender, EventArgs e)
        {
             YesButton.BackgroundImage = Properties.Resources.Anton;            
        }

        private void YesButton_MouseLeave(object sender, EventArgs e)
        {
            YesButton.BackgroundImage = null;
        }

        private void NoButton_MouseEnter(object sender, EventArgs e)
        {
            NoButton.BackgroundImage = Properties.Resources.SadPepe;
            int a = rand.Next(0, 200);
            int b = rand.Next(0, 200);
            NoButton.Location = new Point(a, b);
        }

        private void NoButton_MouseLeave(object sender, EventArgs e)
        {
            NoButton.BackgroundImage = null;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            SubWindow SubWindow = new SubWindow();
            SubWindow.Show();
            this.Hide();
        }
    }
}
