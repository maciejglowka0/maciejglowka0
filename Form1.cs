using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_forms_3_kolko_i_krzyzyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        }


        bool player1 = true;
        public int move = 0;
        int scoreX = 0;
        int scoreO = 0;
        public int setO = 0;
        public int setX = 0;

        #region Click 1
        private void button1_Click(object sender, EventArgs e)
        {


            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {

                Check();

            }
            player1 = !player1;
            if (player1 == true)
            {
                this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
            else
            {

                this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerXTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }


        }
        #endregion

        #region Click 2

        private void button2_Click_1(object sender, EventArgs e)
        {

            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {

                Check();

            }
            player1 = !player1;
            if (player1 == true)
            {
                this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
            else
            {

                this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerXTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
        }
        #endregion

        #region Click 3

        private void button3_Click_1(object sender, EventArgs e)
        {

            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {

                Check();

            }
            player1 = !player1;
            if (player1 == true)
            {
                this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
            else
            {

                this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerXTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
        }
        #endregion

        #region Click 4
        private void button4_Click_1(object sender, EventArgs e)
        {

            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {

                Check();

            }
            player1 = !player1;
            if (player1 == true)
            {
                this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
            else
            {

                this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerXTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }

        }
        #endregion

        #region Click 5

        private void button5_Click_1(object sender, EventArgs e)
        {

            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {

                Check();

            }
            player1 = !player1;
            if (player1 == true)
            {
                this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
            else
            {

                this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerXTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }

        }
        #endregion

        #region Click 6

        private void button6_Click(object sender, EventArgs e)
        {

            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {

                Check();

            }
            player1 = !player1;
            if (player1 == true)
            {
                this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
            else
            {

                this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerXTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }


        }

        #endregion

        #region Click 7

        private void button7_Click(object sender, EventArgs e)
        {

            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {

                Check();

            }
            player1 = !player1;
            if (player1 == true)
            {
                this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
            else
            {

                this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerXTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }


        }

        #endregion

        #region Click 8

        private void button8_Click(object sender, EventArgs e)
        {

            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {

                Check();

            }
            player1 = !player1;
            if (player1 == true)
            {
                this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
            else
            {

                this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerXTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }


        }

        #endregion

        #region Click 9

        private void button9_Click(object sender, EventArgs e)
        {

            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {

                Check();

            }
            player1 = !player1;
            if (player1 == true)
            {
                this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
            else
            {

                this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerXTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }


        }

        #endregion











        private void Check()
        {
            #region O-++score&&setCondition



            if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                (button7.Text == "O" && button8.Text == "O" && button9.Text == "O" || (button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                (button3.Text == "O" && button5.Text == "O" && button7.Text == "O" || (button1.Text == "O" && button4.Text == "O" && button7.Text == "O" || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O"))))))))
            {

                scoreO++;
                Restart();

                ScoreO.Text = scoreO.ToString();
                if (scoreX == 3)
                {
                    player1 = true;
                    setO++;
                    textbox2setO.Text = scoreX.ToString();
                    scoreO = 0;
                    scoreX = 0;
                    ScoreO.Text = scoreO.ToString();
                    ScoreX.Text = scoreX.ToString();
                    this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                    this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));


                }
                ScoreO.Text = scoreO.ToString();
                if (scoreO == 3)
                {
                    player1 = true;
                    setO++;
                    textbox2setO.Text = setO.ToString();
                    scoreO = 0;
                    scoreX = 0;
                    ScoreO.Text = scoreO.ToString();
                    ScoreX.Text = scoreX.ToString();

                }



            }

            #endregion

            #region X-score&&setCondition

            else if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
               (button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || (button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
               (button3.Text == "X" && button5.Text == "X" && button7.Text == "X" || (button1.Text == "X" && button4.Text == "X" && button7.Text == "X" || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X"))))))))
            {

                scoreX++;

                Restart();

                ScoreX.Text = scoreX.ToString();
                if (scoreX == 3)
                {
                    setX++;
                    textBox2setX.Text = setX.ToString();
                    scoreO = 0;
                    scoreX = 0;
                    ScoreO.Text = scoreO.ToString();
                    ScoreX.Text = scoreX.ToString();
                    this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                    this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                    player1 = true;

                }


            }

            #endregion

            #region NoPointCondition


            else if (move == 9)

            {

                Restart();

                this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
                this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                player1 = true;





            }

            #endregion


        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (scoreO > scoreX)
            {
                MessageBox.Show("PLAYER O WIN!", "O wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (scoreX > scoreO)
            {
                MessageBox.Show("PLAYER X WIN!", "X wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else if (setO > setX)
            {
                MessageBox.Show("PLAYER O WIN!", "O wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (setX > setO)
            {
                MessageBox.Show("PLAYER X WIN!", "X wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (setO == setX && scoreO == scoreX)
            {
                MessageBox.Show("DRAW!!!", "draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (scoreX == scoreO)
            {
                MessageBox.Show("DRAW!!!", "draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            Restart();
            scoreO = 0;
            scoreX = 0;
            setO = 0;
            setX = 0;
            ScoreO.Text = scoreO.ToString();
            ScoreX.Text = scoreX.ToString();
            textbox2setO.Text = "";
            textBox2setX.Text = "";

            this.PlayerXTurn.BackColor = this.PlayerOTurn.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerOTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            player1 = true;

        }

        private void Restart()
        {

            move = 0;
            Button[] all = new Button[9];
            all[0] = button1;
            all[1] = button2;
            all[2] = button3;
            all[3] = button4;
            all[4] = button5;
            all[5] = button6;
            all[6] = button7;
            all[7] = button8;
            all[8] = button9;
            foreach (Button b in all)
            {

                b.Enabled = true;
                b.Text = "";

            }

        }







        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit the game?",
                             "",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }


        }
    }
}
