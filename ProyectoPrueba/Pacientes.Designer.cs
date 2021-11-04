
namespace ProyectoPrueba
{
    partial class Pacientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_SexoH = new System.Windows.Forms.RadioButton();
            this.rb_SexoM = new System.Windows.Forms.RadioButton();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.tablePacientes = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRADOR DE PACIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nombres.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombres.Location = new System.Drawing.Point(12, 83);
            this.txt_Nombres.MaxLength = 255;
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(208, 27);
            this.txt_Nombres.TabIndex = 1;
            this.txt_Nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombres_KeyPress);
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellidos.Location = new System.Drawing.Point(12, 145);
            this.txt_Apellidos.MaxLength = 255;
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(208, 27);
            this.txt_Apellidos.TabIndex = 2;
            this.txt_Apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellidos_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(12, 269);
            this.txt_Direccion.MaxLength = 255;
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(208, 27);
            this.txt_Direccion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Direccion";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(12, 331);
            this.txt_Telefono.MaxLength = 10;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(208, 27);
            this.txt_Telefono.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefono";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(12, 393);
            this.txt_Email.MaxLength = 255;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(208, 27);
            this.txt_Email.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // txt_Edad
            // 
            this.txt_Edad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Edad.Location = new System.Drawing.Point(12, 207);
            this.txt_Edad.MaxLength = 3;
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(61, 27);
            this.txt_Edad.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Edad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(121, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sexo";
            // 
            // rb_SexoH
            // 
            this.rb_SexoH.AutoSize = true;
            this.rb_SexoH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_SexoH.Location = new System.Drawing.Point(97, 211);
            this.rb_SexoH.Name = "rb_SexoH";
            this.rb_SexoH.Size = new System.Drawing.Size(37, 23);
            this.rb_SexoH.TabIndex = 4;
            this.rb_SexoH.TabStop = true;
            this.rb_SexoH.Text = "H";
            this.rb_SexoH.UseVisualStyleBackColor = true;
            // 
            // rb_SexoM
            // 
            this.rb_SexoM.AutoSize = true;
            this.rb_SexoM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_SexoM.Location = new System.Drawing.Point(153, 211);
            this.rb_SexoM.Name = "rb_SexoM";
            this.rb_SexoM.Size = new System.Drawing.Size(40, 23);
            this.rb_SexoM.TabIndex = 5;
            this.rb_SexoM.TabStop = true;
            this.rb_SexoM.Text = "M";
            this.rb_SexoM.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.AutoSize = true;
            this.buttonAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.Location = new System.Drawing.Point(12, 439);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonAgregar.Size = new System.Drawing.Size(188, 31);
            this.buttonAgregar.TabIndex = 16;
            this.buttonAgregar.Text = "AGREGAR PACIENTE";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.AutoSize = true;
            this.buttonActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.Color.White;
            this.buttonActualizar.Location = new System.Drawing.Point(12, 483);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonActualizar.Size = new System.Drawing.Size(206, 31);
            this.buttonActualizar.TabIndex = 17;
            this.buttonActualizar.Text = "ACTUALIZAR PACIENTE";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // tablePacientes
            // 
            this.tablePacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePacientes.Location = new System.Drawing.Point(373, 83);
            this.tablePacientes.Name = "tablePacientes";
            this.tablePacientes.Size = new System.Drawing.Size(886, 337);
            this.tablePacientes.TabIndex = 18;
            this.tablePacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePacientes_CellContentClick);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.AutoSize = true;
            this.buttonEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(373, 426);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonEliminar.Size = new System.Drawing.Size(189, 31);
            this.buttonEliminar.TabIndex = 19;
            this.buttonEliminar.Text = "ELIMINAR PACIENTE";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.AutoSize = true;
            this.buttonSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSalir.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Location = new System.Drawing.Point(1168, 483);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonSalir.Size = new System.Drawing.Size(91, 31);
            this.buttonSalir.TabIndex = 20;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Llene el formulario para agregar paciente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(370, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(342, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Seleccione un paciente de la tabla para eliminar o actualizar";
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 535);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.tablePacientes);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.rb_SexoM);
            this.Controls.Add(this.rb_SexoH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_SexoH;
        private System.Windows.Forms.RadioButton rb_SexoM;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridView tablePacientes;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}