
namespace DiegoMendez_proyectoADO_net
{
    partial class Form_borradoRegistro
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_codigoEquipo = new System.Windows.Forms.TextBox();
            this.textBox_nomEquipo = new System.Windows.Forms.TextBox();
            this.textBox_codLiga = new System.Windows.Forms.TextBox();
            this.textBox_localidad = new System.Windows.Forms.TextBox();
            this.button_cargarRegistro = new System.Windows.Forms.Button();
            this.checkBox_internacional = new System.Windows.Forms.CheckBox();
            this.button_borrarEquipo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor: Diego Méndez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre equipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código liga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Localidad:";
            // 
            // textBox_codigoEquipo
            // 
            this.textBox_codigoEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_codigoEquipo.Location = new System.Drawing.Point(95, 26);
            this.textBox_codigoEquipo.Name = "textBox_codigoEquipo";
            this.textBox_codigoEquipo.Size = new System.Drawing.Size(181, 26);
            this.textBox_codigoEquipo.TabIndex = 5;
            // 
            // textBox_nomEquipo
            // 
            this.textBox_nomEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nomEquipo.Location = new System.Drawing.Point(169, 94);
            this.textBox_nomEquipo.Name = "textBox_nomEquipo";
            this.textBox_nomEquipo.Size = new System.Drawing.Size(425, 26);
            this.textBox_nomEquipo.TabIndex = 6;
            // 
            // textBox_codLiga
            // 
            this.textBox_codLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_codLiga.Location = new System.Drawing.Point(140, 131);
            this.textBox_codLiga.Name = "textBox_codLiga";
            this.textBox_codLiga.Size = new System.Drawing.Size(253, 26);
            this.textBox_codLiga.TabIndex = 7;
            // 
            // textBox_localidad
            // 
            this.textBox_localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_localidad.Location = new System.Drawing.Point(130, 174);
            this.textBox_localidad.Name = "textBox_localidad";
            this.textBox_localidad.Size = new System.Drawing.Size(390, 26);
            this.textBox_localidad.TabIndex = 8;
            // 
            // button_cargarRegistro
            // 
            this.button_cargarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cargarRegistro.Location = new System.Drawing.Point(293, 22);
            this.button_cargarRegistro.Name = "button_cargarRegistro";
            this.button_cargarRegistro.Size = new System.Drawing.Size(166, 35);
            this.button_cargarRegistro.TabIndex = 9;
            this.button_cargarRegistro.Text = "Cargar registro";
            this.button_cargarRegistro.UseVisualStyleBackColor = true;
            this.button_cargarRegistro.Click += new System.EventHandler(this.button_cargarRegistro_click);
            // 
            // checkBox_internacional
            // 
            this.checkBox_internacional.AutoSize = true;
            this.checkBox_internacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_internacional.Location = new System.Drawing.Point(539, 176);
            this.checkBox_internacional.Name = "checkBox_internacional";
            this.checkBox_internacional.Size = new System.Drawing.Size(126, 24);
            this.checkBox_internacional.TabIndex = 10;
            this.checkBox_internacional.Text = "Internacional";
            this.checkBox_internacional.UseVisualStyleBackColor = true;
            // 
            // button_borrarEquipo
            // 
            this.button_borrarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrarEquipo.Location = new System.Drawing.Point(28, 218);
            this.button_borrarEquipo.Name = "button_borrarEquipo";
            this.button_borrarEquipo.Size = new System.Drawing.Size(301, 60);
            this.button_borrarEquipo.TabIndex = 11;
            this.button_borrarEquipo.Text = "Borrado Equipo";
            this.button_borrarEquipo.UseVisualStyleBackColor = true;
            this.button_borrarEquipo.Click += new System.EventHandler(this.button_borrarEquipo_click);
            // 
            // Form_borradoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 300);
            this.Controls.Add(this.button_borrarEquipo);
            this.Controls.Add(this.checkBox_internacional);
            this.Controls.Add(this.button_cargarRegistro);
            this.Controls.Add(this.textBox_localidad);
            this.Controls.Add(this.textBox_codLiga);
            this.Controls.Add(this.textBox_nomEquipo);
            this.Controls.Add(this.textBox_codigoEquipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_borradoRegistro";
            this.Text = "Borrado de registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_codigoEquipo;
        private System.Windows.Forms.TextBox textBox_nomEquipo;
        private System.Windows.Forms.TextBox textBox_codLiga;
        private System.Windows.Forms.TextBox textBox_localidad;
        private System.Windows.Forms.Button button_cargarRegistro;
        private System.Windows.Forms.CheckBox checkBox_internacional;
        private System.Windows.Forms.Button button_borrarEquipo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}