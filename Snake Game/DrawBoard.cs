using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    internal class DrawBoard
    {

        private int[,] xCoordinates = new int[12, 12];
        private int[,] yCoordinates = new int[12, 12];


        public DrawBoard()
        {
            SetCoordinatews(xCoordinates, yCoordinates);
        }

        public int[,] Xcoordinates
        {
            get { return xCoordinates; }
            set { xCoordinates = value; }
        }

        public int[,] Ycoordinates
        {
            get { return yCoordinates; }
            set { yCoordinates = value; }
        }


        private void SetCoordinatews(int[,] xCoordinates, int[,] yCoordinates)
        {
            int x = 3; int y = 3;

            for (int i = 0; i < 12; i++)
            {
                x = 3;
                for (int j = 0; j < 12; j++)
                {
                    xCoordinates[i, j] = x;
                    yCoordinates[i, j] = y;
                    x += 48;
                }
                y += 48;
            }

        }
    }
}
