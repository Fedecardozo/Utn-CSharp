
namespace Clase06_Ejer04
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
            this.groupIngresoNumero = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textNewNumber = new System.Windows.Forms.TextBox();
            this.groupOrden = new System.Windows.Forms.GroupBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.rBtnDescendente = new System.Windows.Forms.RadioButton();
            this.rBtnAscendete = new System.Windows.Forms.RadioButton();
            this.groupListaNumeros = new System.Windows.Forms.GroupBox();
            this.listNumeros = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupIngresoNumero.SuspendLayout();
            this.groupOrden.SuspendLayout();
            this.groupListaNumeros.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupIngresoNumero
            // 
            this.groupIngresoNumero.Controls.Add(this.btnAgregar);
            this.groupIngresoNumero.Controls.Add(this.textNewNumber);
            this.groupIngresoNumero.Location = new System.Drawing.Point(34, 33);
            this.groupIngresoNumero.Name = "groupIngresoNumero";
            this.groupIngresoNumero.Size = new System.Drawing.Size(295, 125);
            this.groupIngresoNumero.TabIndex = 0;
            this.groupIngresoNumero.TabStop = false;
            this.groupIngresoNumero.Text = "Ingrese un nuevo número";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(186, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 34);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // textNewNumber
            // 
            this.textNewNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNewNumber.Location = new System.Drawing.Point(19, 49);
            this.textNewNumber.Name = "textNewNumber";
            this.textNewNumber.Size = new System.Drawing.Size(125, 34);
            this.textNewNumber.TabIndex = 0;
            // 
            // groupOrden
            // 
            this.groupOrden.Controls.Add(this.btnOrdenar);
            this.groupOrden.Controls.Add(this.rBtnDescendente);
            this.groupOrden.Controls.Add(this.rBtnAscendete);
            this.groupOrden.Location = new System.Drawing.Point(34, 201);
            this.groupOrden.Name = "groupOrden";
            this.groupOrden.Size = new System.Drawing.Size(295, 160);
            this.groupOrden.TabIndex = 1;
            this.groupOrden.TabStop = false;
            this.groupOrden.Text = "Orden";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(166, 70);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(114, 34);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // rBtnDescendente
            // 
            this.rBtnDescendente.AutoSize = true;
            this.rBtnDescendente.Location = new System.Drawing.Point(19, 103);
            this.rBtnDescendente.Name = "rBtnDescendente";
            this.rBtnDescendente.Size = new System.Drawing.Size(116, 24);
            this.rBtnDescendente.TabIndex = 1;
            this.rBtnDescendente.TabStop = true;
            this.rBtnDescendente.Text = "Descendente";
            this.rBtnDescendente.UseVisualStyleBackColor = true;
            // 
            // rBtnAscendete
            // 
            this.rBtnAscendete.AutoSize = true;
            this.rBtnAscendete.Location = new System.Drawing.Point(19, 46);
            this.rBtnAscendete.Name = "rBtnAscendete";
            this.rBtnAscendete.Size = new System.Drawing.Size(107, 24);
            this.rBtnAscendete.TabIndex = 0;
            this.rBtnAscendete.TabStop = true;
            this.rBtnAscendete.Text = "Ascendente";
            this.rBtnAscendete.UseVisualStyleBackColor = true;
            // 
            // groupListaNumeros
            // 
            this.groupListaNumeros.Controls.Add(this.listNumeros);
            this.groupListaNumeros.Location = new System.Drawing.Point(377, 33);
            this.groupListaNumeros.Name = "groupListaNumeros";
            this.groupListaNumeros.Size = new System.Drawing.Size(301, 412);
            this.groupListaNumeros.TabIndex = 2;
            this.groupListaNumeros.TabStop = false;
            this.groupListaNumeros.Text = "Lista de números";
            // 
            // listNumeros
            // 
            this.listNumeros.FormattingEnabled = true;
            this.listNumeros.ItemHeight = 20;
            this.listNumeros.Location = new System.Drawing.Point(20, 37);
            this.listNumeros.Name = "listNumeros";
            this.listNumeros.Size = new System.Drawing.Size(265, 364);
            this.listNumeros.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(34, 397);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(250, 48);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 470);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupListaNumeros);
            this.Controls.Add(this.groupOrden);
            this.Controls.Add(this.groupIngresoNumero);
            this.Name = "FrmPrincipal";
            this.Text = "Ordenamiento";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupIngresoNumero.ResumeLayout(false);
            this.groupIngresoNumero.PerformLayout();
            this.groupOrden.ResumeLayout(false);
            this.groupOrden.PerformLayout();
            this.groupListaNumeros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupIngresoNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textNewNumber;
        private System.Windows.Forms.GroupBox groupOrden;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton rBtnDescendente;
        private System.Windows.Forms.RadioButton rBtnAscendete;
        private System.Windows.Forms.GroupBox groupListaNumeros;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox listNumeros;
    }
}

