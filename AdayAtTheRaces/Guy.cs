using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdayAtTheRaces
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
       

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
            MyLabel.Text = Name + " bets " + MyBet.Amount + " bucks on #" + MyBet.Dog;

        }
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this };  

            if (BetAmount <= Cash)
            {
                MessageBox.Show(MyBet.GetDescription());
                
                return true;
            }
            else
            {
                if (Cash == 0)
                {
                    MessageBox.Show(Name + " is broke");
                }
                else
            MessageBox.Show(Name + " doesn't have enough money");
            return false;
                
                
            }
        }
        public void ClearBet() 
        {
           MyBet = new Bet() { Amount = 0, Bettor = this };
           MyLabel.Text = Name + " hasn't placed a bet";
        }
        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            
            UpdateLabels();
            ClearBet();


        }
    }
}
