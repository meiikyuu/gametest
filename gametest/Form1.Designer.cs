namespace gametest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flap = new System.Windows.Forms.Button();
            this.bird = new System.Windows.Forms.PictureBox();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.lblPassCheck = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblBirdpos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // flap
            // 
            this.flap.BackColor = System.Drawing.Color.Transparent;
            this.flap.ForeColor = System.Drawing.Color.Transparent;
            this.flap.Image = global::gametest.Properties.Resources.flapfloor;
            this.flap.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.flap.Location = new System.Drawing.Point(-2, 497);
            this.flap.Name = "flap";
            this.flap.Size = new System.Drawing.Size(548, 162);
            this.flap.TabIndex = 0;
            this.flap.Text = " ";
            this.flap.UseVisualStyleBackColor = false;
            this.flap.Click += new System.EventHandler(this.flap_Click);
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::gametest.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(77, 441);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(75, 50);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 20;
            this.gameTime.Tick += new System.EventHandler(this.gameTick);
            // 
            // pipeTop
            // 
            this.pipeTop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pipeTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pipeTop.Location = new System.Drawing.Point(325, 1);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(89, 236);
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pipeBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pipeBottom.Location = new System.Drawing.Point(147, 441);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(89, 236);
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;
            // 
            // lblPassCheck
            // 
            this.lblPassCheck.AutoSize = true;
            this.lblPassCheck.Location = new System.Drawing.Point(175, 257);
            this.lblPassCheck.Name = "lblPassCheck";
            this.lblPassCheck.Size = new System.Drawing.Size(44, 16);
            this.lblPassCheck.TabIndex = 4;
            this.lblPassCheck.Text = "label1";
            this.lblPassCheck.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Transparent;
            this.lblScore.Location = new System.Drawing.Point(142, 257);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(27, 29);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // lblBirdpos
            // 
            this.lblBirdpos.AutoSize = true;
            this.lblBirdpos.Location = new System.Drawing.Point(175, 273);
            this.lblBirdpos.Name = "lblBirdpos";
            this.lblBirdpos.Size = new System.Drawing.Size(44, 16);
            this.lblBirdpos.TabIndex = 6;
            this.lblBirdpos.Text = "label1";
            this.lblBirdpos.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(415, 598);
            this.Controls.Add(this.lblBirdpos);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPassCheck);
            this.Controls.Add(this.flap);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.bird);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button flap;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Label lblPassCheck;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblBirdpos;
    }
}

