namespace AppMatricula.Formularios_Menu
{
    partial class frmModificacionesMatriculas
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
            dgvResumenMatriculaActual = new DataGridView();
            dgvCursosDisponibles = new DataGridView();
            gbMatriculaActual = new GroupBox();
            gbCursosCandidatos = new GroupBox();
            gbDatosEstudiante = new GroupBox();
            btnAgregarCurso = new Button();
            btnRetirarCurso = new Button();
            label1 = new Label();
            cmbEscuelas = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbCiclos = new ComboBox();
            label4 = new Label();
            cmbEstudiantes = new ComboBox();
            label5 = new Label();
            cmbPeriodos = new ComboBox();
            pbVerMatricula = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            labelCantCursosMatriculados = new Label();
            labelCantidadCreditosMatriculados = new Label();
            pbGuardar = new PictureBox();
            pbSalir = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvResumenMatriculaActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCursosDisponibles).BeginInit();
            gbMatriculaActual.SuspendLayout();
            gbCursosCandidatos.SuspendLayout();
            gbDatosEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVerMatricula).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSalir).BeginInit();
            SuspendLayout();
            // 
            // dgvResumenMatriculaActual
            // 
            dgvResumenMatriculaActual.AllowUserToAddRows = false;
            dgvResumenMatriculaActual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumenMatriculaActual.Location = new Point(9, 57);
            dgvResumenMatriculaActual.Name = "dgvResumenMatriculaActual";
            dgvResumenMatriculaActual.ReadOnly = true;
            dgvResumenMatriculaActual.RowHeadersWidth = 51;
            dgvResumenMatriculaActual.Size = new Size(426, 366);
            dgvResumenMatriculaActual.TabIndex = 0;
            // 
            // dgvCursosDisponibles
            // 
            dgvCursosDisponibles.AllowUserToAddRows = false;
            dgvCursosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursosDisponibles.Location = new Point(10, 57);
            dgvCursosDisponibles.Name = "dgvCursosDisponibles";
            dgvCursosDisponibles.ReadOnly = true;
            dgvCursosDisponibles.RowHeadersWidth = 51;
            dgvCursosDisponibles.Size = new Size(426, 366);
            dgvCursosDisponibles.TabIndex = 1;
            // 
            // gbMatriculaActual
            // 
            gbMatriculaActual.BackColor = Color.White;
            gbMatriculaActual.Controls.Add(dgvResumenMatriculaActual);
            gbMatriculaActual.Controls.Add(btnRetirarCurso);
            gbMatriculaActual.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbMatriculaActual.ForeColor = Color.DimGray;
            gbMatriculaActual.Location = new Point(19, 130);
            gbMatriculaActual.Name = "gbMatriculaActual";
            gbMatriculaActual.Size = new Size(444, 433);
            gbMatriculaActual.TabIndex = 2;
            gbMatriculaActual.TabStop = false;
            gbMatriculaActual.Text = "Resumen Matricula Actual";
            // 
            // gbCursosCandidatos
            // 
            gbCursosCandidatos.BackColor = Color.White;
            gbCursosCandidatos.Controls.Add(btnAgregarCurso);
            gbCursosCandidatos.Controls.Add(dgvCursosDisponibles);
            gbCursosCandidatos.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbCursosCandidatos.ForeColor = Color.DimGray;
            gbCursosCandidatos.Location = new Point(482, 130);
            gbCursosCandidatos.Name = "gbCursosCandidatos";
            gbCursosCandidatos.Size = new Size(444, 433);
            gbCursosCandidatos.TabIndex = 3;
            gbCursosCandidatos.TabStop = false;
            gbCursosCandidatos.Text = "Cursos Disponibles";
            // 
            // gbDatosEstudiante
            // 
            gbDatosEstudiante.BackColor = Color.White;
            gbDatosEstudiante.Controls.Add(pbVerMatricula);
            gbDatosEstudiante.Controls.Add(label4);
            gbDatosEstudiante.Controls.Add(cmbEstudiantes);
            gbDatosEstudiante.Controls.Add(label5);
            gbDatosEstudiante.Controls.Add(cmbPeriodos);
            gbDatosEstudiante.Controls.Add(label3);
            gbDatosEstudiante.Controls.Add(cmbCiclos);
            gbDatosEstudiante.Controls.Add(label2);
            gbDatosEstudiante.Controls.Add(cmbEscuelas);
            gbDatosEstudiante.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDatosEstudiante.ForeColor = Color.DimGray;
            gbDatosEstudiante.Location = new Point(19, 10);
            gbDatosEstudiante.Name = "gbDatosEstudiante";
            gbDatosEstudiante.Size = new Size(905, 100);
            gbDatosEstudiante.TabIndex = 4;
            gbDatosEstudiante.TabStop = false;
            gbDatosEstudiante.Text = "Datos Estudiante";
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.BackColor = Color.FromArgb(106, 215, 117);
            btnAgregarCurso.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCurso.ForeColor = Color.White;
            btnAgregarCurso.Location = new Point(307, 13);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(114, 39);
            btnAgregarCurso.TabIndex = 1;
            btnAgregarCurso.Text = "Agregar";
            btnAgregarCurso.UseVisualStyleBackColor = false;
            // 
            // btnRetirarCurso
            // 
            btnRetirarCurso.BackColor = Color.FromArgb(248, 115, 82);
            btnRetirarCurso.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetirarCurso.ForeColor = Color.White;
            btnRetirarCurso.Location = new Point(309, 14);
            btnRetirarCurso.Name = "btnRetirarCurso";
            btnRetirarCurso.Size = new Size(114, 37);
            btnRetirarCurso.TabIndex = 2;
            btnRetirarCurso.Text = "Retirar";
            btnRetirarCurso.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(77, 122, 191);
            label1.Location = new Point(-6, 117);
            label1.Name = "label1";
            label1.Size = new Size(954, 3);
            label1.TabIndex = 5;
            // 
            // cmbEscuelas
            // 
            cmbEscuelas.FormattingEnabled = true;
            cmbEscuelas.Location = new Point(397, 21);
            cmbEscuelas.Name = "cmbEscuelas";
            cmbEscuelas.Size = new Size(322, 28);
            cmbEscuelas.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(329, 29);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Escuela:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(72, 63);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Ciclo:";
            // 
            // cmbCiclos
            // 
            cmbCiclos.FormattingEnabled = true;
            cmbCiclos.Location = new Point(126, 60);
            cmbCiclos.Name = "cmbCiclos";
            cmbCiclos.Size = new Size(140, 28);
            cmbCiclos.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(309, 63);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Estudiante:";
            // 
            // cmbEstudiantes
            // 
            cmbEstudiantes.FormattingEnabled = true;
            cmbEstudiantes.Location = new Point(397, 60);
            cmbEstudiantes.Name = "cmbEstudiantes";
            cmbEstudiantes.Size = new Size(322, 28);
            cmbEstudiantes.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(51, 29);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 5;
            label5.Text = "Periodo:";
            // 
            // cmbPeriodos
            // 
            cmbPeriodos.FormattingEnabled = true;
            cmbPeriodos.Location = new Point(126, 26);
            cmbPeriodos.Name = "cmbPeriodos";
            cmbPeriodos.Size = new Size(140, 28);
            cmbPeriodos.TabIndex = 4;
            // 
            // pbVerMatricula
            // 
            pbVerMatricula.Cursor = Cursors.Hand;
            pbVerMatricula.Image = Properties.Resources.icono_vr_matricula;
            pbVerMatricula.Location = new Point(741, 32);
            pbVerMatricula.Name = "pbVerMatricula";
            pbVerMatricula.Size = new Size(143, 40);
            pbVerMatricula.SizeMode = PictureBoxSizeMode.Zoom;
            pbVerMatricula.TabIndex = 8;
            pbVerMatricula.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(labelCantidadCreditosMatriculados);
            panel1.Controls.Add(labelCantCursosMatriculados);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(27, 569);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 49);
            panel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(19, 4);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 6;
            label6.Text = "Cursos matriculados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(19, 27);
            label7.Name = "label7";
            label7.Size = new Size(162, 20);
            label7.TabIndex = 7;
            label7.Text = "Créditos matriculados";
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveBorder;
            label8.Location = new Point(1, 24);
            label8.Name = "label8";
            label8.Size = new Size(426, 1);
            label8.TabIndex = 8;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ActiveBorder;
            label9.Location = new Point(313, -1);
            label9.Name = "label9";
            label9.Size = new Size(1, 49);
            label9.TabIndex = 9;
            // 
            // labelCantCursosMatriculados
            // 
            labelCantCursosMatriculados.BackColor = Color.FromArgb(106, 215, 117);
            labelCantCursosMatriculados.Location = new Point(364, 4);
            labelCantCursosMatriculados.Name = "labelCantCursosMatriculados";
            labelCantCursosMatriculados.Size = new Size(35, 18);
            labelCantCursosMatriculados.TabIndex = 10;
            // 
            // labelCantidadCreditosMatriculados
            // 
            labelCantidadCreditosMatriculados.BackColor = Color.FromArgb(138, 117, 183);
            labelCantidadCreditosMatriculados.Location = new Point(364, 28);
            labelCantidadCreditosMatriculados.Name = "labelCantidadCreditosMatriculados";
            labelCantidadCreditosMatriculados.Size = new Size(35, 18);
            labelCantidadCreditosMatriculados.TabIndex = 11;
            // 
            // pbGuardar
            // 
            pbGuardar.Cursor = Cursors.Hand;
            pbGuardar.Enabled = false;
            pbGuardar.Image = Properties.Resources.icono_guardar;
            pbGuardar.Location = new Point(577, 571);
            pbGuardar.Name = "pbGuardar";
            pbGuardar.Size = new Size(120, 46);
            pbGuardar.SizeMode = PictureBoxSizeMode.Zoom;
            pbGuardar.TabIndex = 7;
            pbGuardar.TabStop = false;
            // 
            // pbSalir
            // 
            pbSalir.Cursor = Cursors.Hand;
            pbSalir.Image = Properties.Resources.icono_salir;
            pbSalir.Location = new Point(760, 571);
            pbSalir.Name = "pbSalir";
            pbSalir.Size = new Size(63, 46);
            pbSalir.SizeMode = PictureBoxSizeMode.Zoom;
            pbSalir.TabIndex = 8;
            pbSalir.TabStop = false;
            // 
            // frmModificacionesMatriculas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(936, 626);
            Controls.Add(pbSalir);
            Controls.Add(pbGuardar);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(gbDatosEstudiante);
            Controls.Add(gbCursosCandidatos);
            Controls.Add(gbMatriculaActual);
            Name = "frmModificacionesMatriculas";
            Text = "frmModificacionesMatriculas";
            ((System.ComponentModel.ISupportInitialize)dgvResumenMatriculaActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCursosDisponibles).EndInit();
            gbMatriculaActual.ResumeLayout(false);
            gbCursosCandidatos.ResumeLayout(false);
            gbDatosEstudiante.ResumeLayout(false);
            gbDatosEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbVerMatricula).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvResumenMatriculaActual;
        private DataGridView dgvCursosDisponibles;
        private GroupBox gbMatriculaActual;
        private GroupBox gbCursosCandidatos;
        private Button btnAgregarCurso;
        private Button btnRetirarCurso;
        private GroupBox gbDatosEstudiante;
        private Label label1;
        private Label label4;
        private ComboBox cmbEstudiantes;
        private Label label5;
        private ComboBox cmbPeriodos;
        private Label label3;
        private ComboBox cmbCiclos;
        private Label label2;
        private ComboBox cmbEscuelas;
        private PictureBox pbVerMatricula;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label labelCantidadCreditosMatriculados;
        private Label labelCantCursosMatriculados;
        private PictureBox pbGuardar;
        private PictureBox pbSalir;
    }
}