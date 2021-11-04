
namespace ProyectoPrueba
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMedicos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAgendar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CITAS MEDICAS";
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.AutoSize = true;
            this.buttonPacientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPacientes.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPacientes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPacientes.ForeColor = System.Drawing.Color.White;
            this.buttonPacientes.Location = new System.Drawing.Point(18, 148);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonPacientes.Size = new System.Drawing.Size(126, 31);
            this.buttonPacientes.TabIndex = 2;
            this.buttonPacientes.Text = "PACIENTES";
            this.buttonPacientes.UseVisualStyleBackColor = false;
            this.buttonPacientes.Click += new System.EventHandler(this.buttonPacientes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Administracion";
            // 
            // buttonMedicos
            // 
            this.buttonMedicos.AutoSize = true;
            this.buttonMedicos.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonMedicos.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedicos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicos.ForeColor = System.Drawing.Color.White;
            this.buttonMedicos.Location = new System.Drawing.Point(18, 185);
            this.buttonMedicos.Name = "buttonMedicos";
            this.buttonMedicos.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonMedicos.Size = new System.Drawing.Size(126, 31);
            this.buttonMedicos.TabIndex = 4;
            this.buttonMedicos.Text = "MEDICOS";
            this.buttonMedicos.UseVisualStyleBackColor = false;
            this.buttonMedicos.Click += new System.EventHandler(this.buttonMedicos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleccione el area que desea administrar.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Si desea agendar cita seleccione la opcion.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Citas";
            // 
            // buttonAgendar
            // 
            this.buttonAgendar.AutoSize = true;
            this.buttonAgendar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAgendar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgendar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgendar.ForeColor = System.Drawing.Color.White;
            this.buttonAgendar.Location = new System.Drawing.Point(461, 148);
            this.buttonAgendar.Name = "buttonAgendar";
            this.buttonAgendar.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonAgendar.Size = new System.Drawing.Size(154, 31);
            this.buttonAgendar.TabIndex = 6;
            this.buttonAgendar.Text = "AGENDAR CITA";
            this.buttonAgendar.UseVisualStyleBackColor = false;
            this.buttonAgendar.Click += new System.EventHandler(this.buttonAgendar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.AutoSize = true;
            this.buttonSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSalir.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Location = new System.Drawing.Point(697, 407);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonSalir.Size = new System.Drawing.Size(91, 31);
            this.buttonSalir.TabIndex = 21;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAgendar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonMedicos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPacientes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Citas Medicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPacientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMedicos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAgendar;
        private System.Windows.Forms.Button buttonSalir;
    }
}

