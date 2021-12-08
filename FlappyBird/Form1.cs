using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipeSpeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BIRD.Top += gravity;
            PIPETOP.Left -= pipeSpeed;
            PIPEBOTTOM.Left -= pipeSpeed;

            if(PIPETOP.Left < -100)
            {
                PIPETOP.Left = 800;
                score++;
            }
            if(PIPEBOTTOM.Left < -100)
            {
                PIPEBOTTOM.Left = 800;
                score++;
            }
            if(BIRD.Bounds.IntersectsWith(PIPETOP.Bounds) || BIRD.Bounds.IntersectsWith(PIPEBOTTOM.Bounds) || BIRD.Bounds.IntersectsWith(GROUND.Bounds))
            {
                gameOver();
            }
            if(BIRD.Top < -25)
            {
                gameOver();
            }
        }

        private void PIPEBOTTOM_Click(object sender, EventArgs e)
        {

        }

        private void BIRD_Click(object sender, EventArgs e)
        {

        }

        private void PIPETOP_Click(object sender, EventArgs e)
        {

        }

        private void GROUND_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -7;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void gameOver()
        {
            timer1.Stop();
            SCORELABEL.Text = $"game over. Score {score}";
        }
    }
}
