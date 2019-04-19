using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdayAtTheRaces
{
    public class GreyHound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
       
        public bool Run()
        {
            Location = MyPictureBox.Left + Randomizer.Next(5);
            MyPictureBox.Left = StartingPosition + Location;
            if (MyPictureBox.Left >= RaceTrackLength - MyPictureBox.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
            

            


         
