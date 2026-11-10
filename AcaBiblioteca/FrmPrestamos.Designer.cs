namespace AcaBiblioteca
{
    partial class FrmPrestamos
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblLibro = new Label();
            lblFechaPrestamo = new Label();
            lblFechaDevolucion = new Label();
            cmbUsuario = new ComboBox();
            cmbLibro = new ComboBox();
            dtpFechaPrestamo = new DateTimePicker();
            dtpFechaDevolucion = new DateTimePicker();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            dgvPrestamos = new DataGridView();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(70, 110, 230);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(950, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(950, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE PRÉSTAMOS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(230, 125);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(88, 28);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLibro.Location = new Point(230, 185);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(67, 28);
            lblLibro.TabIndex = 2;
            lblLibro.Text = "Libro:";
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaPrestamo.Location = new Point(230, 245);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(168, 28);
            lblFechaPrestamo.TabIndex = 3;
            lblFechaPrestamo.Text = "Fecha Préstamo:";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaDevolucion.Location = new Point(230, 305);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(185, 28);
            lblFechaDevolucion.TabIndex = 4;
            lblFechaDevolucion.Text = "Fecha Devolución:";
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(430, 125);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(250, 31);
            cmbUsuario.TabIndex = 5;
            // 
            // cmbLibro
            // 
            cmbLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLibro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(430, 185);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(250, 31);
            cmbLibro.TabIndex = 6;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(430, 245);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(250, 30);
            dtpFechaPrestamo.TabIndex = 7;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.ShowCheckBox = true;
            dtpFechaDevolucion.Location = new Point(430, 305);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(250, 30);
            dtpFechaDevolucion.TabIndex = 8;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(180, 380);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 35);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(300, 380);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 35);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(420, 380);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 35);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(540, 380);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(660, 380);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(50, 440);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(850, 200);
            dgvPrestamos.TabIndex = 14;
            dgvPrestamos.CellDoubleClick += dgvPrestamos_CellDoubleClick;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 660);
            Controls.Add(dgvPrestamos);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(cmbLibro);
            Controls.Add(cmbUsuario);
            Controls.Add(lblFechaDevolucion);
            Controls.Add(lblFechaPrestamo);
            Controls.Add(lblLibro);
            Controls.Add(lblUsuario);
            Controls.Add(pnlTitulo);
            Name = "FrmPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Préstamos";
            Load += FrmPrestamos_Load;
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblLibro;
        private Label lblFechaPrestamo;
        private Label lblFechaDevolucion;
        private ComboBox cmbUsuario;
        private ComboBox cmbLibro;
        private DateTimePicker dtpFechaPrestamo;
        private DateTimePicker dtpFechaDevolucion;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnCancelar;
        private DataGridView dgvPrestamos;
    }
}