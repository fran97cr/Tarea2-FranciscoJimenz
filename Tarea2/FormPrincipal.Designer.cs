namespace Tarea2
{
    partial class FormPrincipal
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
            this.lblTarea2 = new System.Windows.Forms.Label();
            this.TxtNomSalsAlta = new System.Windows.Forms.TextBox();
            this.lblNomSalMasAlta = new System.Windows.Forms.Label();
            this.TxtSalTipoB = new System.Windows.Forms.TextBox();
            this.lblSalTipoB = new System.Windows.Forms.Label();
            this.listSalariosProvincia = new System.Windows.Forms.ListBox();
            this.lblSalProvin = new System.Windows.Forms.Label();
            this.TxtTotalSalarios = new System.Windows.Forms.TextBox();
            this.lblTotalSalarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTarea2
            // 
            this.lblTarea2.AutoSize = true;
            this.lblTarea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea2.Location = new System.Drawing.Point(498, 59);
            this.lblTarea2.Name = "lblTarea2";
            this.lblTarea2.Size = new System.Drawing.Size(249, 25);
            this.lblTarea2.TabIndex = 36;
            this.lblTarea2.Text = "Tarea 2 Francisco Jimenez";
            // 
            // TxtNomSalsAlta
            // 
            this.TxtNomSalsAlta.Location = new System.Drawing.Point(668, 440);
            this.TxtNomSalsAlta.Name = "TxtNomSalsAlta";
            this.TxtNomSalsAlta.ReadOnly = true;
            this.TxtNomSalsAlta.Size = new System.Drawing.Size(120, 20);
            this.TxtNomSalsAlta.TabIndex = 44;
            // 
            // lblNomSalMasAlta
            // 
            this.lblNomSalMasAlta.AutoSize = true;
            this.lblNomSalMasAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomSalMasAlta.Location = new System.Drawing.Point(461, 440);
            this.lblNomSalMasAlta.Name = "lblNomSalMasAlta";
            this.lblNomSalMasAlta.Size = new System.Drawing.Size(210, 20);
            this.lblNomSalMasAlta.TabIndex = 43;
            this.lblNomSalMasAlta.Text = "Nomina de Salarios mas alta";
            // 
            // TxtSalTipoB
            // 
            this.TxtSalTipoB.Location = new System.Drawing.Point(668, 398);
            this.TxtSalTipoB.Name = "TxtSalTipoB";
            this.TxtSalTipoB.ReadOnly = true;
            this.TxtSalTipoB.Size = new System.Drawing.Size(120, 20);
            this.TxtSalTipoB.TabIndex = 42;
            // 
            // lblSalTipoB
            // 
            this.lblSalTipoB.AutoSize = true;
            this.lblSalTipoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalTipoB.Location = new System.Drawing.Point(461, 396);
            this.lblSalTipoB.Name = "lblSalTipoB";
            this.lblSalTipoB.Size = new System.Drawing.Size(201, 20);
            this.lblSalTipoB.TabIndex = 41;
            this.lblSalTipoB.Text = "Promedio de salarios tipo B";
            // 
            // listSalariosProvincia
            // 
            this.listSalariosProvincia.FormattingEnabled = true;
            this.listSalariosProvincia.Location = new System.Drawing.Point(465, 207);
            this.listSalariosProvincia.Name = "listSalariosProvincia";
            this.listSalariosProvincia.Size = new System.Drawing.Size(323, 147);
            this.listSalariosProvincia.TabIndex = 40;
            // 
            // lblSalProvin
            // 
            this.lblSalProvin.AutoSize = true;
            this.lblSalProvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalProvin.Location = new System.Drawing.Point(563, 173);
            this.lblSalProvin.Name = "lblSalProvin";
            this.lblSalProvin.Size = new System.Drawing.Size(160, 20);
            this.lblSalProvin.TabIndex = 39;
            this.lblSalProvin.Text = "Salarios por Provincia";
            // 
            // TxtTotalSalarios
            // 
            this.TxtTotalSalarios.Location = new System.Drawing.Point(665, 129);
            this.TxtTotalSalarios.Name = "TxtTotalSalarios";
            this.TxtTotalSalarios.ReadOnly = true;
            this.TxtTotalSalarios.Size = new System.Drawing.Size(123, 20);
            this.TxtTotalSalarios.TabIndex = 38;
            // 
            // lblTotalSalarios
            // 
            this.lblTotalSalarios.AutoSize = true;
            this.lblTotalSalarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalarios.Location = new System.Drawing.Point(461, 127);
            this.lblTotalSalarios.Name = "lblTotalSalarios";
            this.lblTotalSalarios.Size = new System.Drawing.Size(166, 20);
            this.lblTotalSalarios.TabIndex = 37;
            this.lblTotalSalarios.Text = "Suma total de salarios";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TxtNomSalsAlta);
            this.Controls.Add(this.lblNomSalMasAlta);
            this.Controls.Add(this.TxtSalTipoB);
            this.Controls.Add(this.lblSalTipoB);
            this.Controls.Add(this.listSalariosProvincia);
            this.Controls.Add(this.lblSalProvin);
            this.Controls.Add(this.TxtTotalSalarios);
            this.Controls.Add(this.lblTotalSalarios);
            this.Controls.Add(this.lblTarea2);
            this.Name = "FormPrincipal";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarea2;
        private System.Windows.Forms.TextBox TxtNomSalsAlta;
        private System.Windows.Forms.Label lblNomSalMasAlta;
        private System.Windows.Forms.TextBox TxtSalTipoB;
        private System.Windows.Forms.Label lblSalTipoB;
        private System.Windows.Forms.ListBox listSalariosProvincia;
        private System.Windows.Forms.Label lblSalProvin;
        private System.Windows.Forms.TextBox TxtTotalSalarios;
        private System.Windows.Forms.Label lblTotalSalarios;
    }
}

