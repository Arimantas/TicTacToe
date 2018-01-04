using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonPvP_Click(object sender, EventArgs e)
        {
            PlayerVsPlayer pvp = new PlayerVsPlayer();
            this.Hide();
            pvp.ShowDialog();
            this.Show();
        }

        private void buttonPvC_Click(object sender, EventArgs e)
        {
            PlayerVsComputer pvc = new PlayerVsComputer();
            this.Hide();
            pvc.ShowDialog();
            this.Show();
        }
    }
}
