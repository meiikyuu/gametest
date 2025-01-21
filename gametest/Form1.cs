using System;
using System.Windows.Forms;

namespace gametest
{
    public partial class Form1 : Form
    {
        int ypos=200;
        int grav=0;
        int pipexpos=400;
        int gap = 200;
        int score = 0;
        int diff = 0;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void flap_Click(object sender, EventArgs e)//makes the bird flap
        {
            grav = -10;
        }
        private void gameTick(object sender, EventArgs e)
        {
            grav++; // birdgravity
            pipexpos = pipexpos - 10 - diff; //moves the pipe left
            ypos = ypos + grav; // y velocity
            bird.Location = new System.Drawing.Point(50, ypos);
            pipeBottom.Location = new System.Drawing.Point(pipexpos,gap+200);
            pipeTop.Location = new System.Drawing.Point(pipexpos,gap-200);
            lblScore.Text = score.ToString();
            lblBirdpos.Text = ypos.ToString();

            if (120 > pipexpos && pipexpos > 10)  // pipe collision decetion
            {
                lblPassCheck.Text = "testCheck";
                if (ypos < gap || ypos > gap +150) {
                    lblPassCheck.Text = "testCheck hit";
                    score = 0;
                    pipexpos = 400;
                    ypos = 200;
                    grav = 0;
                    diff = 0;
                }
            }
            else
            {
                lblPassCheck.Text = "testUnCheck";
            }
                if (ypos > 360) //floor decetion
            {
                ypos = 360;
                grav = 0;
            }

            if (pipexpos < -50) //detects when pipe off screen and gives point for passing
            {
                gap = rand.Next(50, 201);
                pipexpos = 400;
                score++;
                if (diff < 6)
                {
                    diff++;
                }
            }
        }
    }
}
