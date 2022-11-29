using System;
using System.IO;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form2 : Form
    {
        private Form1 _Form1;

        public string[] ID = { };
        public string[] password = { };
        public string[] nickname = { };
        public int num;

        public Form2(Form1 form1)
        {
            _Form1 = form1;
            InitializeComponent();
        }

        private void bt_OK()
        {
            string path1 = @"ID.txt";
            string path2 = @"Password.txt";
            string path3 = @"Nickname.txt";
            ID = File.ReadAllLines(path1);
            password = File.ReadAllLines(path2);
            nickname = File.ReadAllLines(path3);

            if (ID.Length > 0)
            {
                for (int i = 0; i < ID.Length; i++)
                {
                    if (textBox1.Text == ID[i])
                    {
                        // 저장할 때 아이디가 0번째면 비번도 0번째 이런식이니까 ID[0]일 때 password[0]이면 로그인 성공
                        if (textBox1.Text.Equals(ID[i]) && textBox2.Text.Equals(password[i]))
                        {
                            MessageBox.Show("로그인 성공");
                            _Form1.LoginCheck = true;
                            _Form1.index = i;
                            this.Close();
                            return;
                        }
                        else if (textBox1.Text.Equals(ID[i]) && !textBox2.Text.Equals(password[i]))
                        {
                            MessageBox.Show("비밀번호가 틀렸습니다.");
                            return;
                        }
                    }
                }
                MessageBox.Show("아이디 정보가 맞지 않습니다.");
            }
            else
            {
                MessageBox.Show("회원가입을 먼저 해주세요.");

                textBox1.Text = "아이디를 입력해 주세요.";
                textBox2.Text = "비밀번호를 입력해 주세요.";
                textBox2.PasswordChar = '\0';
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bt_OK();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 _Form = new Form3(this);
            _Form.ShowDialog();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "아이디를 입력해 주세요.") textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) e.SuppressKeyPress = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textBox2.Focus();
                if (textBox2.Text == "비밀번호를 입력해 주세요.")
                {
                    textBox2.Text = "";
                    textBox2.PasswordChar = '*';

                    if (textBox2.Text == "")
                    {
                        textBox2.Text = "비밀번호를 입력해 주세요.";
                        textBox2.PasswordChar = '\0';
                    }
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "아이디를 입력해 주세요.";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox2.PasswordChar = '*';
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "비밀번호를 입력해 주세요.")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) e.SuppressKeyPress = true;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) bt_OK();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "비밀번호를 입력해 주세요.";
                textBox2.PasswordChar = '\0';
            }
        }
    }
}
