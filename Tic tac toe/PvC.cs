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
    public partial class PlayerVsComputer : Form
    {
        private int _xTaskai { get; set; }
        private int _oTaskai { get; set; }
        Random rnd = new Random();
        private int veiksmas { get; set; }

        public PlayerVsComputer()
        {
            InitializeComponent();
            _xTaskai = 0;
            _oTaskai = 0;
        }

        private void a1_Click(object sender, EventArgs e)
        {
            a1.Enabled = false;
            a1.Text = "X";
            veiksmas = rnd.Next(1, 10);

            if (Tikrinimas() == false)
            {
                KompiuterioEjimas();
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            a2.Enabled = false;
            a2.Text = "X";
            veiksmas = rnd.Next(1, 10);

            if (Tikrinimas() == false)
            {
                KompiuterioEjimas();
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            a3.Enabled = false;
            a3.Text = "X";
            veiksmas = rnd.Next(1, 10);

            if (Tikrinimas() == false)
            {
                KompiuterioEjimas();
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.Enabled = false;
            b1.Text = "X";
            veiksmas = rnd.Next(1, 10);

            if (Tikrinimas() == false)
            {
                KompiuterioEjimas();
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.Enabled = false;
            b2.Text = "X";
            veiksmas = rnd.Next(1, 10);

            if (Tikrinimas() == false)
            {
                KompiuterioEjimas();
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.Enabled = false;
            b3.Text = "X";
            veiksmas = rnd.Next(1, 10);

            if (Tikrinimas() == false)
            {
                KompiuterioEjimas();
            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            c1.Enabled = false;
            c1.Text = "X";
            veiksmas = rnd.Next(1, 10);

            if (Tikrinimas() == false)
            {
                KompiuterioEjimas();
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            c2.Enabled = false;
            c2.Text = "X";
            veiksmas = rnd.Next(1, 10);

            if (Tikrinimas() == false)
            {
                KompiuterioEjimas();
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            c3.Enabled = false;
            c3.Text = "X";
            veiksmas = rnd.Next(1, 10);

            if (Tikrinimas() == false)
            {
                KompiuterioEjimas();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            IsNaujo();
        }

        private void IsNaujo()
        {
            a1.Enabled = true;
            a2.Enabled = true;
            a3.Enabled = true;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            c1.Enabled = true;
            c2.Enabled = true;
            c3.Enabled = true;

            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";

            a1.BackColor = SystemColors.ControlLight;
            a2.BackColor = SystemColors.ControlLight;
            a3.BackColor = SystemColors.ControlLight;
            b1.BackColor = SystemColors.ControlLight;
            b2.BackColor = SystemColors.ControlLight;
            b3.BackColor = SystemColors.ControlLight;
            c1.BackColor = SystemColors.ControlLight;
            c2.BackColor = SystemColors.ControlLight;
            c3.BackColor = SystemColors.ControlLight;

        }

        private void KompiuterioEjimas()
        {
            if (ArTicTacToe("O") == false)
            {
                if (ArTicTacToe("X") == false)
                {
                    if (PirmasVeiksmas() == false)
                    {
                        Betkur(veiksmas);
                    }
                }
            }
            Tikrinimas();
        }

        private bool ArTicTacToe(string xArbaO)
        {
            // pirmos eilutes tikrinimas
            if (a1.Text == xArbaO && a2.Text == xArbaO && string.IsNullOrEmpty(a3.Text))
            {
                a3.Enabled = false;
                a3.Text = "O";
                return true;
            }

            else if (a1.Text == xArbaO && a3.Text == xArbaO && string.IsNullOrEmpty(a2.Text))
            {
                a2.Enabled = false;
                a2.Text = "O";
                return true;
            }

            else if (a2.Text == xArbaO && a3.Text == xArbaO && string.IsNullOrEmpty(a1.Text))
            {
                a1.Enabled = false;
                a1.Text = "O";
                return true;
            }

            // antros eilutes tikrinimas (ar dar nekraujuoja akys?)
            else if (b1.Text == xArbaO && b2.Text == xArbaO && string.IsNullOrEmpty(b3.Text))
            {
                b3.Enabled = false;
                b3.Text = "O";
                return true;
            }

            else if (b1.Text == xArbaO && b3.Text == xArbaO && string.IsNullOrEmpty(b2.Text))
            {
                b2.Enabled = false;
                b2.Text = "O";
                return true;
            }

            else if (b2.Text == xArbaO && b3.Text == xArbaO && string.IsNullOrEmpty(b1.Text))
            {
                b1.Enabled = false;
                b1.Text = "O";
                return true;
            }

            // trecios eilutes tikrinimas (taip taip viskas būtų tilpę į vieną for)
            else if (c1.Text == xArbaO && c2.Text == xArbaO && string.IsNullOrEmpty(c3.Text))
            {
                c3.Enabled = false;
                c3.Text = "O";
                return true;
            }

            else if (c1.Text == xArbaO && c3.Text == xArbaO && string.IsNullOrEmpty(c2.Text))
            {
                c2.Enabled = false;
                c2.Text = "O";
                return true;
            }

            else if (c2.Text == xArbaO && c3.Text == xArbaO && string.IsNullOrEmpty(c1.Text))
            {
                c1.Enabled = false;
                c1.Text = "O";
                return true;
            }

            // pirmo stulpelio tikrinimas (HERE WE GO AGAIN)
            else if (a1.Text == xArbaO && b1.Text == xArbaO && string.IsNullOrEmpty(c1.Text))
            {
                c1.Enabled = false;
                c1.Text = "O";
                return true;
            }

            else if (a1.Text == xArbaO && c1.Text == xArbaO && string.IsNullOrEmpty(b1.Text))
            {
                b1.Enabled = false;
                b1.Text = "O";
                return true;
            }

            else if (b1.Text == xArbaO && c1.Text == xArbaO && string.IsNullOrEmpty(a1.Text))
            {
                a1.Enabled = false;
                a1.Text = "O";
                return true;
            }

            // antro stulpelio tikrinimas (tai vis dar nekraujuoja?)
            else if (a2.Text == xArbaO && b2.Text == xArbaO && string.IsNullOrEmpty(c2.Text))
            {
                c2.Enabled = false;
                c2.Text = "O";
                return true;
            }

            else if (a2.Text == xArbaO && c2.Text == xArbaO && string.IsNullOrEmpty(b2.Text))
            {
                b2.Enabled = false;
                b2.Text = "O";
                return true;
            }

            else if (b2.Text == xArbaO && c2.Text == xArbaO && string.IsNullOrEmpty(a2.Text))
            {
                a2.Enabled = false;
                a2.Text = "O";
                return true;
            }

            // trecio stulpelio tikrinimas (dabar jau tikrai turėtų kraujuot!)
            else if (a3.Text == xArbaO && b3.Text == xArbaO && string.IsNullOrEmpty(c3.Text))
            {
                c3.Enabled = false;
                c3.Text = "O";
                return true;
            }

            else if (a3.Text == xArbaO && c3.Text == xArbaO && string.IsNullOrEmpty(b3.Text))
            {
                b3.Enabled = false;
                b3.Text = "O";
                return true;
            }

            else if (b3.Text == xArbaO && c3.Text == xArbaO && string.IsNullOrEmpty(a3.Text))
            {
                a3.Enabled = false;
                a3.Text = "O";
                return true;
            }

            // pirmos istrižainės tikrinimas (dar kas nors skaito? man sakė, kad už 1000 eilučių bonusas)
            else if (a1.Text == xArbaO && b2.Text == xArbaO && string.IsNullOrEmpty(c3.Text))
            {
                c3.Enabled = false;
                c3.Text = "O";
                return true;
            }

            else if (a1.Text == xArbaO && c3.Text == xArbaO && string.IsNullOrEmpty(b2.Text))
            {
                b2.Enabled = false;
                b2.Text = "O";
                return true;
            }

            else if (b2.Text == xArbaO && c3.Text == xArbaO && string.IsNullOrEmpty(a1.Text))
            {
                a1.Enabled = false;
                a1.Text = "O";
                return true;
            }

            // antros istrižainės tikrinimas (argi čia daug to kodo?)
            else if (a3.Text == xArbaO && b2.Text == xArbaO && string.IsNullOrEmpty(c1.Text))
            {
                c1.Enabled = false;
                c1.Text = "O";
                return true;
            }

            else if (a3.Text == xArbaO && c1.Text == xArbaO && string.IsNullOrEmpty(b2.Text))
            {
                b2.Enabled = false;
                b2.Text = "O";
                return true;
            }

            else if (b2.Text == xArbaO && c1.Text == xArbaO && string.IsNullOrEmpty(a3.Text))
            {
                a3.Enabled = false;
                a3.Text = "O";
                return true;
            }
            else { return false; }
        }

        private bool PirmasVeiksmas()
        {
            if (a1.Text == "X" && string.IsNullOrEmpty(a2.Text + a3.Text + b1.Text + b2.Text + b3.Text + c1.Text + c2.Text + c3.Text))
            {
                c3.Enabled = false;
                c3.Text = "O";
                return true;
            }

            else if (a2.Text == "X" && string.IsNullOrEmpty(a1.Text + a3.Text + b1.Text + b2.Text + b3.Text + c1.Text + c2.Text + c3.Text))
            {
                b2.Enabled = false;
                b2.Text = "O";
                return true;
            }

            else if (a3.Text == "X" && string.IsNullOrEmpty(a1.Text + a2.Text + b1.Text + b2.Text + b3.Text + c1.Text + c2.Text + c3.Text))
            {
                c1.Enabled = false;
                c1.Text = "O";
                return true;
            }

            else if (b1.Text == "X" && string.IsNullOrEmpty(a1.Text + a2.Text + a3.Text + b2.Text + b3.Text + c1.Text + c2.Text + c3.Text))
            {
                b2.Enabled = false;
                b2.Text = "O";
                return true;
            }

            else if (b2.Text == "X" && string.IsNullOrEmpty(a1.Text + a2.Text + a3.Text + b1.Text + b3.Text + c1.Text + c2.Text + c3.Text))
            {
                a1.Enabled = false;
                a1.Text = "O";
                return true;
            }

            else if (b3.Text == "X" && string.IsNullOrEmpty(a1.Text + a2.Text + a3.Text + b1.Text + b2.Text + c1.Text + c2.Text + c3.Text))
            {
                b2.Enabled = false;
                b2.Text = "O";
                return true;
            }

            else if (c1.Text == "X" && string.IsNullOrEmpty(a1.Text + a2.Text + a3.Text + b1.Text + b2.Text + b3.Text + c2.Text + c3.Text))
            {
                a3.Enabled = false;
                a3.Text = "O";
                return true;
            }

            else if (c2.Text == "X" && string.IsNullOrEmpty(a1.Text + a2.Text + a3.Text + b1.Text + b2.Text + b3.Text + c2.Text + c3.Text))
            {
                b2.Enabled = false;
                b2.Text = "O";
                return true;
            }

            else if (c3.Text == "X" && string.IsNullOrEmpty(a1.Text + a2.Text + a3.Text + b1.Text + b2.Text + b3.Text + c1.Text + c2.Text))
            {
                a1.Enabled = false;
                a1.Text = "O";
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Betkur(int veiksmas)
        {
            while (true)
            {
                switch (veiksmas)
                {
                    case 1:
                        if (string.IsNullOrEmpty(b2.Text))
                        {
                            b2.Enabled = false; b2.Text = "O";
                            return false;
                        }
                        veiksmas++;
                        break;

                    case 2:
                        if (string.IsNullOrEmpty(a3.Text))
                        {
                            a3.Enabled = false; a3.Text = "O";
                            return false;
                        }
                        veiksmas++;
                        break;

                    case 3:
                        if (string.IsNullOrEmpty(a1.Text))
                        {
                            a1.Enabled = false; a1.Text = "O";
                            return false;
                        }
                        veiksmas++;
                        break;

                    case 4:
                        if (string.IsNullOrEmpty(c3.Text))
                        {
                            c3.Enabled = false; c3.Text = "O";
                            return false;
                        }
                        veiksmas++;
                        break;

                    case 5:
                        if (string.IsNullOrEmpty(c1.Text))
                        {
                            c1.Enabled = false; c1.Text = "O";
                            return false;
                        }
                        veiksmas++;
                        break;

                    case 6:
                        if (string.IsNullOrEmpty(a2.Text))
                        {
                            a2.Enabled = false; a2.Text = "O";
                            return false;
                        }
                        veiksmas++;
                        break;

                    case 7:
                        if (string.IsNullOrEmpty(b1.Text))
                        {
                            b1.Enabled = false; b1.Text = "O";
                            return false;
                        }
                        veiksmas++;
                        break;

                    case 8:
                        if (string.IsNullOrEmpty(b3.Text))
                        {
                            b3.Enabled = false; b3.Text = "O";
                            return false;
                        }
                        veiksmas++;
                        break;

                    case 9:
                        if (string.IsNullOrEmpty(c2.Text))
                        {
                            c2.Enabled = false; c2.Text = "O";
                            return false;
                        }
                        veiksmas++;
                        break;

                    default:
                        veiksmas = veiksmas - 8;
                        return false;
                }
            }
        }


        /*  // Betkur - be random
        //1
        if (string.IsNullOrEmpty(b2.Text))
        {
            b2.Enabled = false; b2.Text = "O";
            return true;
        }
        //2
        else if (string.IsNullOrEmpty(a3.Text))
        {
            a3.Enabled = false; a3.Text = "O";
            return true;
        }
        //3
        else if (string.IsNullOrEmpty(a1.Text))
        {
            a1.Enabled = false; a1.Text = "O";
            return true;
        }
        //4
        else if (string.IsNullOrEmpty(c3.Text))
        {
            c3.Enabled = false; c3.Text = "O";
            return true;
        }
        //5
        else if (string.IsNullOrEmpty(c1.Text))
        {
            c1.Enabled = false; c1.Text = "O";
            return true;
        }
        //6
        else if (string.IsNullOrEmpty(a2.Text))
        {
            a2.Enabled = false; a2.Text = "O";
            return true;
        }
        //7
        else if (string.IsNullOrEmpty(b1.Text))
        {
            b1.Enabled = false; b1.Text = "O";
            return true;
        }
        //8
        else if (string.IsNullOrEmpty(b3.Text))
        {
            b3.Enabled = false; b3.Text = "O";
            return true;
        }
        //9
        else if (string.IsNullOrEmpty(c2.Text))
        {
            c2.Enabled = false; c2.Text = "O";
            return true;
        }
        else { return false; }
    }

    */

        private bool Tikrinimas()
        {
            if (a1.Text == a2.Text && a2.Text == a3.Text && !string.IsNullOrEmpty(a2.Text))
            {
                ViskaIsjungti();
                if (a2.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                a1.BackColor = Color.Red;
                a2.BackColor = Color.Red;
                a3.BackColor = Color.Red;
                return true;
            }

            else if (b1.Text == b2.Text && b2.Text == b3.Text && !string.IsNullOrEmpty(b2.Text))
            {
                ViskaIsjungti();
                if (b2.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                b1.BackColor = Color.Red;
                b2.BackColor = Color.Red;
                b3.BackColor = Color.Red;
                return true;
            }


            else if (c1.Text == c2.Text && c2.Text == c3.Text && !string.IsNullOrEmpty(c2.Text))
            {
                ViskaIsjungti();
                if (c2.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                c1.BackColor = Color.Red;
                c2.BackColor = Color.Red;
                c3.BackColor = Color.Red;
                return true;
            }

            else if (a1.Text == b1.Text && b1.Text == c1.Text && !string.IsNullOrEmpty(b1.Text))
            {
                ViskaIsjungti();
                if (b1.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                a1.BackColor = Color.Red;
                b1.BackColor = Color.Red;
                c1.BackColor = Color.Red;
                return true;
            }

            else if (a2.Text == b2.Text && b2.Text == c2.Text && !string.IsNullOrEmpty(b2.Text))
            {
                ViskaIsjungti();
                if (b2.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                a2.BackColor = Color.Red;
                b2.BackColor = Color.Red;
                c2.BackColor = Color.Red;
                return true;
            }

            else if (a3.Text == b3.Text && b3.Text == c3.Text && !string.IsNullOrEmpty(b3.Text))
            {
                ViskaIsjungti();
                if (b3.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                a3.BackColor = Color.Red;
                b3.BackColor = Color.Red;
                c3.BackColor = Color.Red;
                return true;
            }

            else if (a1.Text == b2.Text && b2.Text == c3.Text && !string.IsNullOrEmpty(b2.Text))
            {
                ViskaIsjungti();
                if (b2.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                a1.BackColor = Color.Red;
                b2.BackColor = Color.Red;
                c3.BackColor = Color.Red;
                return true;
            }

            else if (a3.Text == b2.Text && b2.Text == c1.Text && !string.IsNullOrEmpty(b2.Text))
            {
                ViskaIsjungti();
                if (b2.Text == "X")
                {
                    _xTaskai++;
                    labelXscore.Text = _xTaskai.ToString();
                }
                else
                {
                    _oTaskai++;
                    labelOscore.Text = _oTaskai.ToString();
                }
                a3.BackColor = Color.Red;
                b2.BackColor = Color.Red;
                c1.BackColor = Color.Red;
                return true;
            }
            else { return false; }
        }

        private void ViskaIsjungti()
        {
            a1.Enabled = false;
            a2.Enabled = false;
            a3.Enabled = false;
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            IsNaujo();
            _xTaskai = 0;
            _oTaskai = 0;
            labelXscore.Text = 0.ToString();
            labelOscore.Text = 0.ToString();
        }

        private void žaistiPrieKitąŽaidėjąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerVsPlayer pvp = new PlayerVsPlayer();
            _xTaskai = 0;
            _oTaskai = 0;
            labelXscore.Text = 0.ToString();
            labelOscore.Text = 0.ToString();
            this.Close();
            pvp.ShowDialog();
        }

        private void naujasŽaidimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsNaujo();
            _xTaskai = 0;
            _oTaskai = 0;
            labelXscore.Text = 0.ToString();
            labelOscore.Text = 0.ToString();
        }

        private void gryžtiĮPradinįMeniuToolStripMenuItem_Click(object sender, EventArgs e)
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
