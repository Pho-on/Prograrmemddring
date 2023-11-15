using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Snake_Game
{

    public partial class Form1 : Form
    {
        DrawBoard drawBoard;

        string direction = "Right";
        int lastSquare;


        List<PictureBox> squaresList = new List<PictureBox>(144);
        List<int> snakeSquares = new List<int>();
        List<int> borderLeft = new List<int>();
        List<int> borderRight = new List<int>();

        Random rng = new Random();
        int fruitSquare;

        Label lblGameOver = new Label
        {
            Text = "Game Over!",
            Size = new Size(70, 20),
            Location = new Point(260, 210),
            ForeColor = Color.White,
            AccessibleName = "lblGameOver",
        };

        Button btnPlayAgain = new Button
        {
            Text = "Play Again",
            Size = new Size(200, 80),
            Location = new Point(204, 234),
            Enabled = true,
            BackColor = Color.White,
            AccessibleName = "btnPlayAgain",
            Cursor = Cursors.Hand,
        };

        Button btnQuitGame = new Button
        {
            Text = "Quit Game",
            Size = new Size(200, 80),
            Location = new Point(204, 319),
            Enabled = true,
            BackColor = Color.White,
            AccessibleName = "btnQuitGame",
            Cursor = Cursors.Hand,
        };

        public Form1()
        {


            btnPlayAgain.Click += btnPlayAgain_Click;
            btnQuitGame.Click += btnQuitGame_Click;
            InitializeComponent();

            snakeSquares.Add(74); snakeSquares.Add(75); snakeSquares.Add(76);

            drawBoard = new DrawBoard();

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    PictureBox Square = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Black,
                        Size = new Size(45, 45),
                        Location = new Point(drawBoard.Xcoordinates[i, j], drawBoard.Ycoordinates[i, j]),
                        AccessibleName = i.ToString() + j.ToString(),
                    };
                    squaresList.Add(Square);
                    this.Controls.Add(Square);
                }
            }

            for (int i = 1; i < 12; i++)
            {
                if (i != 1) { borderRight.Add(i * 11 + i - 1); }
                else { borderRight.Add(i * 11); }
                borderLeft.Add(i * 12);
            }

            squaresList[snakeSquares[0]].BackColor = Color.Blue;
            squaresList[snakeSquares[1]].BackColor = Color.Blue;
            squaresList[snakeSquares[2]].BackColor = Color.Blue;

            CreateFruit();
        }

        void EatFruit()
        {
            if (snakeSquares.Last() == fruitSquare)
            {
                snakeSquares = snakeSquares.Prepend(lastSquare).ToList();

                CreateFruit();
            }
        }

        void CreateFruit()
        {
            fruitSquare = rng.Next(0, 144);
            if (snakeSquares.Contains(fruitSquare)) { CreateFruit(); }
            else squaresList[fruitSquare].BackColor = Color.LightGreen;
        }

        bool Colission()
        {
            bool fail;

            var inSelf = snakeSquares.GetRange(0, snakeSquares.Count - 2).Contains(snakeSquares[snakeSquares.Count - 1]);
            var outside = snakeSquares[snakeSquares.Count - 1] > 143 || snakeSquares[snakeSquares.Count - 1] < 0;
            var outRight = borderRight.Contains(snakeSquares[snakeSquares.Count - 2]) && borderLeft.Contains(snakeSquares[snakeSquares.Count - 1]);
            var outLeft = borderLeft.Contains(snakeSquares[snakeSquares.Count - 2]) && borderRight.Contains(snakeSquares[snakeSquares.Count - 1]);
            if (inSelf || outside || outRight || outLeft)
            {
                tmrGameTick.Enabled = false;
                snakeSquares.Clear();

                for (int i = 0; i < 144; i++)
                {
                    squaresList[i].BackColor = Color.Black;
                    squaresList[i].Visible = false;
                }
                this.Controls.Add(lblGameOver);
                lblGameOver.Visible = true;
                this.Controls.Add(btnPlayAgain);
                btnPlayAgain.Visible = true;
                this.Controls.Add(btnQuitGame);
                btnQuitGame.Visible = true;
                this.BackColor = Color.Black;
                fail = true;
            }
            else { fail = false; }

            return fail;
        }
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(lblGameOver);
            lblGameOver.Visible = false;
            this.Controls.Remove(btnPlayAgain);
            btnPlayAgain.Visible = false;
            this.Controls.Remove(btnQuitGame);
            btnQuitGame.Visible = false;

            this.BackColor = Color.White;

            for (int i = 0; i < 144; i++)
            {
                squaresList[i].Visible = true;
                squaresList[i].BringToFront();
            }
            lastSquare = 0;
            direction = "Right";
            snakeSquares.Add(74); snakeSquares.Add(75); snakeSquares.Add(76);

            squaresList[snakeSquares[0]].BackColor = Color.Blue;
            squaresList[snakeSquares[1]].BackColor = Color.Blue;
            squaresList[snakeSquares[2]].BackColor = Color.Blue;

            CreateFruit();
            tmrGameTick.Enabled = true;
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void tmrGameTick_Tick(object sender, EventArgs e)
        {
            if (direction == "Up")
            {
                squaresList[snakeSquares[0]].BackColor = Color.Black;
                EatFruit();
                lastSquare = snakeSquares[0];
                snakeSquares.RemoveAt(0);
                snakeSquares.Add(snakeSquares[snakeSquares.Count - 1] - 12);
                if (Colission() == false)
                {
                    squaresList[snakeSquares.Last()].BackColor = Color.Blue;
                }
            }
            if (direction == "Left")
            {
                squaresList[snakeSquares[0]].BackColor = Color.Black;
                EatFruit();
                lastSquare = snakeSquares[0];
                snakeSquares.RemoveAt(0);
                snakeSquares.Add(snakeSquares[snakeSquares.Count - 1] - 1);
                if (Colission() == false)
                {
                    squaresList[snakeSquares.Last()].BackColor = Color.Blue;
                }
            }
            if (direction == "Down")
            {
                squaresList[snakeSquares[0]].BackColor = Color.Black;
                EatFruit();
                lastSquare = snakeSquares[0];
                snakeSquares.RemoveAt(0);
                snakeSquares.Add(snakeSquares[snakeSquares.Count - 1] + 12);
                if (Colission() == false)
                {
                    squaresList[snakeSquares.Last()].BackColor = Color.Blue;
                }
            }
            if (direction == "Right")
            {
                squaresList[snakeSquares[0]].BackColor = Color.Black;
                EatFruit();
                lastSquare = snakeSquares[0];
                snakeSquares.RemoveAt(0);
                snakeSquares.Add(snakeSquares[snakeSquares.Count - 1] + 1);
                if (Colission() == false)
                {
                    squaresList[snakeSquares.Last()].BackColor = Color.Blue;
                }
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && direction != "Down")
            {
                direction = "Up";
            }
            if (e.KeyCode == Keys.A && direction != "Right")
            {
                direction = "Left";
            }
            if (e.KeyCode == Keys.S && direction != "Up")
            {
                direction = "Down";
            }
            if (e.KeyCode == Keys.D && direction != "Left")
            {
                direction = "Right";
            }
        }
    }
}
