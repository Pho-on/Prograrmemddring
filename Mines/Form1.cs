using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mines
{
    public partial class Form1 : Form
    {
        int newMine;
        bool gaming = false;
        List<PictureBox> squaresList = new List<PictureBox>();
        List<int> minesList = new List<int>();

        Bitmap Diamond = new Bitmap(@"C:\Users\Emil\Documents\Programering\Min programering\Mines\Images\minesdiamond.png");
        //Bitmap Mine = new Bitmap(@"C:\Users\Emil\Documents\Programering\Min programering\Mines\Images\minesbomb.jpg");
        Bitmap Mine = new Bitmap(@"C:\Users\Emil\Downloads\image-removebg-preview (1).jpg");

        Random rng = new Random();
        double Field = 49, Diamonds, Mines = 15;
        decimal multi, Win, p = 1;


        public Form1()
        {
            InitializeComponent();
            btnMines3.ForeColor = Color.Blue;
            drawBoard((int)Math.Sqrt(Field));
            foreach (PictureBox square in squaresList)
            {
                square.Enabled = false;
            }
        }

        void drawBoard(int amount)
        {
            int Size = 300 / amount;
            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < amount; j++)
                {
                    PictureBox Square = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Black,
                        Size = new Size(Size, Size),
                        Location = new Point(42 + (i * Size) + (2 * i), 36 + (j * Size) + (2 * j)),
                    };
                    Square.Click += Square_Click;
                    squaresList.Add(Square);
                    Controls.Add(Square);
                }
            }
            for (int i = 0; i < squaresList.Count - 1; i++)
            {
                squaresList[i].Enabled = true;
            }
            for (int i = 0; i < Mines; i++)
            {
                newMines();
            }
            Diamonds = Field - Mines;
        }

        void newMines()
        {
            newMine = rng.Next((int)Field);
            if (!minesList.Contains(newMine))
            {
                minesList.Add(newMine);
            }
            else
            {
                newMines();
            }
        }

        void enableButtons(bool maybe)
        {
            btnMines1.Enabled = maybe;
            btnMines2.Enabled = maybe;
            btnMines3.Enabled = maybe;
            btnMines4.Enabled = maybe;

            rbtn3x3.Enabled = maybe;
            rbtn5x5.Enabled = maybe;
            rbtn7x7.Enabled = maybe;
            rbtn9x9.Enabled = maybe;

            tbxMinesCustom.Enabled = maybe;
            tbxInsats.Enabled = maybe;
        }

        private void tbxSaldo_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsStringValid(tbxSaldo.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    tbxSaldo.Enabled = false;
                    enableButtons(true);
                }
            }
        }

        void Square_Click(object sender, EventArgs e)
        {
            var square = (sender as PictureBox);
            square.Enabled = false;
            if (minesList.Contains(squaresList.IndexOf(square)))
            {
                square.Image = Mine;
                lose();
                p = 1;
            }
            else
            {
                p = Math.Round(p * (decimal)(Diamonds / (Diamonds + Mines)), 10);
                multi = (decimal)0.99 / p;
                Win = multi * decimal.Parse(tbxInsats.Text);
                btnInsats.Text = "Ta ut " + Math.Round(Win, 2);
                square.Image = Diamond;
                Diamonds--;
            }
        }

        void win()
        {
            enableButtons(true);
            btnInsats.Text = "Insats";
            tbxSaldo.Text = Math.Round(decimal.Parse(tbxSaldo.Text) + Win, 2).ToString();
            foreach (int item in minesList)
            {
                squaresList[item].Image = Mine;
            }
            for (int i = 0; i < squaresList.Count - 1; i++)
            {
                squaresList[i].Enabled = false;
            }
            minesList.Clear();
            p = 1;
        }

        void lose()
        {
            btnInsats.Text = "Insats";
            gaming = false;
            foreach (int item in minesList)
            {
                squaresList[item].Image = Mine;
            }
            for (int i = 0; i < squaresList.Count - 1; i++)
            {
                squaresList[i].Enabled = false;
            }
            enableButtons(true);
            minesList.Clear();
            p = 1;
        }

        private void btnMines1_Click(object sender, EventArgs e)
        {
            btnInsats.Text = "Insats";
            Mines = int.Parse(btnMines1.Text);
            Diamonds = Field - Mines;
            btnMines1.ForeColor = Color.Blue;
            btnMines2.ForeColor = Color.Black;
            btnMines3.ForeColor = Color.Black;
            btnMines4.ForeColor = Color.Black;
            tbxMinesCustom.ForeColor = Color.Black;
        }

        private void btnMines2_Click(object sender, EventArgs e)
        {
            btnInsats.Text = "Insats";
            Mines = int.Parse(btnMines2.Text);
            Diamonds = Field - Mines;
            btnMines1.ForeColor = Color.Black;
            btnMines2.ForeColor = Color.Blue;
            btnMines3.ForeColor = Color.Black;
            btnMines4.ForeColor = Color.Black;
            tbxMinesCustom.ForeColor = Color.Black;
        }

        private void btnMines3_Click(object sender, EventArgs e)
        {
            btnInsats.Text = "Insats";
            Mines = int.Parse(btnMines3.Text);
            Diamonds = Field - Mines;
            btnMines1.ForeColor = Color.Black;
            btnMines2.ForeColor = Color.Black;
            btnMines3.ForeColor = Color.Blue;
            btnMines4.ForeColor = Color.Black;
            tbxMinesCustom.ForeColor = Color.Black;
        }

        private void btnMines4_Click(object sender, EventArgs e)
        {
            btnInsats.Text = "Insats";
            Mines = int.Parse(btnMines4.Text);
            Diamonds = Field - Mines;
            btnMines1.ForeColor = Color.Black;
            btnMines2.ForeColor = Color.Black;
            btnMines3.ForeColor = Color.Black;
            btnMines4.ForeColor = Color.Blue;
            tbxMinesCustom.ForeColor = Color.Black;
        }

        private void rbtn3x3_CheckedChanged(object sender, EventArgs e)
        {
            Field = 9;
            btnMines1.Text = "1";
            btnMines2.Text = "2";
            btnMines3.Text = "3";
            btnMines4.Text = "4";
        }

        private void tbxMinesCustom_TextChanged(object sender, EventArgs e)
        {
            if (IsStringValid(tbxMinesCustom.Text))
            {
                if (int.Parse(tbxMinesCustom.Text) < Field)
                {
                    btnInsats.Text = "Insats";
                    Mines = double.Parse(tbxMinesCustom.Text);
                    btnMines1.ForeColor = Color.Black;
                    btnMines2.ForeColor = Color.Black;
                    btnMines3.ForeColor = Color.Black;
                    btnMines4.ForeColor = Color.Black;
                    tbxMinesCustom.ForeColor = Color.Blue;
                }
                else
                {
                    btnInsats.Text = "För många minor";
                }
            }
            
        }
        bool IsStringValid(string s)
        {
            return int.TryParse(s, out int result);
        }

        private void rbtn5x5_CheckedChanged(object sender, EventArgs e)
        {
            Field = 25;
            btnMines1.Text = "1";
            btnMines2.Text = "3";
            btnMines3.Text = "5";
            btnMines4.Text = "7";
        }

        private void rbtn7x7_CheckedChanged(object sender, EventArgs e)
        {
            Field = 49;
            btnMines1.Text = "1";
            btnMines2.Text = "5";
            btnMines3.Text = "10";
            btnMines4.Text = "15";
        }

        private void tbxInsats_TextChanged(object sender, EventArgs e)
        {
            if (IsStringValid(tbxInsats.Text))
            {
                if (double.Parse(tbxInsats.Text) < double.Parse(tbxSaldo.Text))
                {
                    btnInsats.Enabled = true;
                    btnInsats.Text = "Insats";
                }
                else
                {
                    btnInsats.Text = "För högt bet";
                    btnInsats.Enabled = true;
                }
            }
            
        }

        private void rbtn9x9_CheckedChanged(object sender, EventArgs e)
        {
            Field = 81;
            btnMines1.Text = "5";
            btnMines2.Text = "10";
            btnMines3.Text = "15";
            btnMines4.Text = "20";
        }

        private void btnInsats_Click(object sender, EventArgs e)
        {
            if (Mines < Field)
            {
                if (gaming == true)
                {
                    win();
                    gaming = false;
                    p = 1;
                }
                else if (!(double.Parse(tbxSaldo.Text) - double.Parse(tbxInsats.Text) < 0))
                {
                    foreach (PictureBox pbx in squaresList)
                    {
                        Controls.Remove(pbx);
                    }
                    squaresList.Clear();
                    minesList.Clear();
                    lblSaldo.Text = "Saldo:";
                    tbxSaldo.Text = Math.Round(double.Parse(tbxSaldo.Text) - double.Parse(tbxInsats.Text), 2).ToString();
                    enableButtons(false);
                    drawBoard((int)Math.Sqrt(Field));
                    btnInsats.Text = "Ta ut";
                    gaming = true;
                    p = 1;
                }
            }
            else
            {
                btnInsats.Text = "För många minor";
            }
        }
    }
}
