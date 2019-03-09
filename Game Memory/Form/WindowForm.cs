using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Game_Memory
{
    class Window
    {
        private const int WIDTH_SPACE = 120;
        private const int HEIGHT_SPACE = 70;

        private const int MID_WIDTH = 600;
        private const int MID_HEIGHT = 340;

        private const int MID_WIDTH_FLAG = 60;
        private const int MID_HEIGHT_FLAG = 35;

        public void setWindow(int count, int columns, int lines)
        {
            int initialPointX = calculateInitialPointX(columns);
            int pointX = initialPointX;
            int pointY = calculateInitialPointY(lines);
            int incrementPointY = columns;

            for (int i = 0; i < count; i++)
            {
                if (i == incrementPointY)
                {
                    incrementPointY += columns;
                    pointY += HEIGHT_SPACE;
                    pointX = initialPointX;
                }
                PictureBox picture = setPicture(pointX, pointY, i);
                picture.Click += new EventHandler(MainForm.form.imagem_Click);

                MainForm.form.Controls.Add(picture);
                pointX += WIDTH_SPACE;
            }
        }

        public int calculateInitialPointX(int amountColumns)
        {
            return MID_WIDTH - (MID_WIDTH_FLAG * amountColumns);
        }

        public int calculateInitialPointY(int amountLines)
        {
            return MID_HEIGHT - (MID_HEIGHT_FLAG * amountLines);
        }

        private PictureBox setPicture(int pointX, int pointY, int indice)
        {
            return new PictureBox
            {
                Name = FlagManipulation.flags.ElementAt(indice).name,
                Location = new Point(pointX, pointY),
                Image = FlagManipulation.doubt.image,
                Tag = FlagManipulation.flags.ElementAt(indice).tag,
            };
        }
    }
}
