namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.user0 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.user1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.user2 = new System.Windows.Forms.PictureBox();
            this.user3 = new System.Windows.Forms.PictureBox();
            this.user4 = new System.Windows.Forms.PictureBox();
            this.user5 = new System.Windows.Forms.PictureBox();
            this.dealer0 = new System.Windows.Forms.PictureBox();
            this.dealer3 = new System.Windows.Forms.PictureBox();
            this.dealer1 = new System.Windows.Forms.PictureBox();
            this.dealer4 = new System.Windows.Forms.PictureBox();
            this.dealer2 = new System.Windows.Forms.PictureBox();
            this.dealer5 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer5)).BeginInit();
            this.SuspendLayout();
            // 
            // user0
            // 
            this.user0.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.user0.Location = new System.Drawing.Point(18, 8);
            this.user0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user0.Name = "user0";
            this.user0.Size = new System.Drawing.Size(76, 104);
            this.user0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user0.TabIndex = 0;
            this.user0.TabStop = false;
            this.user0.Click += new System.EventHandler(this.Form1_Load);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(578, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(578, 83);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 21);
            this.textBox2.TabIndex = 2;
            // 
            // user1
            // 
            this.user1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.user1.Location = new System.Drawing.Point(35, 24);
            this.user1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(76, 104);
            this.user1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user1.TabIndex = 0;
            this.user1.TabStop = false;
            this.user1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(578, 108);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 21);
            this.textBox3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 18);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(770, 82);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 18);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stand";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // user2
            // 
            this.user2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.user2.Location = new System.Drawing.Point(52, 40);
            this.user2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(76, 104);
            this.user2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user2.TabIndex = 0;
            this.user2.TabStop = false;
            this.user2.Click += new System.EventHandler(this.Form1_Load);
            // 
            // user3
            // 
            this.user3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.user3.Location = new System.Drawing.Point(70, 56);
            this.user3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user3.Name = "user3";
            this.user3.Size = new System.Drawing.Size(76, 104);
            this.user3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user3.TabIndex = 0;
            this.user3.TabStop = false;
            this.user3.Click += new System.EventHandler(this.Form1_Load);
            // 
            // user4
            // 
            this.user4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.user4.Location = new System.Drawing.Point(88, 72);
            this.user4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user4.Name = "user4";
            this.user4.Size = new System.Drawing.Size(76, 104);
            this.user4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user4.TabIndex = 0;
            this.user4.TabStop = false;
            this.user4.Click += new System.EventHandler(this.Form1_Load);
            // 
            // user5
            // 
            this.user5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.user5.Location = new System.Drawing.Point(105, 88);
            this.user5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user5.Name = "user5";
            this.user5.Size = new System.Drawing.Size(76, 104);
            this.user5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user5.TabIndex = 0;
            this.user5.TabStop = false;
            this.user5.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dealer0
            // 
            this.dealer0.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dealer0.Location = new System.Drawing.Point(19, 257);
            this.dealer0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealer0.Name = "dealer0";
            this.dealer0.Size = new System.Drawing.Size(76, 104);
            this.dealer0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer0.TabIndex = 0;
            this.dealer0.TabStop = false;
            this.dealer0.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dealer3
            // 
            this.dealer3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dealer3.Location = new System.Drawing.Point(290, 257);
            this.dealer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealer3.Name = "dealer3";
            this.dealer3.Size = new System.Drawing.Size(76, 104);
            this.dealer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer3.TabIndex = 0;
            this.dealer3.TabStop = false;
            this.dealer3.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dealer1
            // 
            this.dealer1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dealer1.Location = new System.Drawing.Point(108, 257);
            this.dealer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealer1.Name = "dealer1";
            this.dealer1.Size = new System.Drawing.Size(76, 104);
            this.dealer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer1.TabIndex = 0;
            this.dealer1.TabStop = false;
            this.dealer1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dealer4
            // 
            this.dealer4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dealer4.Location = new System.Drawing.Point(380, 257);
            this.dealer4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealer4.Name = "dealer4";
            this.dealer4.Size = new System.Drawing.Size(76, 104);
            this.dealer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer4.TabIndex = 0;
            this.dealer4.TabStop = false;
            this.dealer4.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dealer2
            // 
            this.dealer2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dealer2.Location = new System.Drawing.Point(200, 257);
            this.dealer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealer2.Name = "dealer2";
            this.dealer2.Size = new System.Drawing.Size(76, 104);
            this.dealer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer2.TabIndex = 0;
            this.dealer2.TabStop = false;
            this.dealer2.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dealer5
            // 
            this.dealer5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dealer5.Location = new System.Drawing.Point(472, 257);
            this.dealer5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealer5.Name = "dealer5";
            this.dealer5.Size = new System.Drawing.Size(76, 104);
            this.dealer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer5.TabIndex = 0;
            this.dealer5.TabStop = false;
            this.dealer5.Click += new System.EventHandler(this.Form1_Load);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(578, 257);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 21);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(578, 140);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 21);
            this.textBox5.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(770, 106);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 18);
            this.button3.TabIndex = 3;
            this.button3.Text = "Retry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(770, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "룰 설명";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(770, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "랭킹";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 461);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.user5);
            this.Controls.Add(this.user4);
            this.Controls.Add(this.user3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dealer5);
            this.Controls.Add(this.dealer2);
            this.Controls.Add(this.user2);
            this.Controls.Add(this.dealer4);
            this.Controls.Add(this.dealer1);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.dealer3);
            this.Controls.Add(this.dealer0);
            this.Controls.Add(this.user0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "블랙잭";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox user0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox user1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox user2;
        private System.Windows.Forms.PictureBox user3;
        private System.Windows.Forms.PictureBox user4;
        private System.Windows.Forms.PictureBox user5;
        private System.Windows.Forms.PictureBox dealer0;
        private System.Windows.Forms.PictureBox dealer3;
        private System.Windows.Forms.PictureBox dealer1;
        private System.Windows.Forms.PictureBox dealer4;
        private System.Windows.Forms.PictureBox dealer2;
        private System.Windows.Forms.PictureBox dealer5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

