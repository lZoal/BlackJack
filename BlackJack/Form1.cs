using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        static float winratio = 0;
        static int cnt = 0, win = 0, lose = 0, draw = 0, uservalue = 0, dealervalue = 0, usercnt = 2;
        static int wincnt = 0, numcnt = 0;
        static bool ua = false, da = false;


        List<PictureBox> c_user = new List<PictureBox>(), d_com = new List<PictureBox>();
        TrumpCard card = new TrumpCard();
        private Boolean m_blLoginCheck = false;
        public int[] num = new int[100];
        public int index;
        public string[] rank = { };
        public string[] rankIndex = { };
        public string[] nickname = { };

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 _Form = new Form4(this);
            _Form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 _Form = new Form5(this);
            _Form.ShowDialog();
        }

        public Boolean LoginCheck
        {
            get { return m_blLoginCheck; }
            set { m_blLoginCheck = value; }
        }
        void Btn_set()//버튼 상태
        {
            button1.Enabled = !button1.Enabled;
            button2.Enabled = !button2.Enabled;
            button3.Enabled = !button3.Enabled;
        }
        void InitGame()//게임 초기설정
        {
            ua = false; da = false;
            Btn_set();
            cnt = 0; uservalue = 0; dealervalue = 0; usercnt = 2;
            textBox2.Text = "";
            textBox3.Text = win + "승 " + draw + "무 " + lose + "패";
            card.init_swit(); card.suffle_deck();
            for (int i = 2; i <= 5; i++)
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

            if ((card.deck[0].First == 1 || card.deck[1].First == 1) && uservalue + 10 <= 21) // A(에이스) 카드는 1 또는 11로 처리 초기처리는 높은수인 11로 처리 카드를 더받을경우 21초과시 1로처리
            {
                uservalue += 10;
                textBox1.Text = (uservalue).ToString();
                ua = true;

            }
            else
                textBox1.Text = (card.deck[0].First + card.deck[1].First).ToString();

            if ((card.deck[3].First == 1 || card.deck[2].First == 1) && dealervalue + 10 <= 21)
            {
                dealervalue += 10;
                textBox1.Text = (uservalue).ToString();
                da = true;

            }
            textBox4.Text = card.deck[3].First !=1?card.deck[3].First.ToString() + " + ?": (card.deck[3].First+10).ToString();
        }
        void HitCard()
        {
            cnt++;
            c_user[usercnt].Visible = true;
            c_user[usercnt++].Load(card.deck[++cnt].Second);
            uservalue = uservalue + card.deck[cnt].First;
            if (uservalue > 21 && ua)
            {
                uservalue -= 10;
                ua = false;

            }
            textBox1.Text = uservalue.ToString();
            if (uservalue > 21)
            {
                textBox1.Text = uservalue.ToString();
                textBox2.Text = "패배";
                lose++;
                num[numcnt] = wincnt;
                if (wincnt != 0)
                {
                    StreamWriter writer1;
                    StreamWriter writer2;
                    writer1 = File.AppendText("Rank.txt");
                    writer2 = File.AppendText("NicknameIndex.txt");
                    writer1.WriteLine(num[numcnt]);
                    writer2.WriteLine(index);
                    writer1.Close();
                    writer2.Close();
                }
                numcnt++;
                wincnt = 0;
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
            cnt++;
            while (dealervalue <= 16)
            {
                d_com[i].Visible = true;
                d_com[i++].Load(card.deck[cnt].Second);
                if (card.deck[cnt].First == 1)
                {
                    dealervalue += card.deck[cnt].First + 10;
                    da = true;
                }
                else
                    dealervalue += card.deck[cnt].First;
                cnt++;
                
                if (dealervalue > 21 && da) //a가있을때 
                {
                    dealervalue -= 10;
                    da = false;
                }
            }
            textBox4.Text = dealervalue.ToString();
            if ((dealervalue < uservalue && uservalue <= 21) || dealervalue > 21)
            {
                textBox2.Text = "승리";
                win++;
                wincnt++;
            }
            else if (dealervalue > uservalue)
            {
                textBox2.Text = "패배";
                lose++;
                num[numcnt] = wincnt;
                if (wincnt != 0)
                {
                    StreamWriter writer1;
                    StreamWriter writer2;
                    writer1 = File.AppendText("Rank.txt");
                    writer2 = File.AppendText("NicknameIndex.txt");
                    writer1.WriteLine(num[numcnt]);
                    writer2.WriteLine(index);
                    writer1.Close();
                    writer2.Close();
                }
                numcnt++;
                wincnt = 0;
            }

            else
            {
                draw++;
                textBox2.Text = "무승부";
            }
            textBox3.Text = win + "승 " + draw + "무 " + lose + "패";
            winratio = ((float)win / ((float)win + (float)lose)) * 100;
            textBox5.Text = winratio.ToString() + "%";
            Btn_set();
        }

        public Form1()
        {
            InitializeComponent();
            c_user.Add(user0); c_user.Add(user1); c_user.Add(user2); c_user.Add(user3); c_user.Add(user4); c_user.Add(user5);
            d_com.Add(dealer0); d_com.Add(dealer1); d_com.Add(dealer2); d_com.Add(dealer3); d_com.Add(dealer4); d_com.Add(dealer5);
        }

        private void Form1_Load(object sender, EventArgs e) // 처음 로드 했을 때 카드 두장씩 불러오기
        {
            Form2 _Form = new Form2(this);
            _Form.ShowDialog();
            button1.Enabled=false;
            button2.Enabled = false;
            if (!m_blLoginCheck) this.Close();
            InitGame();
            string path1 = @"Nickname.txt";
            nickname = File.ReadAllLines(path1);
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
