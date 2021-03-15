
namespace DiegoMendez_proyectoADO_net
{
    partial class Form_comboDentroDatagrid
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
            this.dataGridView_ligas = new System.Windows.Forms.DataGridView();
            this.dataGridView_equipos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_numLigas = new System.Windows.Forms.Label();
            this.label_numEquipos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_guardarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ligas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_equipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ligas
            // 
            this.dataGridView_ligas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ligas.Location = new System.Drawing.Point(12, 80);
            this.dataGridView_ligas.Name = "dataGridView_ligas";
            this.dataGridView_ligas.RowHeadersWidth = 51;
            this.dataGridView_ligas.RowTemplate.Height = 24;
            this.dataGridView_ligas.Size = new System.Drawing.Size(529, 301);
            this.dataGridView_ligas.TabIndex = 0;
            // 
            // dataGridView_equipos
            // 
            this.dataGridView_equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_equipos.Location = new System.Drawing.Point(569, 80);
            this.dataGridView_equipos.Name = "dataGridView_equipos";
            this.dataGridView_equipos.RowHeadersWidth = 51;
            this.dataGridView_equipos.RowTemplate.Height = 24;
            this.dataGridView_equipos.Size = new System.Drawing.Size(768, 301);
            this.dataGridView_equipos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ligas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Equipos:";
            // 
            // label_numLigas
            // 
            this.label_numLigas.AutoSize = true;
            this.label_numLigas.Location = new System.Drawing.Point(12, 397);
            this.label_numLigas.Name = "label_numLigas";
            this.label_numLigas.Size = new System.Drawing.Size(136, 20);
            this.label_numLigas.TabIndex = 4;
            this.label_numLigas.Text = "Número de ligas:";
            // 
            // label_numEquipos
            // 
            this.label_numEquipos.AutoSize = true;
            this.label_numEquipos.Location = new System.Drawing.Point(565, 397);
            this.label_numEquipos.Name = "label_numEquipos";
            this.label_numEquipos.Size = new System.Drawing.Size(159, 20);
            this.label_numEquipos.TabIndex = 5;
            this.label_numEquipos.Text = "Número de equipos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(813, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Autor: Diego Méndez";
            // 
            // button_guardarDatos
            // 
            this.button_guardarDatos.Location = new System.Drawing.Point(242, 444);
            this.button_guardarDatos.Name = "button_guardarDatos";
            this.button_guardarDatos.Size = new System.Drawing.Size(429, 59);
            this.button_guardarDatos.TabIndex = 7;
            this.button_guardarDatos.Text = "Guardar datos";
            this.button_guardarDatos.UseVisualStyleBackColor = true;
            this.button_guardarDatos.Click += new System.EventHandler(this.button_guardarDatos_click);
            // 
            // Form_comboDentroDatagrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 525);
            this.Controls.Add(this.button_guardarDatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_numEquipos);
            this.Controls.Add(this.label_numLigas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_equipos);
            this.Controls.Add(this.dataGridView_ligas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_comboDentroDatagrid";
            this.Text = "Combo dentro de un Datagrid";
            this.Load += new System.EventHandler(this.form_comboDentroDatagrid_load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ligas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_equipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ligas;
        private System.Windows.Forms.DataGridView dataGridView_equipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_numLigas;
        private System.Windows.Forms.Label label_numEquipos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_guardarDatos;
    }
}