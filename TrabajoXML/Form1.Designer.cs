namespace TrabajoXML
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtObjeto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccionAgre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreAgre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidosAgre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdAgre = new System.Windows.Forms.TextBox();
            this.btnGuardarAgre = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionMod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellidosMod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdMod = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdDel = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtInfo_xml = new System.Windows.Forms.TextBox();
            this.btnBuscarRuta = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 397);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscarRuta);
            this.tabPage1.Controls.Add(this.txtObjeto);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ruta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtObjeto
            // 
            this.txtObjeto.Location = new System.Drawing.Point(92, 47);
            this.txtObjeto.Name = "txtObjeto";
            this.txtObjeto.Size = new System.Drawing.Size(100, 20);
            this.txtObjeto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de objeto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(199, 44);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la ruta donde quiera guardarlo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtDireccionAgre);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtNombreAgre);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtApellidosAgre);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtIdAgre);
            this.tabPage2.Controls.Add(this.btnGuardarAgre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Direccion";
            // 
            // txtDireccionAgre
            // 
            this.txtDireccionAgre.Location = new System.Drawing.Point(64, 88);
            this.txtDireccionAgre.Name = "txtDireccionAgre";
            this.txtDireccionAgre.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionAgre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre";
            // 
            // txtNombreAgre
            // 
            this.txtNombreAgre.Location = new System.Drawing.Point(54, 36);
            this.txtNombreAgre.Name = "txtNombreAgre";
            this.txtNombreAgre.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAgre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellidos";
            // 
            // txtApellidosAgre
            // 
            this.txtApellidosAgre.Location = new System.Drawing.Point(61, 62);
            this.txtApellidosAgre.Name = "txtApellidosAgre";
            this.txtApellidosAgre.Size = new System.Drawing.Size(100, 20);
            this.txtApellidosAgre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id";
            // 
            // txtIdAgre
            // 
            this.txtIdAgre.Location = new System.Drawing.Point(28, 10);
            this.txtIdAgre.Name = "txtIdAgre";
            this.txtIdAgre.Size = new System.Drawing.Size(100, 20);
            this.txtIdAgre.TabIndex = 1;
            // 
            // btnGuardarAgre
            // 
            this.btnGuardarAgre.Location = new System.Drawing.Point(28, 114);
            this.btnGuardarAgre.Name = "btnGuardarAgre";
            this.btnGuardarAgre.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAgre.TabIndex = 0;
            this.btnGuardarAgre.Text = "Guardar";
            this.btnGuardarAgre.UseVisualStyleBackColor = true;
            this.btnGuardarAgre.Click += new System.EventHandler(this.btnGuardarAgre_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtDireccionMod);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtNombreMod);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtApellidosMod);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtIdMod);
            this.tabPage3.Controls.Add(this.btnModificar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(575, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Direccion";
            // 
            // txtDireccionMod
            // 
            this.txtDireccionMod.Location = new System.Drawing.Point(58, 84);
            this.txtDireccionMod.Name = "txtDireccionMod";
            this.txtDireccionMod.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionMod.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nombre";
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(48, 32);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMod.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Apellidos";
            // 
            // txtApellidosMod
            // 
            this.txtApellidosMod.Location = new System.Drawing.Point(55, 58);
            this.txtApellidosMod.Name = "txtApellidosMod";
            this.txtApellidosMod.Size = new System.Drawing.Size(100, 20);
            this.txtApellidosMod.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Id";
            // 
            // txtIdMod
            // 
            this.txtIdMod.Location = new System.Drawing.Point(22, 6);
            this.txtIdMod.Name = "txtIdMod";
            this.txtIdMod.Size = new System.Drawing.Size(100, 20);
            this.txtIdMod.TabIndex = 10;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(22, 110);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.txtIdDel);
            this.tabPage4.Controls.Add(this.btnEliminar);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(575, 371);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Id";
            // 
            // txtIdDel
            // 
            this.txtIdDel.Location = new System.Drawing.Point(24, 6);
            this.txtIdDel.Name = "txtIdDel";
            this.txtIdDel.Size = new System.Drawing.Size(100, 20);
            this.txtIdDel.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(24, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtInfo_xml);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(575, 371);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Archivo";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtInfo_xml
            // 
            this.txtInfo_xml.Location = new System.Drawing.Point(6, 6);
            this.txtInfo_xml.Multiline = true;
            this.txtInfo_xml.Name = "txtInfo_xml";
            this.txtInfo_xml.ReadOnly = true;
            this.txtInfo_xml.Size = new System.Drawing.Size(563, 359);
            this.txtInfo_xml.TabIndex = 0;
            // 
            // btnBuscarRuta
            // 
            this.btnBuscarRuta.Location = new System.Drawing.Point(199, 14);
            this.btnBuscarRuta.Name = "btnBuscarRuta";
            this.btnBuscarRuta.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRuta.TabIndex = 5;
            this.btnBuscarRuta.Text = "Buscar Ruta";
            this.btnBuscarRuta.UseVisualStyleBackColor = true;
            this.btnBuscarRuta.Click += new System.EventHandler(this.btnBuscarRuta_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 425);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtObjeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccionAgre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreAgre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidosAgre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdAgre;
        private System.Windows.Forms.Button btnGuardarAgre;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccionMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellidosMod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdMod;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIdDel;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtInfo_xml;
        private System.Windows.Forms.Button btnBuscarRuta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

