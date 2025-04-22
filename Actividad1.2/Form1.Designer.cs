namespace Actividad1._2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNacimiento = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lstEstados = new System.Windows.Forms.ListBox();
            this.gbHorarios = new System.Windows.Forms.GroupBox();
            this.rbMatutino = new System.Windows.Forms.RadioButton();
            this.rbVespertino = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatosAlumno.SuspendLayout();
            this.gbHorarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosAlumno
            // 
            this.gbDatosAlumno.Controls.Add(this.txtDireccion);
            this.gbDatosAlumno.Controls.Add(this.txtNacimiento);
            this.gbDatosAlumno.Controls.Add(this.txtNombre);
            this.gbDatosAlumno.Controls.Add(this.label3);
            this.gbDatosAlumno.Controls.Add(this.label2);
            this.gbDatosAlumno.Controls.Add(this.label1);
            this.gbDatosAlumno.Location = new System.Drawing.Point(12, 12);
            this.gbDatosAlumno.Name = "gbDatosAlumno";
            this.gbDatosAlumno.Size = new System.Drawing.Size(395, 252);
            this.gbDatosAlumno.TabIndex = 0;
            this.gbDatosAlumno.TabStop = false;
            this.gbDatosAlumno.Text = "Datos del alumno";
            this.gbDatosAlumno.Enter += new System.EventHandler(this.DatosAlumnos_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(31, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.Location = new System.Drawing.Point(31, 138);
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(343, 22);
            this.txtNacimiento.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(31, 215);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(343, 22);
            this.txtDireccion.TabIndex = 5;
            // 
            // lstEstados
            // 
            this.lstEstados.FormattingEnabled = true;
            this.lstEstados.ItemHeight = 16;
            this.lstEstados.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Ciudad de México",
            "Coahuila",
            "Colima",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.lstEstados.Location = new System.Drawing.Point(74, 272);
            this.lstEstados.Name = "lstEstados";
            this.lstEstados.Size = new System.Drawing.Size(170, 148);
            this.lstEstados.TabIndex = 1;
            // 
            // gbHorarios
            // 
            this.gbHorarios.Controls.Add(this.rbVespertino);
            this.gbHorarios.Controls.Add(this.rbMatutino);
            this.gbHorarios.Location = new System.Drawing.Point(413, 12);
            this.gbHorarios.Name = "gbHorarios";
            this.gbHorarios.Size = new System.Drawing.Size(279, 252);
            this.gbHorarios.TabIndex = 2;
            this.gbHorarios.TabStop = false;
            this.gbHorarios.Text = "Horarios";
            // 
            // rbMatutino
            // 
            this.rbMatutino.AutoSize = true;
            this.rbMatutino.Location = new System.Drawing.Point(18, 55);
            this.rbMatutino.Name = "rbMatutino";
            this.rbMatutino.Size = new System.Drawing.Size(78, 20);
            this.rbMatutino.TabIndex = 3;
            this.rbMatutino.TabStop = true;
            this.rbMatutino.Text = "Matutino";
            this.rbMatutino.UseVisualStyleBackColor = true;
            // 
            // rbVespertino
            // 
            this.rbVespertino.AutoSize = true;
            this.rbVespertino.Location = new System.Drawing.Point(18, 138);
            this.rbVespertino.Name = "rbVespertino";
            this.rbVespertino.Size = new System.Drawing.Size(93, 20);
            this.rbVespertino.TabIndex = 4;
            this.rbVespertino.TabStop = true;
            this.rbVespertino.Text = "Vespertino";
            this.rbVespertino.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(323, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(304, 55);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 432);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbHorarios);
            this.Controls.Add(this.lstEstados);
            this.Controls.Add(this.gbDatosAlumno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Expendiente de alumno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDatosAlumno.ResumeLayout(false);
            this.gbDatosAlumno.PerformLayout();
            this.gbHorarios.ResumeLayout(false);
            this.gbHorarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosAlumno;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstEstados;
        private System.Windows.Forms.GroupBox gbHorarios;
        private System.Windows.Forms.RadioButton rbVespertino;
        private System.Windows.Forms.RadioButton rbMatutino;
        private System.Windows.Forms.Button btnGuardar;
    }
}

