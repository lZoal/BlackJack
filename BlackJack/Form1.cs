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
        static float winratio=0;
        static int cnt = 0,win=0,lose=0,draw=0, uservalue = 0,dealervalue=0,usercnt=2;
        static bool ua = false, da = false;
        List<PictureBox> c_user=new List<PictureBox>(), d_com = new List<PictureBox>();
        TrumpCard card = new TrumpCard();

        void InitGame()
        {
            ua = false;da = false;
            button1.Enabled = true; //버튼 활성화
            button2.Enabled = true;
            button3.Enabled = false;
            cnt = 0; uservalue = 0; dealervalue = 0;usercnt = 2;
            textBox2.Text = "";
            textBox3.Text = win + "승 " + draw + "무 " + lose + "패";
            card.init_swit(); card.suffle_deck();
            for(int i = 2; i <= 5; i++)
            {
                c_user[i].Visible = false;
                d_com[i].Visible = false;
            }
            card.init_swit();
            card.suffle_deck();
            c_user[0].Load(card.deck[cnt++].Second); //유저 0번째 1번째 불러오기
            c_user[1].Load(card.deck[cnt++].Second);
            d_com[0].Load("./img/52.png"); // 딜러패 첫장은 비공개
            cnt++;
            d_com[1].Load(card.deck[cnt++].Second);  //딜러패 두째장
            uservalue = card.deck[0].First + card.deck[1].First; //유저패 총합
            dealervalue = card.deck[2].First + card.deck[3].First; //딜러패 총합

            if ((card.deck[0].First == 1 || card.deck[1].First == 1) && uservalue+10 <= 21) // A(에이스) 카드는 1 또는 11로 처리 초기처리는 높은수인 11로 처리 카드를 더받을경우 21초과시 1로처리
            {
                uservalue += 10;
                textBox1.Text = (uservalue).ToString();
                ua = true;

            }
            else
                textBox1.Text = (card.deck[0].First + card.deck[1].First).ToString();

            if (( card.deck[3].First == 1 || card.deck[2].First==1) && dealervalue+10 <= 21) 
            {
                dealervalue += 10;
                textBox1.Text = (uservalue).ToString();
                da = true;

            }
            textBox4.Text = card.deck[3].First.ToString() + " + ?";
        }
        void HitCard()
        {
            c_user[usercnt].Visible = true;
            c_user[usercnt++].Load(card.deck[++cnt].Second);
            uservalue = uservalue + card.deck[cnt].First;
         if (uservalue >21 && ua )
            {
                uservalue -= 10;

            }
            textBox1.Text = uservalue.ToString();
            if (uservalue > 21 )
            {
                textBox1.Text = uservalue.ToString();
                textBox2.Text = "패배";
                lose++;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                textBox3.Text = win + "승 " + draw + "무 " + lose + "패";
                winratio = ((float)win / ((float)win + (float)lose)) * 100;
                textBox5.Text = winratio.ToString() + "%";
            }



        }
        void StandGame()
        {
            d_com[0].Load(card.deck[2].Second);
            int i = 2;
            while (dealervalue <= 16)
            {
                d_com[i].Visible = true;
                d_com[i].Load(card.deck[cnt].Second);
                dealervalue += card.deck[cnt].First;
                if (dealervalue > 21 && da)
                {
                    dealervalue -= 10;
                }


            }
            textBox4.Text = dealervalue.ToString();
            if ((dealervalue < uservalue && uservalue <= 21) || dealervalue > 21)
            {
                textBox2.Text = "승리";
                win++;
            }
            else if (dealervalue > uservalue)
            {
                textBox2.Text = "패배";
                lose++;
            }

            else
            {
                draw++;
                textBox2.Text = "무승부";
            }
            textBox3.Text = win + "승 " + draw + "무 " + lose + "패";
            winratio = ((float)win / ((float)win + (float)lose) )*100;
            textBox5.Text = winratio.ToString()+"%";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
            c_user.Add(user0); c_user.Add(user1); c_user.Add(user2); c_user.Add(user3); c_user.Add(user4); c_user.Add(user5);
            d_com.Add(dealer0); d_com.Add(dealer1); d_com.Add(dealer2); d_com.Add(dealer3); d_com.Add(dealer4); d_com.Add(dealer5); 
        }

        private void Form1_Load(object sender, EventArgs e) // 처음 로드 했을 때 카드 두장씩 불러오기
        {
            InitGame();
        }

        private void button2_Click(object sender, EventArgs e) //멈추고 결과확인버튼
        {
            StandGame();
        }

        private void button3_Click(object sender, EventArgs e) //다시하기 버튼
        {
            InitGame();  
        }

        private void button1_Click(object sender, EventArgs e) // 유저 카드 받기 버튼 Hit
        {
            HitCard();

        }
    }
}
