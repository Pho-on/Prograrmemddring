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

namespace Tower_Defense
{
    public partial class Form1 : Form
    {
        Balloons balloons = new Balloons();

        List<PictureBox> tileList = new List<PictureBox>();
        List<int> pathList = new List<int>();
        List<int> waterBoundingList = new List<int>();
        List<int> waterList = new List<int>();

        Random rng = new Random();

        //Balloons:
        Bitmap RedBloon = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\red_balloon.png");

        public Form1()
        {
            InitializeComponent();

            //Land Tiles
            Bitmap Path = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\sand_tile.png");
            Bitmap GrassDark = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\grass_tile_1.png");
            Bitmap GrassMedium = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\grass_tile_2.png");
            Bitmap GrassLight = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\grass_tile_3.png");
            //Bitmap BushTile = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\bush_tile.png");

            //Water Tiles:
            Bitmap FullWater = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\WaterTiles\47.png");
            Bitmap MovingWater = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\WaterTiles\48.png");
            Bitmap WaterBottomLeft = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\WaterTiles\17.png");
            Bitmap WaterBottomRight = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\WaterTiles\23.png");
            Bitmap WaterTopLeft = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\WaterTiles\1.png");
            Bitmap WaterTopRight = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\WaterTiles\4.png");
            Bitmap WaterSide = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\WaterTiles\12.png");
            Bitmap WaterPad = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\WaterTiles\46.png");
            Bitmap WaterTop = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\WaterTiles\3.png");

            Bitmap BridgeTile = new Bitmap(@"C:\Users\Emil\Documents\Sprites\Sprites\bridge_tile.png");

            

            int Size = (ClientSize.Height - 20) / 12;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    PictureBox Tile = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Black,
                        Size = new Size(Size, Size),
                        Location = new Point(10 + (j * Size), 10 + (i * Size)),
                        Image = GrassMedium,
                    };
                    //Tile.Click += Tile_Click;
                    tileList.Add(Tile);
                    Controls.Add(Tile);
                }
            }
            int grass;
            foreach (PictureBox pbx in tileList)
            {
                Thread.Sleep(1);
                grass = rng.Next(1, 4);
                switch (grass)
                {
                    case 1:
                        pbx.Image = GrassDark;
                        break;

                    case 2:
                        pbx.Image = GrassMedium;
                        break;

                    case 3:
                        pbx.Image = GrassLight;
                        break;


                    default:
                        break;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                pathList.Add(1 + (i * 12));
            }
            for (int i = 62; i < 66; i++)
            {
                pathList.Add(i);
            }
            for (int i = 0; i < 3; i++)
            {
                pathList.Add(53 - (i * 12));
            }
            for (int i = 30; i < 34; i++)
            {
                pathList.Add(i);
            }
            for (int i = 0; i < 7; i++)
            {
                pathList.Add(45 + (12 * i));
            }
            pathList.Add(116);
            pathList.Add(115);
            foreach (int pathTile in pathList)
            {
                tileList[pathTile].Image = Path;
            }

            



            for (int i = 72; i < 79; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    waterList.Add(i + (j * 12));
                }
            }
            //waterList.Remove();

            for (int i = 0; i < 7; i++)
            {
                waterBoundingList.Add(60 + i);
                waterBoundingList.Add(79 + (i * 12));
            }
            waterBoundingList.Sort();
            waterBoundingList.RemoveAt(13);

            int waterPicture;
            foreach (int waterTile in waterList)
            {
                if (waterBoundingList.Contains(waterTile - 12) && waterBoundingList.Contains(waterTile + 1))
                {
                    tileList[waterTile].Image = WaterTopRight;
                }
                else if (waterBoundingList.Contains(waterTile - 12)) { tileList[waterTile].Image = WaterTop; }
                else if (waterBoundingList.Contains(waterTile + 1)) { tileList[waterTile].Image = WaterSide; }
                else
                {
                    Thread.Sleep(1);
                    waterPicture = rng.Next(1, 5);
                    switch (waterPicture)
                    {
                        case 1:
                            tileList[waterTile].Image = FullWater;
                            break;

                        case 2:
                            tileList[waterTile].Image = MovingWater;
                            break;

                        case 3:
                            tileList[waterTile].Image = MovingWater;
                            break;

                        case 4:
                            tileList[waterTile].Image = WaterPad;
                            break;
                        default:
                            break;
                    }
                }
            }
            //Bridge:
            for (int i = 114; i > 109; i--)
            {
                pathList.Add(i);
                tileList[i].Image = BridgeTile;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            balloons.Movement(RedBloon, pathList, tileList, this);
        }
    }
}
