
namespace DiegoMendez_proyectoADO_net
{
    partial class Form_insercionRegistro
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
            this.textBox_nomEquipo = new System.Windows.Forms.TextBox();
            this.textBox_localidad = new System.Windows.Forms.TextBox();
            this.button_insertarEquipo = new System.Windows.Forms.Button();
            this.checkBox_internacional = new System.Windows.Forms.CheckBox();
            this.comboBox_nomLiga = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre equipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liga:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Localidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor: Diego Méndez";
            // 
            // textBox_nomEquipo
            // 
            this.textBox_nomEquipo.Location = new System.Drawing.Point(147, 19);
            this.textBox_nomEquipo.Name = "textBox_nomEquipo";
            this.textBox_nomEquipo.Size = new System.Drawing.Size(325, 26);
            this.textBox_nomEquipo.TabIndex = 4;
            // 
            // textBox_localidad
            // 
            this.textBox_localidad.Location = new System.Drawing.Point(106, 101);
            this.textBox_localidad.Name = "textBox_localidad";
            this.textBox_localidad.Size = new System.Drawing.Size(325, 26);
            this.textBox_localidad.TabIndex = 5;
            // 
            // button_insertarEquipo
            // 
            this.button_insertarEquipo.Location = new System.Drawing.Point(17, 146);
            this.button_insertarEquipo.Name = "button_insertarEquipo";
            this.button_insertarEquipo.Size = new System.Drawing.Size(282, 52);
            this.button_insertarEquipo.TabIndex = 6;
            this.button_insertarEquipo.Text = "Insertar Equipo";
            this.button_insertarEquipo.UseVisualStyleBackColor = true;
            this.button_insertarEquipo.Click += new System.EventHandler(this.button_insertarEquipo_click);
            // 
            // checkBox_internacional
            // 
            this.checkBox_internacional.AutoSize = true;
            this.checkBox_internacional.Location = new System.Drawing.Point(451, 100);
            this.checkBox_internacional.Name = "checkBox_internacional";
            this.checkBox_internacional.Size = new System.Drawing.Size(126, 24);
            this.checkBox_internacional.TabIndex = 7;
            this.checkBox_internacional.Text = "Internacional";
            this.checkBox_internacional.UseVisualStyleBackColor = true;
            // 
            // comboBox_nomLiga
            // 
            this.comboBox_nomLiga.FormattingEnabled = true;
            this.comboBox_nomLiga.Location = new System.Drawing.Point(66, 55);
            this.comboBox_nomLiga.Name = "comboBox_nomLiga";
            this.comboBox_nomLiga.Size = new System.Drawing.Size(316, 28);
            this.comboBox_nomLiga.TabIndex = 8;
            // 
            // Form_insercionRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 221);
            this.Controls.Add(this.comboBox_nomLiga);
            this.Controls.Add(this.checkBox_internacional);
            this.Controls.Add(this.button_insertarEquipo);
            this.Controls.Add(this.textBox_localidad);
            this.Controls.Add(this.textBox_nomEquipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_insercionRegistro";
            this.Text = "Inserción de registro";
            this.Load += new System.EventHandler(this.form_insercionRegistro_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nomEquipo;
        private System.Windows.Forms.TextBox textBox_localidad;
        private System.Windows.Forms.Button button_insertarEquipo;
        private System.Windows.Forms.CheckBox checkBox_internacional;
        private System.Windows.Forms.ComboBox comboBox_nomLiga;
    }
}