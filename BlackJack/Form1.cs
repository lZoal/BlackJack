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
            d_com.Add(dealer0); d_com.Add(dealer1); d_com.Add(dealer2); d_com.Add(dealer3); d_com.Add(dealer4); d_com.Add(dealer5); 
        }

        private void Form1_Load(object sender, EventArgs e) // 처음 로드 했을 때 카드 두장씩 불러오기
        {
            c_user[0].Load(card.deck[cnt++].Second); //유저 0번째 1번째 불러오기
            c_user[1].Load(card.deck[cnt++].Second);
            d_com[0].Load("./img/52.png"); // 딜러패 첫장은 비공개
            cnt++;
            d_com[1].Load(card.deck[cnt++].Second);  //딜러패 두째장
            uservalue = card.deck[0].First + card.deck[1].First; //유저패 총합
            dealervalue = card.deck[2].First + card.deck[3].First; //딜러패 총합
            
            if ((card.deck[0].First==1 || card.deck[1].First==1) && uservalue<21) // A(에이스) 카드는 1 또는 11로 처리함 즉 value 값이 1 인경우 == A 인경우
            {
                 textBox1.Text = (uservalue).ToString()+", " + (card.deck[0].First + card.deck[ 1].First+10).ToString() ;
            }
            else
            textBox1.Text = (card.deck[0].First + card.deck[1].First).ToString();

            if ((card.deck[2].First == 1 || card.deck[3].First == 1) && uservalue < 21)
            {
                textBox4.Text = (uservalue).ToString() + ", " + (card.deck[0].First + card.deck[ 1].First + 10).ToString();
            }
            else
                textBox4.Text = (card.deck[2].First + card.deck[3].First).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d_com[0].Load(card.deck[2].Second);
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
            {
                textBox1.Text = uservalue.ToString() + " 21 초과로 패배";
                button1.Enabled = false;
            }



        }
    }
}
