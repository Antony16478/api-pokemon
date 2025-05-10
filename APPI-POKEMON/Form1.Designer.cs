namespace PokeApiWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPokemon;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox picPokemon;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtPokemon = new TextBox();
            btnBuscar = new Button();
            picPokemon = new PictureBox();
            lblNombre = new Label();
            lblAltura = new Label();
            lblPeso = new Label();
            lblTipos = new Label();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)picPokemon).BeginInit();
            SuspendLayout();
            // 
            // txtPokemon
            // 
            txtPokemon.Location = new Point(30, 30);
            txtPokemon.Name = "txtPokemon";
            txtPokemon.Size = new Size(200, 27);
            txtPokemon.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(250, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // picPokemon
            // 
            picPokemon.Location = new Point(30, 70);
            picPokemon.Name = "picPokemon";
            picPokemon.Size = new Size(150, 150);
            picPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            picPokemon.TabIndex = 4;
            picPokemon.TabStop = false;
            picPokemon.Click += picPokemon_Click;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(200, 80);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(250, 20);
            lblNombre.TabIndex = 5;
            // 
            // lblAltura
            // 
            lblAltura.Location = new Point(200, 110);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(250, 20);
            lblAltura.TabIndex = 6;
            // 
            // lblPeso
            // 
            lblPeso.Location = new Point(200, 140);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(250, 20);
            lblPeso.TabIndex = 7;
            // 
            // lblTipos
            // 
            lblTipos.Location = new Point(200, 170);
            lblTipos.Name = "lblTipos";
            lblTipos.Size = new Size(250, 20);
            lblTipos.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(340, 30);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(430, 30);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(550, 250);
            Controls.Add(txtPokemon);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(picPokemon);
            Controls.Add(lblNombre);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Controls.Add(lblTipos);
            Name = "Form1";
            Text = "PokeAPI - WinForms";
            ((System.ComponentModel.ISupportInitialize)picPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
