
namespace DiegoMendez_proyectoADO_net
{
    partial class Form_leerRegistros
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
            this.label_tituloLigas = new System.Windows.Forms.Label();
            this.label_numLigas = new System.Windows.Forms.Label();
            this.label_autor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ligas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ligas
            // 
            this.dataGridView_ligas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ligas.Location = new System.Drawing.Point(18, 50);
            this.dataGridView_ligas.Name = "dataGridView_ligas";
            this.dataGridView_ligas.RowHeadersWidth = 51;
            this.dataGridView_ligas.RowTemplate.Height = 24;
            this.dataGridView_ligas.Size = new System.Drawing.Size(499, 354);
            this.dataGridView_ligas.TabIndex = 0;
            // 
            // label_tituloLigas
            // 
            this.label_tituloLigas.AutoSize = true;
            this.label_tituloLigas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tituloLigas.Location = new System.Drawing.Point(14, 18);
            this.label_tituloLigas.Name = "label_tituloLigas";
            this.label_tituloLigas.Size = new System.Drawing.Size(55, 20);
            this.label_tituloLigas.TabIndex = 1;
            this.label_tituloLigas.Text = "Ligas:";
            // 
            // label_numLigas
            // 
            this.label_numLigas.AutoSize = true;
            this.label_numLigas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numLigas.Location = new System.Drawing.Point(14, 425);
            this.label_numLigas.Name = "label_numLigas";
            this.label_numLigas.Size = new System.Drawing.Size(136, 20);
            this.label_numLigas.TabIndex = 2;
            this.label_numLigas.Text = "Número de ligas:";
            // 
            // label_autor
            // 
            this.label_autor.AutoSize = true;
            this.label_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_autor.Location = new System.Drawing.Point(141, 473);
            this.label_autor.Name = "label_autor";
            this.label_autor.Size = new System.Drawing.Size(167, 20);
            this.label_autor.TabIndex = 3;
            this.label_autor.Text = "Autor: Diego Méndez";
            // 
            // Form_leerRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 517);
            this.Controls.Add(this.label_autor);
            this.Controls.Add(this.label_numLigas);
            this.Controls.Add(this.label_tituloLigas);
            this.Controls.Add(this.dataGridView_ligas);
            this.Name = "Form_leerRegistros";
            this.Text = "Leer registros de diferentes tablas";
            this.Load += new System.EventHandler(this.form_leerRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ligas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ligas;
        private System.Windows.Forms.Label label_tituloLigas;
        private System.Windows.Forms.Label label_numLigas;
        private System.Windows.Forms.Label label_autor;
    }
}