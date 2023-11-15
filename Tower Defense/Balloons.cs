using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tower_Defense
{
    internal class Balloons
    {
        public async Task Movement(Bitmap type, List<int> path, List<PictureBox> tiles, Form formInstance)
        {
            await Task.Delay(50);
            var Square = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Black,
                Image = type,
                Location = new Point(tiles[path[1]].Location.X + (tiles[path[1]].Width / 2), tiles[path[1]].Location.Y + (tiles[path[1]].Height / 2)),
            };
            formInstance.Controls.Add(Square);

        }
    }
}
