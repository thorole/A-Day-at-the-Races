using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdayAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        
        
        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                MessageBox.Show(Bettor.Name + " wins " + Amount + " bucks!");
                return Amount;
            }
            else
            {
                if (Amount == 0)
                {
                    MessageBox.Show(Bettor.Name + " didn't place any bet");
                }
                else
                MessageBox.Show(Bettor.Name + " loses " + Amount + " bucks!");
                return -Amount;
            }
        }
        
            
            
            

        public string GetDescription()
        {
            if (Amount == 0)
            {
                string noBetMessage = Bettor.Name + " hasn't placed a bet";
                return noBetMessage;
            }
            else
            {
                string betMessage = Bettor.Name + " bets " + Amount + " bucks on dog #" + Dog;
                return betMessage;
            }
        }

       
    }
}
