namespace BlackJack
{
    partial class Game
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
            this.btn_hit = new System.Windows.Forms.Button();
            this.btn_stand = new System.Windows.Forms.Button();
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
            this.btn_retry = new System.Windows.Forms.Button();
            this.btn_rule = new System.Windows.Forms.Button();
            this.btn_rank = new System.Windows.Forms.Button();
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
            this.user0.Location = new System.Drawing.Point(18, 35);
            this.user0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user0.Name = "user0";
            this.user0.Size = new System.Drawing.Size(87, 130);
            this.user0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user0.TabIndex = 0;
            this.user0.TabStop = false;
            this.user0.Click += new System.EventHandler(this.Form1_Load);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(381, 64);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 2;
            // 
            // user1
            // 
            this.user1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.user1.Location = new System.Drawing.Point(37, 55);
            this.user1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(87, 130);
            this.user1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user1.TabIndex = 0;
            this.user1.TabStop = false;
            this.user1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(381, 95);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 2;
            // 
            // btn_hit
            // 
            this.btn_hit.Location = new System.Drawing.Point(518, 29);
            this.btn_hit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hit.Name = "btn_hit";
            this.btn_hit.Size = new System.Drawing.Size(80, 40);
            this.btn_hit.TabIndex = 3;
            this.btn_hit.Text = "Hit";
            this.btn_hit.UseVisualStyleBackColor = true;
            this.btn_hit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_stand
            // 
            this.btn_stand.Location = new System.Drawing.Point(517, 73);
            this.btn_stand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_stand.Name = "btn_stand";
            this.btn_stand.Size = new System.Drawing.Size(80, 40);
            this.btn_stand.TabIndex = 3;
            this.btn_stand.Text = "Stand";
            this.btn_stand.UseVisualStyleBackColor = true;
            this.btn_stand.Click += new System.EventHandler(this.button2_Click);
            // 
            // user2
            // 
            this.user2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.user2.Location = new System.Drawing.Point(56, 75);
            this.user2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(87, 130);
            this.user2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user2.TabIndex = 0;
            this.user2.TabStop = false;
            this.user2.Click += new System.EventHandler(this.Form1_Load);
            // 
            // user3
            // 
            this.user3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.user3.Location = new System.Drawing.Point(77, 95);
            this.user3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user3.Name = "user3";
            this.user3.Size = new System.Drawing.Size(87, 130);
            this.user3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user3.TabIndex = 0;
            this.user3.TabStop = false;
            this.user3.Click += new System.EventHandler(this.Form1_Load);
            // 
            // user4
            // 
            this.user4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.user4.Location = new System.Drawing.Point(98, 115);
            this.user4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user4.Name = "user4";
            this.user4.Size = new System.Drawing.Size(87, 130);
            this.user4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user4.TabIndex = 0;
            this.user4.TabStop = false;
            this.user4.Click += new System.EventHandler(this.Form1_Load);
            // 
            // user5
            // 
            this.user5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.user5.Location = new System.Drawing.Point(117, 135);
            this.user5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user5.Name = "user5";
            this.user5.Size = new System.Drawing.Size(87, 130);
            this.user5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user5.TabIndex = 0;
            this.user5.TabStop = false;
            this.user5.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dealer0
            // 
            this.dealer0.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dealer0.Location = new System.Drawing.Point(18, 386);
            this.dealer0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealer0.Name = "dealer0";
            this.dealer0.Size = new System.Drawing.Size(87, 130);
            this.dealer0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer0.TabIndex = 0;
            this.dealer0.TabStop = false;
            this.dealer0.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dealer3
            // 
            this.dealer3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dealer3.Location = new System.Drawing.Point(137, 386);
            this.dealer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealer3.Name = "dealer3";
            this.dealer3.Size = new System.Drawing.Size(87, 130);
            this.dealer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer3.TabIndex = 0;
            this.dealer3.TabStop = false;
            this.dealer3.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dealer1
            // 
            this.dealer1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dealer1.Location = new System.Drawing.Point(55, 386);
            this.dealer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealer1.Name = "dealer1";
            this.dealer1.Size = new System.Drawing.Size(87, 130);
            this.dealer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer1.TabIndex = 0;
            this.dealer1.TabStop = false;
            this.dealer1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dealer4
            // 
            this.dealer4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dealer4.Location = new System.Drawing.Point(170, 386);
            this.dealer4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealer4.Name = "dealer4";
            this.dealer4.Size = new System.Drawing.Size(87, 130);
            this.dealer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer4.TabIndex = 0;
            this.dealer4.TabStop = false;
            this.dealer4.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dealer2
            // 
            this.dealer2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dealer2.Location = new System.Drawing.Point(97, 386);
            this.dealer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealer2.Name = "dealer2";
            this.dealer2.Size = new System.Drawing.Size(87, 130);
            this.dealer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer2.TabIndex = 0;
            this.dealer2.TabStop = false;
            this.dealer2.Click += new System.EventHandler(this.Form1_Load);
            // 
            // dealer5
            // 
            this.dealer5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dealer5.Location = new System.Drawing.Point(212, 386);
            this.dealer5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealer5.Name = "dealer5";
            this.dealer5.Size = new System.Drawing.Size(87, 130);
            this.dealer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer5.TabIndex = 0;
            this.dealer5.TabStop = false;
            this.dealer5.Click += new System.EventHandler(this.Form1_Load);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(328, 386);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(381, 135);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 25);
            this.textBox5.TabIndex = 2;
            // 
            // btn_retry
            // 
            this.btn_retry.Location = new System.Drawing.Point(517, 117);
            this.btn_retry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_retry.Name = "btn_retry";
            this.btn_retry.Size = new System.Drawing.Size(80, 40);
            this.btn_retry.TabIndex = 3;
            this.btn_retry.Text = "Retry";
            this.btn_retry.UseVisualStyleBackColor = true;
            this.btn_retry.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_rule
            // 
            this.btn_rule.Location = new System.Drawing.Point(517, 428);
            this.btn_rule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rule.Name = "btn_rule";
            this.btn_rule.Size = new System.Drawing.Size(80, 40);
            this.btn_rule.TabIndex = 4;
            this.btn_rule.Text = "룰 설명";
            this.btn_rule.UseVisualStyleBackColor = true;
            this.btn_rule.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_rank
            // 
            this.btn_rank.Location = new System.Drawing.Point(517, 476);
            this.btn_rank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rank.Name = "btn_rank";
            this.btn_rank.Size = new System.Drawing.Size(80, 40);
            this.btn_rank.TabIndex = 5;
            this.btn_rank.Text = "랭킹";
            this.btn_rank.UseVisualStyleBackColor = true;
            this.btn_rank.Click += new System.EventHandler(this.button5_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 576);
            this.Controls.Add(this.dealer5);
            this.Controls.Add(this.dealer4);
            this.Controls.Add(this.dealer3);
            this.Controls.Add(this.btn_rank);
            this.Controls.Add(this.btn_rule);
            this.Controls.Add(this.user5);
            this.Controls.Add(this.user4);
            this.Controls.Add(this.user3);
            this.Controls.Add(this.btn_retry);
            this.Controls.Add(this.btn_stand);
            this.Controls.Add(this.btn_hit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dealer2);
            this.Controls.Add(this.user2);
            this.Controls.Add(this.dealer1);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.dealer0);
            this.Controls.Add(this.user0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game";
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
        private System.Windows.Forms.Button btn_hit;
        private System.Windows.Forms.Button btn_stand;
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
        private System.Windows.Forms.Button btn_retry;
        private System.Windows.Forms.Button btn_rule;
        private System.Windows.Forms.Button btn_rank;

    }
}

