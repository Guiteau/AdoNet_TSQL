
namespace DiegoMendez_proyectoADO_net
{
    partial class Form_edicionRegistro
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
            this.textBox_codEquipo = new System.Windows.Forms.TextBox();
            this.textBox_nomEquipo = new System.Windows.Forms.TextBox();
            this.textBox_localidad = new System.Windows.Forms.TextBox();
            this.button_cargaRegistro = new System.Windows.Forms.Button();
            this.button_grabaEquipo = new System.Windows.Forms.Button();
            this.checkBox_internacional = new System.Windows.Forms.CheckBox();
            this.comboBox_codLiga = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor: Diego Méndez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre equipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Liga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Localidad:";
            // 
            // textBox_codEquipo
            // 
            this.textBox_codEquipo.Location = new System.Drawing.Point(73, 21);
            this.textBox_codEquipo.Name = "textBox_codEquipo";
            this.textBox_codEquipo.Size = new System.Drawing.Size(226, 26);
            this.textBox_codEquipo.TabIndex = 5;
            // 
            // textBox_nomEquipo
            // 
            this.textBox_nomEquipo.Location = new System.Drawing.Point(166, 81);
            this.textBox_nomEquipo.Name = "textBox_nomEquipo";
            this.textBox_nomEquipo.Size = new System.Drawing.Size(480, 26);
            this.textBox_nomEquipo.TabIndex = 6;
            // 
            // textBox_localidad
            // 
            this.textBox_localidad.Location = new System.Drawing.Point(124, 187);
            this.textBox_localidad.Name = "textBox_localidad";
            this.textBox_localidad.Size = new System.Drawing.Size(390, 26);
            this.textBox_localidad.TabIndex = 7;
            // 
            // button_cargaRegistro
            // 
            this.button_cargaRegistro.Location = new System.Drawing.Point(321, 15);
            this.button_cargaRegistro.Name = "button_cargaRegistro";
            this.button_cargaRegistro.Size = new System.Drawing.Size(151, 39);
            this.button_cargaRegistro.TabIndex = 9;
            this.button_cargaRegistro.Text = "Cargar registro";
            this.button_cargaRegistro.UseVisualStyleBackColor = true;
            this.button_cargaRegistro.Click += new System.EventHandler(this.button_cargaRegistro_click);
            // 
            // button_grabaEquipo
            // 
            this.button_grabaEquipo.Location = new System.Drawing.Point(36, 236);
            this.button_grabaEquipo.Name = "button_grabaEquipo";
            this.button_grabaEquipo.Size = new System.Drawing.Size(312, 60);
            this.button_grabaEquipo.TabIndex = 10;
            this.button_grabaEquipo.Text = "Graba Equipo";
            this.button_grabaEquipo.UseVisualStyleBackColor = true;
            this.button_grabaEquipo.Click += new System.EventHandler(this.button_grabaEquipo_click);
            // 
            // checkBox_internacional
            // 
            this.checkBox_internacional.AutoSize = true;
            this.checkBox_internacional.Location = new System.Drawing.Point(529, 186);
            this.checkBox_internacional.Name = "checkBox_internacional";
            this.checkBox_internacional.Size = new System.Drawing.Size(126, 24);
            this.checkBox_internacional.TabIndex = 11;
            this.checkBox_internacional.Text = "Internacional";
            this.checkBox_internacional.UseVisualStyleBackColor = true;
            // 
            // comboBox_codLiga
            // 
            this.comboBox_codLiga.FormattingEnabled = true;
            this.comboBox_codLiga.Location = new System.Drawing.Point(86, 130);
            this.comboBox_codLiga.Name = "comboBox_codLiga";
            this.comboBox_codLiga.Size = new System.Drawing.Size(262, 28);
            this.comboBox_codLiga.TabIndex = 12;
            // 
            // Form_edicionRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 310);
            this.Controls.Add(this.comboBox_codLiga);
            this.Controls.Add(this.checkBox_internacional);
            this.Controls.Add(this.button_grabaEquipo);
            this.Controls.Add(this.button_cargaRegistro);
            this.Controls.Add(this.textBox_localidad);
            this.Controls.Add(this.textBox_nomEquipo);
            this.Controls.Add(this.textBox_codEquipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_edicionRegistro";
            this.Text = "Edición Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_codEquipo;
        private System.Windows.Forms.TextBox textBox_nomEquipo;
        private System.Windows.Forms.TextBox textBox_localidad;
        private System.Windows.Forms.Button button_cargaRegistro;
        private System.Windows.Forms.Button button_grabaEquipo;
        private System.Windows.Forms.CheckBox checkBox_internacional;
        private System.Windows.Forms.ComboBox comboBox_codLiga;
    }
}