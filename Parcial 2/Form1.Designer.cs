namespace Parcial_2
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtFechaNac = new TextBox();
            txtPromedio = new TextBox();
            label3 = new Label();
            cmbCurso = new ComboBox();
            label4 = new Label();
            btnCargarUno = new Button();
            btnAgregar = new Button();
            btnConfirmar = new Button();
            label5 = new Label();
            txtIdModificar = new TextBox();
            label6 = new Label();
            btnModificar = new Button();
            txtNuevoNombre = new TextBox();
            txtNuevoPromedio = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cmbNuevoCurso = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            txtEliminar = new TextBox();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(193, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(595, 275);
            dataGridView1.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 104);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha de Nacimiento";
            // 
            // txtFechaNac
            // 
            txtFechaNac.Location = new Point(28, 133);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(100, 23);
            txtFechaNac.TabIndex = 4;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(28, 191);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(100, 23);
            txtPromedio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 173);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Promedio";
            // 
            // cmbCurso
            // 
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Location = new Point(28, 260);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(121, 23);
            cmbCurso.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 232);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "Curso";
            // 
            // btnCargarUno
            // 
            btnCargarUno.Location = new Point(28, 289);
            btnCargarUno.Name = "btnCargarUno";
            btnCargarUno.Size = new Size(159, 38);
            btnCargarUno.TabIndex = 9;
            btnCargarUno.Text = "Cargar un solo estudiante";
            btnCargarUno.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(28, 344);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(141, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar a la lista";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(28, 393);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(141, 23);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar cambios";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 322);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 12;
            label5.Text = "Modificar estudiante";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(325, 345);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(100, 23);
            txtIdModificar.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(222, 348);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 14;
            label6.Text = "Id del estudiante";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(292, 473);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(325, 374);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(100, 23);
            txtNuevoNombre.TabIndex = 16;
            // 
            // txtNuevoPromedio
            // 
            txtNuevoPromedio.Location = new Point(325, 403);
            txtNuevoPromedio.Name = "txtNuevoPromedio";
            txtNuevoPromedio.Size = new Size(100, 23);
            txtNuevoPromedio.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 377);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 18;
            label7.Text = "Nuevo nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(222, 406);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 19;
            label8.Text = "Nuevo promedio";
            // 
            // cmbNuevoCurso
            // 
            cmbNuevoCurso.FormattingEnabled = true;
            cmbNuevoCurso.Location = new Point(304, 432);
            cmbNuevoCurso.Name = "cmbNuevoCurso";
            cmbNuevoCurso.Size = new Size(121, 23);
            cmbNuevoCurso.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(224, 435);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 21;
            label9.Text = "Nuevo curso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(546, 322);
            label10.Name = "label10";
            label10.Size = new Size(143, 15);
            label10.TabIndex = 22;
            label10.Text = "Eliminar estudiante por ID";
            // 
            // txtEliminar
            // 
            txtEliminar.Location = new Point(576, 348);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(100, 23);
            txtEliminar.TabIndex = 23;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(590, 393);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(btnEliminar);
            Controls.Add(txtEliminar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cmbNuevoCurso);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtNuevoPromedio);
            Controls.Add(txtNuevoNombre);
            Controls.Add(btnModificar);
            Controls.Add(label6);
            Controls.Add(txtIdModificar);
            Controls.Add(label5);
            Controls.Add(btnConfirmar);
            Controls.Add(btnAgregar);
            Controls.Add(btnCargarUno);
            Controls.Add(label4);
            Controls.Add(cmbCurso);
            Controls.Add(label3);
            Controls.Add(txtPromedio);
            Controls.Add(txtFechaNac);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtFechaNac;
        private TextBox txtPromedio;
        private Label label3;
        private ComboBox cmbCurso;
        private Label label4;
        private Button btnCargarUno;
        private Button btnAgregar;
        private Button btnConfirmar;
        private Label label5;
        private TextBox txtIdModificar;
        private Label label6;
        private Button btnModificar;
        private TextBox txtNuevoNombre;
        private TextBox txtNuevoPromedio;
        private Label label7;
        private Label label8;
        private ComboBox cmbNuevoCurso;
        private Label label9;
        private Label label10;
        private TextBox txtEliminar;
        private Button btnEliminar;
    }
}
