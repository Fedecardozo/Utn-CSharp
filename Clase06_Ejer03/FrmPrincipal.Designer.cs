
namespace Clase06_Ejer03
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textTotalPagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDescuento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textImporte = new System.Windows.Forms.TextBox();
            this.importeCobrar = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTotalPagar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textDescuento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textImporte);
            this.groupBox1.Controls.Add(this.importeCobrar);
            this.groupBox1.Location = new System.Drawing.Point(32, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // textTotalPagar
            // 
            this.textTotalPagar.Enabled = false;
            this.textTotalPagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTotalPagar.Location = new System.Drawing.Point(294, 202);
            this.textTotalPagar.Name = "textTotalPagar";
            this.textTotalPagar.Size = new System.Drawing.Size(155, 34);
            this.textTotalPagar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(92, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total a pagar: ";
            // 
            // textDescuento
            // 
            this.textDescuento.BackColor = System.Drawing.SystemColors.Window;
            this.textDescuento.Enabled = false;
            this.textDescuento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDescuento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textDescuento.Location = new System.Drawing.Point(294, 141);
            this.textDescuento.Name = "textDescuento";
            this.textDescuento.Size = new System.Drawing.Size(155, 34);
            this.textDescuento.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descuento recibido:";
            // 
            // textImporte
            // 
            this.textImporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textImporte.Location = new System.Drawing.Point(315, 72);
            this.textImporte.Name = "textImporte";
            this.textImporte.Size = new System.Drawing.Size(155, 34);
            this.textImporte.TabIndex = 3;
            // 
            // importeCobrar
            // 
            this.importeCobrar.AutoSize = true;
            this.importeCobrar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.importeCobrar.Location = new System.Drawing.Point(24, 66);
            this.importeCobrar.Name = "importeCobrar";
            this.importeCobrar.Size = new System.Drawing.Size(291, 31);
            this.importeCobrar.TabIndex = 2;
            this.importeCobrar.Text = "Ingrese importe a cobrar: ";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(124, 342);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(145, 60);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(347, 342);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 60);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "FrmPrincipal";
            this.Text = "Descuento";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textTotalPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDescuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textImporte;
        private System.Windows.Forms.Label importeCobrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

