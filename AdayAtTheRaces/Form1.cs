using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdayAtTheRaces
{
    public partial class Form1 : Form
    {
        GreyHound[] GreyHoundArray = new GreyHound[4];
        Random MyRandomizer = new Random();
        Guy[] GuyArray = new Guy[3];
        
        public Form1()
        {
            InitializeComponent();
            
            //Instantiate four greyhound objects
           
            GreyHoundArray[0] = new GreyHound()
            {
                MyPictureBox = pictureDog1,
                StartingPosition = pictureDog1.Left,
                RaceTrackLength = raceTrackPictureBox.Width - pictureDog1.Width,
                Randomizer = MyRandomizer
            };
            GreyHoundArray[1] = new GreyHound()
            {
                MyPictureBox = pictureDog2,
                StartingPosition = pictureDog2.Left,
                RaceTrackLength = raceTrackPictureBox.Width - pictureDog2.Width,
                Randomizer = MyRandomizer
            };
            GreyHoundArray[2] = new GreyHound()
            {
                MyPictureBox = pictureDog3,
                StartingPosition = pictureDog3.Left,
                RaceTrackLength = raceTrackPictureBox.Width - pictureDog3.Width,
                Randomizer = MyRandomizer
            };
            GreyHoundArray[3] = new GreyHound()
            {
                MyPictureBox = pictureDog4,
                StartingPosition = pictureDog4.Left,
                RaceTrackLength = raceTrackPictureBox.Width - pictureDog4.Width,
                Randomizer = MyRandomizer
            };

            //Instantiate three guy objects
            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                MyBet = new Bet(),
                Cash = 50,
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel
            };
            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                MyBet = new Bet(),
                Cash = 75,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
                
            };
            GuyArray[2] = new Guy()
            {
                Name = "Al",
                MyBet = new Bet(),
                Cash = 45,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
                
            };

            for (int i = 0; i < GuyArray.Length; i++)
            {
                GuyArray[i].UpdateLabels();
                GuyArray[i].ClearBet();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                groupBox1.Enabled = false;
            }
           
            for (int i = 0; i < GreyHoundArray.Length; i++)
            {
                
                if (GreyHoundArray[i].Run())
                {
                    int winningDog = i + 1;
                    timer1.Stop();
                    MessageBox.Show("Dog number " + (i + 1) + " won the race!");
                    i = GreyHoundArray.Length;
                    
                    for (int g = 0; g < GuyArray.Length; g++)
                    {
                        GuyArray[g].Collect(winningDog);
                    }
                    for (int s = 0; s < GreyHoundArray.Length; s++)
                    {
                        GreyHoundArray[s].TakeStartingPosition();
                    }
                    groupBox1.Enabled = true;
                }
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = GuyArray[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = GuyArray[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = GuyArray[2].Name;
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            int numericBet = Convert.ToInt32(numericUpDownBucks.Value);
            int numericDog = Convert.ToInt32(numericUpDown2.Value);

            if (joeRadioButton.Checked == true)
            {
                if (GuyArray[0].PlaceBet(numericBet, numericDog))
                {
                    GuyArray[0].UpdateLabels();
                }
            }

            if (bobRadioButton.Checked == true)
            {
                if (GuyArray[1].PlaceBet(numericBet, numericDog))
                {
                    GuyArray[1].UpdateLabels();
                }
            }

            if (alRadioButton.Checked == true)
            {
                if (GuyArray[2].PlaceBet(numericBet, numericDog))
                {
                    GuyArray[2].UpdateLabels();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
           
        
        
                    
            
            
            
            

           
           
                
            
                

            

            


            
                
                
            
           
                    
           
                    
                    
            
                  

            



            
       
                        
                        
                         
        
       
            
            
