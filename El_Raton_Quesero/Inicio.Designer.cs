namespace El_Raton_Quesero
{
    partial class Juego
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.player = new System.Windows.Forms.PictureBox();
            this.Puntaje = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nT = new System.Windows.Forms.NumericUpDown();
            this.nQ = new System.Windows.Forms.NumericUpDown();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.Pausar = new System.Windows.Forms.Button();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQ)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player.Location = new System.Drawing.Point(333, 297);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(86, 83);
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            this.player.Visible = false;
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSize = true;
            this.Puntaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntaje.Location = new System.Drawing.Point(30, 168);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(34, 31);
            this.Puntaje.TabIndex = 6;
            this.Puntaje.Text = "--";
            this.Puntaje.Visible = false;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 20;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerEvent);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnReanudar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nT);
            this.panel1.Controls.Add(this.nQ);
            this.panel1.Controls.Add(this.btnReiniciar);
            this.panel1.Controls.Add(this.Pausar);
            this.panel1.Controls.Add(this.btnEmpezar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 152);
            this.panel1.TabIndex = 7;
            // 
            // btnReanudar
            // 
            this.btnReanudar.Enabled = false;
            this.btnReanudar.Location = new System.Drawing.Point(550, 102);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(75, 23);
            this.btnReanudar.TabIndex = 8;
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.UseVisualStyleBackColor = true;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SquareFont", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(548, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 11);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trampas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SquareFont", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(454, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 11);
            this.label2.TabIndex = 6;
            this.label2.Text = "QUESOS";
            // 
            // nT
            // 
            this.nT.Location = new System.Drawing.Point(550, 76);
            this.nT.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nT.Name = "nT";
            this.nT.Size = new System.Drawing.Size(75, 20);
            this.nT.TabIndex = 5;
            this.nT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nQ
            // 
            this.nQ.Location = new System.Drawing.Point(457, 76);
            this.nQ.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nQ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQ.Name = "nQ";
            this.nQ.Size = new System.Drawing.Size(75, 20);
            this.nQ.TabIndex = 4;
            this.nQ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(457, 102);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Pausar
            // 
            this.Pausar.Enabled = false;
            this.Pausar.Location = new System.Drawing.Point(638, 102);
            this.Pausar.Name = "Pausar";
            this.Pausar.Size = new System.Drawing.Size(75, 23);
            this.Pausar.TabIndex = 2;
            this.Pausar.Text = "Pausar";
            this.Pausar.UseVisualStyleBackColor = true;
            this.Pausar.Click += new System.EventHandler(this.Pausar_Click);
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(638, 73);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpezar.TabIndex = 1;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SquareFont", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(452, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "EL RATÓN QUESERO";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 493);
            this.Controls.Add(this.Puntaje);
            this.Controls.Add(this.player);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "El ratón quesero";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label Puntaje;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Button Pausar;
        private System.Windows.Forms.NumericUpDown nT;
        private System.Windows.Forms.NumericUpDown nQ;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReanudar;
    }
}

