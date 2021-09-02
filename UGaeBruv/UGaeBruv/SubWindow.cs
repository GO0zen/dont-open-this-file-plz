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
    public partial class SubWindow : Form
    {
        public SubWindow()
        {
            InitializeComponent();
        }

        private void SubWindow_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MainWindow test = new MainWindow();
            test.Close();
            this.Close();
        }
    }
}
