namespace WinFormsApp1
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
            txtNombre = new TextBox();
            Nombre = new Label();
            chkDeportes = new CheckBox();
            chkLectura = new CheckBox();
            chkProgramacion = new CheckBox();
            chkMusica = new CheckBox();
            chkArte = new CheckBox();
            Act = new GroupBox();
            Modalidades = new GroupBox();
            rdoHibrida = new RadioButton();
            rdoEnLinea = new RadioButton();
            rdoPresencial = new RadioButton();
            btnMostrarResumen = new Button();
            btnLimpiar = new Button();
            Resumen = new Label();
            txtResumen = new TextBox();
            Act.SuspendLayout();
            Modalidades.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(312, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(12, 36);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(119, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre del Alumno:";
            Nombre.Click += label1_Click;
            // 
            // chkDeportes
            // 
            chkDeportes.AutoSize = true;
            chkDeportes.Location = new Point(6, 22);
            chkDeportes.Name = "chkDeportes";
            chkDeportes.Size = new Size(73, 19);
            chkDeportes.TabIndex = 2;
            chkDeportes.Text = "Deportes";
            chkDeportes.UseVisualStyleBackColor = true;
            // 
            // chkLectura
            // 
            chkLectura.AutoSize = true;
            chkLectura.Location = new Point(6, 122);
            chkLectura.Name = "chkLectura";
            chkLectura.Size = new Size(65, 19);
            chkLectura.TabIndex = 3;
            chkLectura.Text = "Lectura";
            chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkProgramacion
            // 
            chkProgramacion.AutoSize = true;
            chkProgramacion.Location = new Point(6, 97);
            chkProgramacion.Name = "chkProgramacion";
            chkProgramacion.Size = new Size(101, 19);
            chkProgramacion.TabIndex = 4;
            chkProgramacion.Text = "Programacion";
            chkProgramacion.UseVisualStyleBackColor = true;
            chkProgramacion.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chkMusica
            // 
            chkMusica.AutoSize = true;
            chkMusica.Location = new Point(6, 47);
            chkMusica.Name = "chkMusica";
            chkMusica.Size = new Size(64, 19);
            chkMusica.TabIndex = 5;
            chkMusica.Text = "Musica";
            chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkArte
            // 
            chkArte.AutoSize = true;
            chkArte.Location = new Point(6, 72);
            chkArte.Name = "chkArte";
            chkArte.Size = new Size(48, 19);
            chkArte.TabIndex = 6;
            chkArte.Text = "Arte";
            chkArte.UseVisualStyleBackColor = true;
            // 
            // Act
            // 
            Act.Controls.Add(chkDeportes);
            Act.Controls.Add(chkLectura);
            Act.Controls.Add(chkProgramacion);
            Act.Controls.Add(chkArte);
            Act.Controls.Add(chkMusica);
            Act.Location = new Point(23, 108);
            Act.Name = "Act";
            Act.Size = new Size(250, 148);
            Act.TabIndex = 7;
            Act.TabStop = false;
            Act.Text = "Actividades favoritas (puedes elegir varias)";
            // 
            // Modalidades
            // 
            Modalidades.Controls.Add(rdoHibrida);
            Modalidades.Controls.Add(rdoEnLinea);
            Modalidades.Controls.Add(rdoPresencial);
            Modalidades.Location = new Point(288, 108);
            Modalidades.Name = "Modalidades";
            Modalidades.Size = new Size(250, 148);
            Modalidades.TabIndex = 8;
            Modalidades.TabStop = false;
            Modalidades.Text = "Modalidad Favorita (Elige una)";
            // 
            // rdoHibrida
            // 
            rdoHibrida.AutoSize = true;
            rdoHibrida.Location = new Point(6, 71);
            rdoHibrida.Name = "rdoHibrida";
            rdoHibrida.Size = new Size(64, 19);
            rdoHibrida.TabIndex = 2;
            rdoHibrida.TabStop = true;
            rdoHibrida.Text = "Hibrida";
            rdoHibrida.UseVisualStyleBackColor = true;
            // 
            // rdoEnLinea
            // 
            rdoEnLinea.AutoSize = true;
            rdoEnLinea.Location = new Point(6, 121);
            rdoEnLinea.Name = "rdoEnLinea";
            rdoEnLinea.Size = new Size(69, 19);
            rdoEnLinea.TabIndex = 1;
            rdoEnLinea.TabStop = true;
            rdoEnLinea.Text = "En Linea";
            rdoEnLinea.UseVisualStyleBackColor = true;
            // 
            // rdoPresencial
            // 
            rdoPresencial.AutoSize = true;
            rdoPresencial.Location = new Point(6, 22);
            rdoPresencial.Name = "rdoPresencial";
            rdoPresencial.Size = new Size(78, 19);
            rdoPresencial.TabIndex = 0;
            rdoPresencial.TabStop = true;
            rdoPresencial.Text = "Presencial";
            rdoPresencial.UseVisualStyleBackColor = true;
            // 
            // btnMostrarResumen
            // 
            btnMostrarResumen.Location = new Point(144, 277);
            btnMostrarResumen.Name = "btnMostrarResumen";
            btnMostrarResumen.Size = new Size(117, 23);
            btnMostrarResumen.TabIndex = 9;
            btnMostrarResumen.Text = "Mostrar Resumen";
            btnMostrarResumen.UseVisualStyleBackColor = true;
            btnMostrarResumen.Click += btnMostrarResumen_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(297, 277);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Resumen
            // 
            Resumen.AutoSize = true;
            Resumen.Location = new Point(29, 317);
            Resumen.Name = "Resumen";
            Resumen.Size = new Size(59, 15);
            Resumen.TabIndex = 11;
            Resumen.Text = "Resumen:";
            Resumen.Click += label1_Click_1;
            // 
            // txtResumen
            // 
            txtResumen.Location = new Point(31, 346);
            txtResumen.Multiline = true;
            txtResumen.Name = "txtResumen";
            txtResumen.Size = new Size(483, 83);
            txtResumen.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 450);
            Controls.Add(txtResumen);
            Controls.Add(Resumen);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrarResumen);
            Controls.Add(Modalidades);
            Controls.Add(Act);
            Controls.Add(Nombre);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Act.ResumeLayout(false);
            Act.PerformLayout();
            Modalidades.ResumeLayout(false);
            Modalidades.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label Nombre;
        private CheckBox chkDeportes;
        private CheckBox chkLectura;
        private CheckBox chkProgramacion;
        private CheckBox chkMusica;
        private CheckBox chkArte;
        private GroupBox Act;
        private GroupBox Modalidades;
        private RadioButton rdoHibrida;
        private RadioButton rdoEnLinea;
        private RadioButton rdoPresencial;
        private Button btnMostrarResumen;
        private Button btnLimpiar;
        private Label Resumen;
        private TextBox txtResumen;
    }
}
