using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        TrumpCard card = new TrumpCard();
        public Form1()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream

            pictureBox1.Load(card.deck[0].Second);
=======
           for(int i=2;i<c_user.Count;i++)
            {
                c_user[i].BackColor = Color.Transparent;
            }
            user0.Load(card.deck[cnt].Second);
            user1.Load(card.deck[cnt+1].Second);
            uservalue = card.deck[cnt].First + card.deck[cnt + 1].First;
            if ((card.deck[cnt].First==1 || card.deck[cnt+1].First==1))
            {
                 textBox1.Text = (uservalue).ToString()+", " + (card.deck[cnt].First + card.deck[cnt + 1].First+10).ToString() ;
            }
            else
            textBox1.Text = (card.deck[cnt].First + card.deck[cnt + 1].First).ToString();

            textBox2.Text = card.deck[cnt+=2].Second;
            textBox3.Text = "남은 카드: " + (52 - cnt).ToString();

        }
        int usercnt = 2;
        private void button1_Click(object sender, EventArgs e)
        {
            
            c_user[usercnt++].Load(card.deck[++cnt].Second);
            textBox3.Text = "남은 카드: " + (52 - cnt).ToString();
            uservalue = uservalue + card.deck[cnt].First;
            if(21>=uservalue)
                textBox1.Text = uservalue.ToString();
            else
                textBox1.Text = uservalue.ToString() +" 21 초과로 패배";
>>>>>>> Stashed changes

        }
    }
}
