
namespace DiegoMendez_proyectoADO_net
{
    partial class Form_comboSeleccionar_datagrid
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
            this.label_numLigas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_numEquipos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_nomLigas = new System.Windows.Forms.ComboBox();
            this.dataGridView_equipos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_equipos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de liga:";
            // 
            // label_numLigas
            // 
            this.label_numLigas.AutoSize = true;
            this.label_numLigas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numLigas.Location = new System.Drawing.Point(695, 26);
            this.label_numLigas.Name = "label_numLigas";
            this.label_numLigas.Size = new System.Drawing.Size(136, 20);
            this.label_numLigas.TabIndex = 1;
            this.label_numLigas.Text = "Número de ligas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Equipos de la liga:";
            // 
            // label_numEquipos
            // 
            this.label_numEquipos.AutoSize = true;
            this.label_numEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numEquipos.Location = new System.Drawing.Point(24, 371);
            this.label_numEquipos.Name = "label_numEquipos";
            this.label_numEquipos.Size = new System.Drawing.Size(159, 20);
            this.label_numEquipos.TabIndex = 3;
            this.label_numEquipos.Text = "Número de equipos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(582, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Autor: Diego Méndez";
            // 
            // comboBox_nomLigas
            // 
            this.comboBox_nomLigas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_nomLigas.FormattingEnabled = true;
            this.comboBox_nomLigas.Location = new System.Drawing.Point(157, 23);
            this.comboBox_nomLigas.Name = "comboBox_nomLigas";
            this.comboBox_nomLigas.Size = new System.Drawing.Size(515, 28);
            this.comboBox_nomLigas.TabIndex = 5;
            this.comboBox_nomLigas.SelectedIndexChanged += new System.EventHandler(this.comboBox_nomLigas_selectedIndexChanged);
            // 
            // dataGridView_equipos
            // 
            this.dataGridView_equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_equipos.Location = new System.Drawing.Point(28, 122);
            this.dataGridView_equipos.Name = "dataGridView_equipos";
            this.dataGridView_equipos.RowHeadersWidth = 51;
            this.dataGridView_equipos.RowTemplate.Height = 24;
            this.dataGridView_equipos.Size = new System.Drawing.Size(908, 224);
            this.dataGridView_equipos.TabIndex = 6;
            // 
            // Form_comboSeleccionar_datagrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 432);
            this.Controls.Add(this.dataGridView_equipos);
            this.Controls.Add(this.comboBox_nomLigas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_numEquipos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_numLigas);
            this.Controls.Add(this.label1);
            this.Name = "Form_comboSeleccionar_datagrid";
            this.Text = "Combo para seleccionar un datagrid";
            this.Load += new System.EventHandler(this.form_comboSeleccionar_datagrid_load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_equipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_numLigas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_numEquipos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_nomLigas;
        private System.Windows.Forms.DataGridView dataGridView_equipos;
    }
}