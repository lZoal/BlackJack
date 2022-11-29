using System;
using System.IO;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form5 : Form
    {
        private Form1 _Form1;
        public string[] rank = { };
        public string[] nicknameIndex = { };
        public int[] num = new int[100];
        public int[] index = new int[100];
        public string[] nickname = { };
        int tmp;
        string tmp1;
        string tmp2;

        public Form5(Form1 form1)
        {
            _Form1 = form1;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string path1 = @"Rank.txt";
            string path2 = @"Nickname.txt";
            string path3 = @"NicknameIndex.txt";
            rank = File.ReadAllLines(path1);
            nickname = File.ReadAllLines(path2);
            nicknameIndex = File.ReadAllLines(path3);

            if (rank.Length > 0)
            {
                for (int i = 0; i < rank.Length; i++)
                {
                    if (rank[i] == "1")
                        num[i] = 1;
                    else if (rank[i] == "2")
                        num[i] = 2;
                    else if (rank[i] == "3")
                        num[i] = 3;
                    else if (rank[i] == "4")
                        num[i] = 4;
                    else if (rank[i] == "5")
                        num[i] = 5;
                    else if (rank[i] == "6")
                        num[i] = 6;
                    else if (rank[i] == "7")
                        num[i] = 7;
                    else if (rank[i] == "8")
                        num[i] = 8;
                    else if (rank[i] == "9")
                        num[i] = 9;
                    else if (rank[i] == "10")
                        num[i] = 10;
                }
                for (int i = 0; i < rank.Length; i++)
                {
                    for (int j = i + 1; j < rank.Length; j++)
                    {
                        if (num[i] < num[j])
                        {
                            tmp = num[i];
                            num[i] = num[j];
                            num[j] = tmp;
                            tmp1 = rank[i];
                            rank[i] = rank[j];
                            rank[j] = tmp1;
                            tmp2 = nicknameIndex[i];
                            nicknameIndex[i] = nicknameIndex[j];
                            nicknameIndex[j] = tmp2;
                        }
                    }
                    if (nicknameIndex[i] == "1")
                        index[i] = 1;
                    else if (nicknameIndex[i] == "2")
                        index[i] = 2;
                    else if (nicknameIndex[i] == "3")
                        index[i] = 3;
                    else if (nicknameIndex[i] == "4")
                        index[i] = 4;
                    else if (nicknameIndex[i] == "5")
                        index[i] = 5;
                    else if (nicknameIndex[i] == "6")
                        index[i] = 6;
                    else if (nicknameIndex[i] == "7")
                        index[i] = 7;
                    else if (nicknameIndex[i] == "8")
                        index[i] = 8;
                    else if (nicknameIndex[i] == "9")
                        index[i] = 9;
                    else if (nicknameIndex[i] == "10")
                        index[i] = 10;

                    label2.Text += i + 1 + ". " + nickname[index[i]] + " " + rank[i] + "\r";
                }
            }
        }
    }
}
