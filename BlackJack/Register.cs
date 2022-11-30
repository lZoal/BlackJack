using System;
using System.IO;
using System.Windows.Forms;

namespace BlackJack
{

    public partial class Register : Form
    {
        private LogIn _Form2;
        public string[] ID = { };
        public string[] nickname = { };
        private bool isID = true;
        private bool isNickname = true;

        public Register(LogIn form2)
        {
            _Form2 = form2;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isID == false && isNickname == false)
            {
                StreamWriter writer1;
                StreamWriter writer2;
                StreamWriter writer3;
                writer1 = File.AppendText("ID.txt");        //Text File이 저장될 위치(파일명)
                writer2 = File.AppendText("Password.txt");        //Text File이 저장될 위치(파일명)
                writer3 = File.AppendText("Nickname.txt");        //Text File이 저장될 위치(파일명)
                                                                  //파일 이름만 지정하면 컴파일된 폴더내 해당 파일 이름으로 저장됨
                writer1.WriteLine(textBox1.Text);    //저장될 string
                writer1.Close();
                writer2.WriteLine(textBox2.Text);    //저장될 string
                writer2.Close();
                writer3.WriteLine(textBox3.Text);    //저장될 string
                writer3.Close();

                this.Close();
            }
            else
            {
                MessageBox.Show("회원정보를 다시 입력해주세요.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path1 = @"ID.txt";
            ID = File.ReadAllLines(path1);
            if (textBox1.Text != "" && ID.Length > 0)
            {
                for (int i = 0; i < ID.Length; i++)
                {
                    if (textBox1.Text == ID[i])
                    {
                        isID = true;
                        MessageBox.Show("이미 사용중인 아이디입니다.");
                    }
                    else
                    {
                        isID = false;
                        MessageBox.Show("사용할 수 있는 아이디입니다.");
                    }
                }
            }
            else if (textBox1.Text != "")
            {
                isID = false;
                MessageBox.Show("사용할 수 있는 아이디입니다.");
            }
            else
            {
                MessageBox.Show("아이디를 입력해주세요.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path1 = @"Nickname.txt";
            nickname = File.ReadAllLines(path1);
            if (textBox3.Text != "" && nickname.Length > 0)
            {
                for (int i = 0; i < nickname.Length; i++)
                {
                    if (textBox3.Text == nickname[i])
                    {
                        isNickname = true;
                        MessageBox.Show("이미 사용중인 닉네임입니다.");
                    }
                    else
                    {
                        isNickname = false;
                        MessageBox.Show("사용할 수 있는 닉네임입니다.");
                    }
                }
            }
            else if (textBox3.Text != "")
            {
                isNickname = false;
                MessageBox.Show("사용할 수 있는 닉네임입니다..");
            }
            else
            {
                MessageBox.Show("닉네임를 입력해주세요.");
            }
        }
    }
}
