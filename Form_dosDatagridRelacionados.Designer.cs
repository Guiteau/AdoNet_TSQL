
namespace DiegoMendez_proyectoADO_net
{
    partial class Form_dosDatagridRelacionados
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
            this.label_numeroLigas = new System.Windows.Forms.Label();
            this.label_numeroEquipos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ligas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_equipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ligas
            // 
            this.dataGridView_ligas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ligas.Location = new System.Drawing.Point(12, 37);
            this.dataGridView_ligas.Name = "dataGridView_ligas";
            this.dataGridView_ligas.RowHeadersWidth = 51;
            this.dataGridView_ligas.RowTemplate.Height = 24;
            this.dataGridView_ligas.Size = new System.Drawing.Size(483, 320);
            this.dataGridView_ligas.TabIndex = 0;
            this.dataGridView_ligas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ligas_cellContentClick);
            // 
            // dataGridView_equipos
            // 
            this.dataGridView_equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_equipos.Location = new System.Drawing.Point(518, 38);
            this.dataGridView_equipos.Name = "dataGridView_equipos";
            this.dataGridView_equipos.RowHeadersWidth = 51;
            this.dataGridView_equipos.RowTemplate.Height = 24;
            this.dataGridView_equipos.Size = new System.Drawing.Size(1043, 319);
            this.dataGridView_equipos.TabIndex = 1;
            // 
            // label_numeroLigas
            // 
            this.label_numeroLigas.AutoSize = true;
            this.label_numeroLigas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numeroLigas.Location = new System.Drawing.Point(8, 374);
            this.label_numeroLigas.Name = "label_numeroLigas";
            this.label_numeroLigas.Size = new System.Drawing.Size(136, 20);
            this.label_numeroLigas.TabIndex = 2;
            this.label_numeroLigas.Text = "Número de ligas:";
            // 
            // label_numeroEquipos
            // 
            this.label_numeroEquipos.AutoSize = true;
            this.label_numeroEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numeroEquipos.Location = new System.Drawing.Point(514, 374);
            this.label_numeroEquipos.Name = "label_numeroEquipos";
            this.label_numeroEquipos.Size = new System.Drawing.Size(159, 20);
            this.label_numeroEquipos.TabIndex = 3;
            this.label_numeroEquipos.Text = "Número de equipos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(765, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor: Diego Méndez";
            // 
            // Form_dosDatagridRelacionados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_numeroEquipos);
            this.Controls.Add(this.label_numeroLigas);
            this.Controls.Add(this.dataGridView_equipos);
            this.Controls.Add(this.dataGridView_ligas);
            this.Name = "Form_dosDatagridRelacionados";
            this.Text = "Dos Datagrid Relacionados Equipos y Ligas";
            this.Load += new System.EventHandler(this.form_dosDatagridRelacionados_load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ligas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_equipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ligas;
        private System.Windows.Forms.DataGridView dataGridView_equipos;
        private System.Windows.Forms.Label label_numeroLigas;
        private System.Windows.Forms.Label label_numeroEquipos;
        private System.Windows.Forms.Label label3;
    }
}