using System;
using System.Collections;
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
        static int cnt = 0;
        int uservalue = 0,dealervalue=0;
        List<PictureBox> c_user=new List<PictureBox>(), d_com = new List<PictureBox>();

        
    
        
        TrumpCard card = new TrumpCard();
        public Form1()
        {

            InitializeComponent();
            c_user.Add(user0); c_user.Add(user1); c_user.Add(user2); c_user.Add(user3); c_user.Add(user4); c_user.Add(user5);
            for (int i = 2; i < 6; i++)
            {
                c_user[i].Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        //int counting = 2;
        private void button1_Click(object sender, EventArgs e)
        {
            c_user[usercnt].BringToFront();
            c_user[usercnt].Visible = true;
            c_user[usercnt++].Load(card.deck[cnt++].Second);
            
            counting++;
            textBox3.Text = "남은 카드: " + (52 - cnt).ToString();
            uservalue = uservalue + card.deck[cnt].First;
            if(21>=uservalue)
                textBox1.Text = uservalue.ToString();
            else
                textBox1.Text = uservalue.ToString() +" 21 초과로 패배";

        }
      
    }
}
