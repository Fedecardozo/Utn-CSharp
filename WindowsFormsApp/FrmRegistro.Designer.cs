
namespace WindowsFormsApp
{
    partial class FrmRegistro
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
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
            this.radioBtnNoBinario = new System.Windows.Forms.RadioButton();
            this.radioBtnFemenino = new System.Windows.Forms.RadioButton();
            this.radioBtnMasculino = new System.Windows.Forms.RadioButton();
            this.groupBoxCursos = new System.Windows.Forms.GroupBox();
            this.checkBoxJavaScript = new System.Windows.Forms.CheckBox();
            this.checkBoxCMasMas = new System.Windows.Forms.CheckBox();
            this.checkBoxCSharp = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxPais = new System.Windows.Forms.ListBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            this.groupBoxGenero.SuspendLayout();
            this.groupBoxCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownEdad);
            this.groupBox1.Controls.Add(this.textBoxDireccion);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del usuario";
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(107, 129);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(162, 27);
            this.numericUpDownEdad.TabIndex = 5;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDireccion.Location = new System.Drawing.Point(107, 83);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(162, 30);
            this.textBoxDireccion.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.Location = new System.Drawing.Point(107, 37);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(162, 30);
            this.textBoxNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBoxGenero
            // 
            this.groupBoxGenero.Controls.Add(this.radioBtnNoBinario);
            this.groupBoxGenero.Controls.Add(this.radioBtnFemenino);
            this.groupBoxGenero.Controls.Add(this.radioBtnMasculino);
            this.groupBoxGenero.Location = new System.Drawing.Point(429, 27);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Size = new System.Drawing.Size(186, 145);
            this.groupBoxGenero.TabIndex = 1;
            this.groupBoxGenero.TabStop = false;
            this.groupBoxGenero.Text = "Género";
            // 
            // radioBtnNoBinario
            // 
            this.radioBtnNoBinario.AutoSize = true;
            this.radioBtnNoBinario.Location = new System.Drawing.Point(22, 101);
            this.radioBtnNoBinario.Name = "radioBtnNoBinario";
            this.radioBtnNoBinario.Size = new System.Drawing.Size(101, 24);
            this.radioBtnNoBinario.TabIndex = 2;
            this.radioBtnNoBinario.TabStop = true;
            this.radioBtnNoBinario.Text = "No binario";
            this.radioBtnNoBinario.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemenino
            // 
            this.radioBtnFemenino.AutoSize = true;
            this.radioBtnFemenino.Location = new System.Drawing.Point(22, 69);
            this.radioBtnFemenino.Name = "radioBtnFemenino";
            this.radioBtnFemenino.Size = new System.Drawing.Size(95, 24);
            this.radioBtnFemenino.TabIndex = 1;
            this.radioBtnFemenino.TabStop = true;
            this.radioBtnFemenino.Text = "Femenino";
            this.radioBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // radioBtnMasculino
            // 
            this.radioBtnMasculino.AutoSize = true;
            this.radioBtnMasculino.Location = new System.Drawing.Point(22, 38);
            this.radioBtnMasculino.Name = "radioBtnMasculino";
            this.radioBtnMasculino.Size = new System.Drawing.Size(97, 24);
            this.radioBtnMasculino.TabIndex = 0;
            this.radioBtnMasculino.TabStop = true;
            this.radioBtnMasculino.Text = "Masculino";
            this.radioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBoxCursos
            // 
            this.groupBoxCursos.Controls.Add(this.checkBoxJavaScript);
            this.groupBoxCursos.Controls.Add(this.checkBoxCMasMas);
            this.groupBoxCursos.Controls.Add(this.checkBoxCSharp);
            this.groupBoxCursos.Location = new System.Drawing.Point(429, 199);
            this.groupBoxCursos.Name = "groupBoxCursos";
            this.groupBoxCursos.Size = new System.Drawing.Size(186, 145);
            this.groupBoxCursos.TabIndex = 2;
            this.groupBoxCursos.TabStop = false;
            this.groupBoxCursos.Text = "Cursos";
            // 
            // checkBoxJavaScript
            // 
            this.checkBoxJavaScript.AutoSize = true;
            this.checkBoxJavaScript.Location = new System.Drawing.Point(40, 108);
            this.checkBoxJavaScript.Name = "checkBoxJavaScript";
            this.checkBoxJavaScript.Size = new System.Drawing.Size(97, 24);
            this.checkBoxJavaScript.TabIndex = 2;
            this.checkBoxJavaScript.Text = "JavaScript";
            this.checkBoxJavaScript.UseVisualStyleBackColor = true;
            // 
            // checkBoxCMasMas
            // 
            this.checkBoxCMasMas.AutoSize = true;
            this.checkBoxCMasMas.Location = new System.Drawing.Point(40, 67);
            this.checkBoxCMasMas.Name = "checkBoxCMasMas";
            this.checkBoxCMasMas.Size = new System.Drawing.Size(60, 24);
            this.checkBoxCMasMas.TabIndex = 1;
            this.checkBoxCMasMas.Text = "C++";
            this.checkBoxCMasMas.UseVisualStyleBackColor = true;
            // 
            // checkBoxCSharp
            // 
            this.checkBoxCSharp.AutoSize = true;
            this.checkBoxCSharp.Location = new System.Drawing.Point(40, 26);
            this.checkBoxCSharp.Name = "checkBoxCSharp";
            this.checkBoxCSharp.Size = new System.Drawing.Size(49, 24);
            this.checkBoxCSharp.TabIndex = 0;
            this.checkBoxCSharp.Text = "C#";
            this.checkBoxCSharp.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pais";
            // 
            // listBoxPais
            // 
            this.listBoxPais.FormattingEnabled = true;
            this.listBoxPais.ItemHeight = 20;
            this.listBoxPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.listBoxPais.Location = new System.Drawing.Point(53, 265);
            this.listBoxPais.Name = "listBoxPais";
            this.listBoxPais.Size = new System.Drawing.Size(291, 164);
            this.listBoxPais.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(429, 376);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(194, 53);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.listBoxPais);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxCursos);
            this.Controls.Add(this.groupBoxGenero);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistro";
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            this.groupBoxGenero.ResumeLayout(false);
            this.groupBoxGenero.PerformLayout();
            this.groupBoxCursos.ResumeLayout(false);
            this.groupBoxCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxGenero;
        private System.Windows.Forms.RadioButton radioBtnNoBinario;
        private System.Windows.Forms.RadioButton radioBtnFemenino;
        private System.Windows.Forms.RadioButton radioBtnMasculino;
        private System.Windows.Forms.GroupBox groupBoxCursos;
        private System.Windows.Forms.CheckBox checkBoxJavaScript;
        private System.Windows.Forms.CheckBox checkBoxCMasMas;
        private System.Windows.Forms.CheckBox checkBoxCSharp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}

