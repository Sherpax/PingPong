namespace Ping_Pong {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.npc_raqueta = new System.Windows.Forms.PictureBox();
            this.player_raqueta = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.npc_raqueta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_raqueta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // npc_raqueta
            // 
            this.npc_raqueta.BackColor = System.Drawing.Color.Red;
            this.npc_raqueta.Location = new System.Drawing.Point(1194, 211);
            this.npc_raqueta.Name = "npc_raqueta";
            this.npc_raqueta.Size = new System.Drawing.Size(10, 106);
            this.npc_raqueta.TabIndex = 3;
            this.npc_raqueta.TabStop = false;
            // 
            // player_raqueta
            // 
            this.player_raqueta.BackColor = System.Drawing.Color.Red;
            this.player_raqueta.Location = new System.Drawing.Point(1, 211);
            this.player_raqueta.Name = "player_raqueta";
            this.player_raqueta.Size = new System.Drawing.Size(10, 106);
            this.player_raqueta.TabIndex = 2;
            this.player_raqueta.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = global::Ping_Pong.Properties.Resources.BALL;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ball.Image = global::Ping_Pong.Properties.Resources.BALL;
            this.ball.Location = new System.Drawing.Point(1104, 56);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(44, 42);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 20;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1206, 751);
            this.Controls.Add(this.npc_raqueta);
            this.Controls.Add(this.player_raqueta);
            this.Controls.Add(this.ball);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.npc_raqueta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_raqueta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player_raqueta;
        private System.Windows.Forms.PictureBox npc_raqueta;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

