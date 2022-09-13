using System;
using System.Drawing; //Para dibujar la posición de la imagen
using System.Windows.Forms;

namespace Ping_Pong {
    public partial class Form1 : Form {

        private int speed = 5;
        private int counter = 0;
        private int player_points = 0;
        private bool arriba, derecha;

        private bool npcArriba, npcAbajo;
        private bool cambioDireccion = false;

        public Form1() {
            InitializeComponent();
        }

        private bool IsTouching(PictureBox p1, PictureBox p2) {
            if (p1.Location.X + p1.Width < p2.Location.X)
                return false;
            if (p2.Location.X + p2.Width < p1.Location.X)
                return false;
            if (p1.Location.Y + p1.Height < p2.Location.Y)
                return false;
            if (p2.Location.Y + p2.Height < p1.Location.Y)
                return false;
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e) {

            //if (this.ball.Right > this.npc_raqueta.Right) { //Ganar
            //    timer1.Enabled = false;
            //    MessageBox.Show("Has ganado");
            //    this.speed = 5;
            //    this.counter = 0;
            //}

            if (IsTouching(this.ball, this.player_raqueta)) {
                this.derecha = true;
            }

            if (IsTouching(this.ball, this.npc_raqueta)) {
                this.derecha = false;
                Console.WriteLine("Tocado");
            }

            if (derecha) { //Va para la derecha
                this.ball.Left += this.speed;
            } else {
                this.ball.Left -= this.speed;
            }

            if (arriba) { //Va para arriba
                this.ball.Top += this.speed;
            } else {
                this.ball.Top -= this.speed;
            }

            if (this.ball.Top >= this.Height - 71) { //Si se pega en la pared de abajo
                arriba = false;
            }

            if (this.ball.Top <= 0) { //Se pega en la pared de arriba
                arriba = true;
            }

            if (this.ball.Right <= 0) { //Si pega en la pared de la izquierda
                derecha = true;
            }

            if (this.ball.Left >= this.Width - 51) {
                derecha = false;
            }


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            player_raqueta.Top = e.Y;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Text = "Puntuación: 0";

            Random random = new Random();

            npc_raqueta.Top = random.Next(200, 550);

            this.ball.Location = new Point(55, random.Next(this.Height));

            this.arriba = true;
            this.derecha = true;
            this.timer1.Enabled = true;

            this.timer2.Enabled = true;
            this.player_points = 0;

        }

        private void timer3_Tick(object sender, EventArgs e) {

            npcAbajo = npc_raqueta.Top + this.npc_raqueta.Height <= this.Height - 76;

            if (npcAbajo) {
                this.npc_raqueta.Top += 20;
            } else {
                this.timer3.Enabled = false;
                this.timer2.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e) {

        }

        private void timer2_Tick(object sender, EventArgs e) {
            Console.WriteLine("Window: " + this.Height);

            npcArriba = npc_raqueta.Top - this.npc_raqueta.Height >= -85;

            if (npcArriba) {
                this.npc_raqueta.Top -= 20;
            } else {
                this.timer2.Enabled = false;
                this.timer3.Enabled = true;
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
