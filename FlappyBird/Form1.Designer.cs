namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PIPETOP = new System.Windows.Forms.PictureBox();
            this.BIRD = new System.Windows.Forms.PictureBox();
            this.PIPEBOTTOM = new System.Windows.Forms.PictureBox();
            this.GROUND = new System.Windows.Forms.PictureBox();
            this.SCORELABEL = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PIPETOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BIRD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIPEBOTTOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GROUND)).BeginInit();
            this.SuspendLayout();
            // 
            // PIPETOP
            // 
            this.PIPETOP.Image = ((System.Drawing.Image)(resources.GetObject("PIPETOP.Image")));
            this.PIPETOP.Location = new System.Drawing.Point(577, 0);
            this.PIPETOP.Name = "PIPETOP";
            this.PIPETOP.Size = new System.Drawing.Size(100, 266);
            this.PIPETOP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIPETOP.TabIndex = 0;
            this.PIPETOP.TabStop = false;
            this.PIPETOP.Click += new System.EventHandler(this.PIPETOP_Click);
            // 
            // BIRD
            // 
            this.BIRD.Image = ((System.Drawing.Image)(resources.GetObject("BIRD.Image")));
            this.BIRD.Location = new System.Drawing.Point(115, 497);
            this.BIRD.Name = "BIRD";
            this.BIRD.Size = new System.Drawing.Size(64, 48);
            this.BIRD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BIRD.TabIndex = 1;
            this.BIRD.TabStop = false;
            this.BIRD.Click += new System.EventHandler(this.BIRD_Click);
            // 
            // PIPEBOTTOM
            // 
            this.PIPEBOTTOM.Image = ((System.Drawing.Image)(resources.GetObject("PIPEBOTTOM.Image")));
            this.PIPEBOTTOM.Location = new System.Drawing.Point(577, 519);
            this.PIPEBOTTOM.Name = "PIPEBOTTOM";
            this.PIPEBOTTOM.Size = new System.Drawing.Size(100, 375);
            this.PIPEBOTTOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIPEBOTTOM.TabIndex = 2;
            this.PIPEBOTTOM.TabStop = false;
            this.PIPEBOTTOM.Click += new System.EventHandler(this.PIPEBOTTOM_Click);
            // 
            // GROUND
            // 
            this.GROUND.Image = ((System.Drawing.Image)(resources.GetObject("GROUND.Image")));
            this.GROUND.Location = new System.Drawing.Point(-14, 841);
            this.GROUND.Name = "GROUND";
            this.GROUND.Size = new System.Drawing.Size(865, 95);
            this.GROUND.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GROUND.TabIndex = 3;
            this.GROUND.TabStop = false;
            this.GROUND.Click += new System.EventHandler(this.GROUND_Click);
            // 
            // SCORELABEL
            // 
            this.SCORELABEL.AutoSize = true;
            this.SCORELABEL.Font = new System.Drawing.Font("Vineta BT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SCORELABEL.Location = new System.Drawing.Point(59, 58);
            this.SCORELABEL.Name = "SCORELABEL";
            this.SCORELABEL.Size = new System.Drawing.Size(214, 43);
            this.SCORELABEL.TabIndex = 4;
            this.SCORELABEL.Text = "Score: 0";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(841, 932);
            this.Controls.Add(this.SCORELABEL);
            this.Controls.Add(this.GROUND);
            this.Controls.Add(this.PIPEBOTTOM);
            this.Controls.Add(this.BIRD);
            this.Controls.Add(this.PIPETOP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PIPETOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BIRD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIPEBOTTOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GROUND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PIPETOP;
        private System.Windows.Forms.PictureBox BIRD;
        private System.Windows.Forms.PictureBox PIPEBOTTOM;
        private System.Windows.Forms.PictureBox GROUND;
        private System.Windows.Forms.Label SCORELABEL;
        private System.Windows.Forms.Timer timer2;
    }
}

