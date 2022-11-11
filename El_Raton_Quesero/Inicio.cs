using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;


namespace El_Raton_Quesero
{
    
    public partial class Juego : Form
    {
        
        int LimiteX = 675;
        int LimiteY = 442;
        int vx = 5, vy = 5;
        int cvidas = 0;

        Random rnd = new Random();

        /*private void S()
        {
            var sonido2 = new SoundPlayer(El_Raton_Quesero.Properties.Resources.GS);
            sonido2.Play();
        }*/

        /*private void Fondo()
        {
            var sonido2 = new SoundPlayer(El_Raton_Quesero.Properties.Resources.Fondo);
            sonido2.Play();
        }*/

        public Juego()
        {
            InitializeComponent();
            //Fondo();
        }

        

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            //S();
            player.Visible = true;
            Puntaje.Visible = true;
            mainTimer.Start();
            btnEmpezar.Enabled = false;
            btnReiniciar.Enabled = true;
            Pausar.Enabled = true;
            nQ.Enabled = false;
            nT.Enabled = false;
            btnReanudar.Enabled = false;

            int Quesos = (int)nQ.Value;
            int Trampas = (int)nT.Value;
            Image imag = El_Raton_Quesero.Properties.Resources.Vidas;
            Image imag2 = El_Raton_Quesero.Properties.Resources.Queso;
            Image imag3 = El_Raton_Quesero.Properties.Resources.Trampa;
            for (int i = 0; i < Quesos; i++)
            {
             int x = rnd.Next(0, 179);
             int y = rnd.Next(205, 416);
                var picture = new PictureBox
            {
                Name = "Queso"+(i+1),
                Size = new Size(50, 50),
                Location = new Point(x, y),
                Tag = "object",
                BackColor = Color.Transparent,
                BackgroundImage = imag2,
                BackgroundImageLayout = ImageLayout.Stretch
            };
                this.Controls.Add(picture);
            }

            for (int i = 0; i < Trampas; i++)
            {
                int a = rnd.Next(0, 179);
                int b = rnd.Next(205, 416);
                var picture = new PictureBox
                {
                    Name = "Trampas" +(1+i),
                    Size = new Size(50, 50),
                    Location = new Point(a, b),
                    Tag = "object",
                    BackColor = Color.Transparent,
                    BackgroundImage = imag3,
                    BackgroundImageLayout = ImageLayout.Stretch
                };
                this.Controls.Add(picture);
            }
            int contador = 0;
            for (int i = 0; i < 3; i++)
            {
                
                contador = contador + 31;
                var picture = new PictureBox
                {
                    
                    Name = "Vida" + (1 + i),
                    Size = new Size(25, 25),
                    Location = new Point(619+contador, 158),
                    BackColor = Color.Transparent,
                    BackgroundImage = imag,
                    BackgroundImageLayout = ImageLayout.Stretch
                };
                this.Controls.Add(picture);
            }

        }

        private void Pausar_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
            btnEmpezar.Enabled = false;
            btnReanudar.Enabled = true;

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Puntaje.Text = "--";
            btnReanudar.Enabled = false;
            Pausar.Enabled = true;
            mainTimer.Stop();
            foreach (Control x in this.Controls)
            {
                int d = rnd.Next(0, 179);
                int f = rnd.Next(205, 416);
                if (x is PictureBox && (string)x.Tag == "object")
                {
                    x.Location = new Point(d, f);
                }
            }
            player.Location = new Point(333, 297);
            mainTimer.Start();
            btnEmpezar.Enabled = false;
            //Fondo();
            cvidas = 0;
            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && z.Name.Contains("Vida"))
                {
                    z.Visible = true;
                }
            }
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            btnEmpezar.Enabled = false;
            mainTimer.Enabled = true;
        }

        private void mainTimerEvent(object sender, EventArgs e)
        {
            
            player.Left = player.Left + vx;
            player.Top = player.Top + vy;

            // Colisión con bordes
            if (player.Left > LimiteX || player.Left <= 0)
            {
                vx *= -1;       // Cambiar dirección
            }

            if (player.Top > LimiteY || player.Top <= 153)
            {
                vy *= -1;       // Cambiar dirección
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "object")
                {
                    
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            Puntaje.Text = "Objeto - " + x.Name;
                            if (x.Name.Contains("Queso"))
                                {
                                x.BackColor = Color.Green;
                                //S();
                                }
                                if (x.Name.Contains("Trampa"))
                                {
                                    x.BackColor = Color.Red;
                                    cvidas = cvidas + 1;
                                    foreach (Control z in this.Controls)
                                    {
                                        if (z is PictureBox && z.Name.Contains("Vida"+cvidas))
                                        {
                                            z.Visible = false;
                                        }
                                    }
                                    if (cvidas==3)
                                        {
                                        mainTimer.Stop();
                                        MessageBox.Show("Perdiste");
                                        btnEmpezar.Enabled = false;
                                        Pausar.Enabled = false;
                                        btnReiniciar.Enabled = true;
                                        }
                                }

                        
                            vx *= -1;
                        }
                        else {
                        x.BackColor = Color.Transparent;
                        } 
                }
                
            }
        }
        
    }

    internal struct NewStruct
    {
        public object Item1;
        public object Item2;

        public NewStruct(object item1, object item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item1, other.Item1) &&
                   System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item2, other.Item2);
        }

        public override int GetHashCode()
        {
            int hashCode = -1030903623;
            hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<object>.Default.GetHashCode(Item1);
            hashCode = hashCode * -1521134295 + System.Collections.Generic.EqualityComparer<object>.Default.GetHashCode(Item2);
            return hashCode;
        }

        public void Deconstruct(out object item1, out object item2)
        {
            item1 = Item1;
            item2 = Item2;
        }

        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
