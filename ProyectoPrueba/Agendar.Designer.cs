
namespace ProyectoPrueba
{
    partial class Agendar
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
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Paciente = new System.Windows.Forms.ComboBox();
            this.cb_Medico = new System.Windows.Forms.ComboBox();
            this.Medico = new System.Windows.Forms.Label();
            this.dt_FechaHora = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonAgendar = new System.Windows.Forms.Button();
            this.tableCitas = new System.Windows.Forms.DataGridView();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "AGENDAR CITA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "Llene el formulario para agendar cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Paciente";
            // 
            // cb_Paciente
            // 
            this.cb_Paciente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Paciente.FormattingEnabled = true;
            this.cb_Paciente.Location = new System.Drawing.Point(15, 111);
            this.cb_Paciente.Name = "cb_Paciente";
            this.cb_Paciente.Size = new System.Drawing.Size(209, 27);
            this.cb_Paciente.TabIndex = 47;
            // 
            // cb_Medico
            // 
            this.cb_Medico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Medico.FormattingEnabled = true;
            this.cb_Medico.Location = new System.Drawing.Point(15, 173);
            this.cb_Medico.Name = "cb_Medico";
            this.cb_Medico.Size = new System.Drawing.Size(209, 27);
            this.cb_Medico.TabIndex = 49;
            // 
            // Medico
            // 
            this.Medico.AutoSize = true;
            this.Medico.BackColor = System.Drawing.Color.Transparent;
            this.Medico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medico.Location = new System.Drawing.Point(11, 151);
            this.Medico.Name = "Medico";
            this.Medico.Size = new System.Drawing.Size(57, 19);
            this.Medico.TabIndex = 48;
            this.Medico.Text = "Medico";
            // 
            // dt_FechaHora
            // 
            this.dt_FechaHora.CustomFormat = "dd-MM-yyyy hh:mm";
            this.dt_FechaHora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_FechaHora.Location = new System.Drawing.Point(16, 235);
            this.dt_FechaHora.Name = "dt_FechaHora";
            this.dt_FechaHora.Size = new System.Drawing.Size(200, 27);
            this.dt_FechaHora.TabIndex = 50;
            this.dt_FechaHora.ValueChanged += new System.EventHandler(this.dt_FechaHora_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Fecha y Hora";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.AutoSize = true;
            this.buttonEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(298, 268);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonEliminar.Size = new System.Drawing.Size(153, 31);
            this.buttonEliminar.TabIndex = 54;
            this.buttonEliminar.Text = "ELIMINAR CITA";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.AutoSize = true;
            this.buttonActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.Color.White;
            this.buttonActualizar.Location = new System.Drawing.Point(15, 312);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonActualizar.Size = new System.Drawing.Size(170, 31);
            this.buttonActualizar.TabIndex = 53;
            this.buttonActualizar.Text = "ACTUALIZAR CITA";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonAgendar
            // 
            this.buttonAgendar.AutoSize = true;
            this.buttonAgendar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAgendar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgendar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgendar.ForeColor = System.Drawing.Color.White;
            this.buttonAgendar.Location = new System.Drawing.Point(15, 268);
            this.buttonAgendar.Name = "buttonAgendar";
            this.buttonAgendar.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonAgendar.Size = new System.Drawing.Size(154, 31);
            this.buttonAgendar.TabIndex = 52;
            this.buttonAgendar.Text = "AGENDAR CITA";
            this.buttonAgendar.UseVisualStyleBackColor = false;
            this.buttonAgendar.Click += new System.EventHandler(this.buttonAgendar_Click);
            // 
            // tableCitas
            // 
            this.tableCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCitas.Location = new System.Drawing.Point(298, 111);
            this.tableCitas.Name = "tableCitas";
            this.tableCitas.Size = new System.Drawing.Size(588, 151);
            this.tableCitas.TabIndex = 55;
            this.tableCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCitas_CellContentClick);
            // 
            // buttonSalir
            // 
            this.buttonSalir.AutoSize = true;
            this.buttonSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSalir.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Location = new System.Drawing.Point(795, 339);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.buttonSalir.Size = new System.Drawing.Size(91, 31);
            this.buttonSalir.TabIndex = 56;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(295, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(323, 15);
            this.label10.TabIndex = 57;
            this.label10.Text = "Seleccione una cita de la tabla para actualizar o eliminar";
            // 
            // Agendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 382);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.tableCitas);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonAgendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_FechaHora);
            this.Controls.Add(this.cb_Medico);
            this.Controls.Add(this.Medico);
            this.Controls.Add(this.cb_Paciente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Agendar";
            this.Text = "Agendar";
            this.Load += new System.EventHandler(this.Agendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Paciente;
        private System.Windows.Forms.ComboBox cb_Medico;
        private System.Windows.Forms.Label Medico;
        private System.Windows.Forms.DateTimePicker dt_FechaHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonAgendar;
        private System.Windows.Forms.DataGridView tableCitas;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label10;
    }
}