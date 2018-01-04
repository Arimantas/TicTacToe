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
    public partial class PlayerVsPlayer : Form
    {
        private int _kelintas { get; set; }
        private int _xTaskai { get; set; }
        private int _oTaskai { get; set; }

        public PlayerVsPlayer()
        {
            InitializeComponent();
            _kelintas = 1;
            _xTaskai = 0;
            _oTaskai = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (_kelintas % 2 == 0)
            {
                button1.Text = "X";
            }
            else
            {
                button1.Text = "O";
            }

            _kelintas++;
            Tikrinimas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (_kelintas % 2 == 0)
            {
                button2.Text = "X";
            }
            else
            {
                button2.Text = "O";
            }

            _kelintas++;
            Tikrinimas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            if (_kelintas % 2 == 0)
            {
                button3.Text = "X";
            }
            else
            {
                button3.Text = "O";
            }

            _kelintas++;
            Tikrinimas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (_kelintas % 2 == 0)
            {
                button4.Text = "X";
            }
            else
            {
                button4.Text = "O";
            }

            _kelintas++;
            Tikrinimas();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            if (_kelintas % 2 == 0)
            {
                button5.Text = "X";
            }
            else
            {
                button5.Text = "O";
            }

            _kelintas++;
            Tikrinimas();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            if (_kelintas % 2 == 0)
            {
                button6.Text = "X";
            }
            else
            {
                button6.Text = "O";
            }

            _kelintas++;
            Tikrinimas();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            if (_kelintas % 2 == 0)
            {
                button7.Text = "X";
            }
            else
            {
                button7.Text = "O";
            }

            _kelintas++;
            Tikrinimas();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            if (_kelintas % 2 == 0)
            {
                button8.Text = "X";
            }
            else
            {
                button8.Text = "O";
            }

            _kelintas++;
            Tikrinimas();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            if (_kelintas % 2 == 0)
            {
                button9.Text = "X";
            }
            else
            {
                button9.Text = "O";
            }

            _kelintas++;
            Tikrinimas();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            IsNaujo();
        }

        private void IsNaujo()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = SystemColors.ControlLight;
            button2.BackColor = SystemColors.ControlLight;
            button3.BackColor = SystemColors.ControlLight;
            button4.BackColor = SystemColors.ControlLight;
            button5.BackColor = SystemColors.ControlLight;
            button6.BackColor = SystemColors.ControlLight;
            button7.BackColor = SystemColors.ControlLight;
            button8.BackColor = SystemColors.ControlLight;
            button9.BackColor = SystemColors.ControlLight;

            _kelintas = 1;
        }

        private void Tikrinimas()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && !string.IsNullOrEmpty(button2.Text))
            {
                ViskaIsjungti();
                if (button2.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;

            }

            else if (button4.Text == button5.Text && button5.Text == button6.Text && !string.IsNullOrEmpty(button5.Text))
            {
                ViskaIsjungti();
                if (button5.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }


            else if (button7.Text == button8.Text && button8.Text == button9.Text && !string.IsNullOrEmpty(button8.Text))
            {
                ViskaIsjungti();
                if (button8.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            else if (button1.Text == button4.Text && button4.Text == button7.Text && !string.IsNullOrEmpty(button4.Text))
            {
                ViskaIsjungti();
                if (button4.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }

            else if (button2.Text == button5.Text && button5.Text == button8.Text && !string.IsNullOrEmpty(button5.Text))
            {
                ViskaIsjungti();
                if (button5.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }

            else if (button3.Text == button6.Text && button6.Text == button9.Text && !string.IsNullOrEmpty(button6.Text))
            {
                ViskaIsjungti();
                if (button6.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text && !string.IsNullOrEmpty(button5.Text))
            {
                ViskaIsjungti();
                if (button5.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            else if (button3.Text == button5.Text && button5.Text == button7.Text && !string.IsNullOrEmpty(button5.Text))
            {
                ViskaIsjungti();
                if (button5.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
        }

        private void ViskaIsjungti()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            IsNaujo();
            _xTaskai = 0;
            _oTaskai = 0;
            labelXscore.Text = 0.ToString();
            labelOscore.Text = 0.ToString();
        }

        private void žaistiPriešKompiuterįToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerVsComputer pvc = new PlayerVsComputer();
            _xTaskai = 0;
            _oTaskai = 0;
            labelXscore.Text = 0.ToString();
            labelOscore.Text = 0.ToString();
            this.Close();
            pvc.ShowDialog();
        }

        private void naujasŽaidimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsNaujo();
            _xTaskai = 0;
            _oTaskai = 0;
            labelXscore.Text = 0.ToString();
            labelOscore.Text = 0.ToString();
        }

        private void uždarytiProgramąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apie mp = new Apie();
            mp.ShowDialog();
        }
    }
}
