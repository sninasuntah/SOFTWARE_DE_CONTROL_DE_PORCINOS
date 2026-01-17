namespace ControlPorcino
{
    partial class Alimentacion
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
            this.btnVolverAlimentación = new System.Windows.Forms.Button();
            this.lblIDAlimentacion = new System.Windows.Forms.Label();
            this.lblTipoAlimento = new System.Windows.Forms.Label();
            this.lblCantidadAlimentacion = new System.Windows.Forms.Label();
            this.lblFechaAlimentacion = new System.Windows.Forms.Label();
            this.txtIDAlimentacion = new System.Windows.Forms.TextBox();
            this.gbTipoAlimento = new System.Windows.Forms.GroupBox();
            this.rbSuplemento = new System.Windows.Forms.RadioButton();
            this.rbMaíz = new System.Windows.Forms.RadioButton();
            this.rbBalanceado = new System.Windows.Forms.RadioButton();
            this.txtCantidadAlimentacion = new System.Windows.Forms.TextBox();
            this.dtpAlimentacion = new System.Windows.Forms.DateTimePicker();
            this.dgvAlimentacion = new System.Windows.Forms.DataGridView();
            this.ColumnIDAlimentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidadAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaAlimentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarAlimentacion = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gbTipoAlimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverAlimentación
            // 
            this.btnVolverAlimentación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVolverAlimentación.Location = new System.Drawing.Point(35, 28);
            this.btnVolverAlimentación.Name = "btnVolverAlimentación";
            this.btnVolverAlimentación.Size = new System.Drawing.Size(95, 56);
            this.btnVolverAlimentación.TabIndex = 0;
            this.btnVolverAlimentación.Text = "Volver";
            this.btnVolverAlimentación.UseVisualStyleBackColor = false;
            this.btnVolverAlimentación.Click += new System.EventHandler(this.btnVolverAlimentación_Click);
            // 
            // lblIDAlimentacion
            // 
            this.lblIDAlimentacion.AutoSize = true;
            this.lblIDAlimentacion.BackColor = System.Drawing.Color.PeachPuff;
            this.lblIDAlimentacion.Location = new System.Drawing.Point(204, 50);
            this.lblIDAlimentacion.Name = "lblIDAlimentacion";
            this.lblIDAlimentacion.Size = new System.Drawing.Size(68, 13);
            this.lblIDAlimentacion.TabIndex = 1;
            this.lblIDAlimentacion.Text = "ID del cerdo:";
            this.lblIDAlimentacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTipoAlimento
            // 
            this.lblTipoAlimento.AutoSize = true;
            this.lblTipoAlimento.Location = new System.Drawing.Point(42, 119);
            this.lblTipoAlimento.Name = "lblTipoAlimento";
            this.lblTipoAlimento.Size = new System.Drawing.Size(88, 13);
            this.lblTipoAlimento.TabIndex = 2;
            this.lblTipoAlimento.Text = "Tipo de alimento:";
            this.lblTipoAlimento.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCantidadAlimentacion
            // 
            this.lblCantidadAlimentacion.AutoSize = true;
            this.lblCantidadAlimentacion.Location = new System.Drawing.Point(308, 119);
            this.lblCantidadAlimentacion.Name = "lblCantidadAlimentacion";
            this.lblCantidadAlimentacion.Size = new System.Drawing.Size(74, 13);
            this.lblCantidadAlimentacion.TabIndex = 3;
            this.lblCantidadAlimentacion.Text = "Cantidad (Kg):";
            // 
            // lblFechaAlimentacion
            // 
            this.lblFechaAlimentacion.AutoSize = true;
            this.lblFechaAlimentacion.Location = new System.Drawing.Point(42, 195);
            this.lblFechaAlimentacion.Name = "lblFechaAlimentacion";
            this.lblFechaAlimentacion.Size = new System.Drawing.Size(118, 13);
            this.lblFechaAlimentacion.TabIndex = 4;
            this.lblFechaAlimentacion.Text = "Fecha de Alimentación:";
            // 
            // txtIDAlimentacion
            // 
            this.txtIDAlimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtIDAlimentacion.Location = new System.Drawing.Point(322, 47);
            this.txtIDAlimentacion.Name = "txtIDAlimentacion";
            this.txtIDAlimentacion.Size = new System.Drawing.Size(100, 20);
            this.txtIDAlimentacion.TabIndex = 5;
            // 
            // gbTipoAlimento
            // 
            this.gbTipoAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbTipoAlimento.Controls.Add(this.rbSuplemento);
            this.gbTipoAlimento.Controls.Add(this.rbMaíz);
            this.gbTipoAlimento.Controls.Add(this.rbBalanceado);
            this.gbTipoAlimento.Location = new System.Drawing.Point(154, 90);
            this.gbTipoAlimento.Name = "gbTipoAlimento";
            this.gbTipoAlimento.Size = new System.Drawing.Size(132, 78);
            this.gbTipoAlimento.TabIndex = 6;
            this.gbTipoAlimento.TabStop = false;
            // 
            // rbSuplemento
            // 
            this.rbSuplemento.AutoSize = true;
            this.rbSuplemento.Location = new System.Drawing.Point(6, 55);
            this.rbSuplemento.Name = "rbSuplemento";
            this.rbSuplemento.Size = new System.Drawing.Size(81, 17);
            this.rbSuplemento.TabIndex = 2;
            this.rbSuplemento.TabStop = true;
            this.rbSuplemento.Text = "Suplemento";
            this.rbSuplemento.UseVisualStyleBackColor = true;
            this.rbSuplemento.CheckedChanged += new System.EventHandler(this.rbSuplemento_CheckedChanged);
            // 
            // rbMaíz
            // 
            this.rbMaíz.AutoSize = true;
            this.rbMaíz.Location = new System.Drawing.Point(6, 31);
            this.rbMaíz.Name = "rbMaíz";
            this.rbMaíz.Size = new System.Drawing.Size(49, 17);
            this.rbMaíz.TabIndex = 1;
            this.rbMaíz.TabStop = true;
            this.rbMaíz.Text = "Maíz";
            this.rbMaíz.UseVisualStyleBackColor = true;
            // 
            // rbBalanceado
            // 
            this.rbBalanceado.AutoSize = true;
            this.rbBalanceado.Location = new System.Drawing.Point(6, 10);
            this.rbBalanceado.Name = "rbBalanceado";
            this.rbBalanceado.Size = new System.Drawing.Size(82, 17);
            this.rbBalanceado.TabIndex = 0;
            this.rbBalanceado.TabStop = true;
            this.rbBalanceado.Text = "Balanceado";
            this.rbBalanceado.UseVisualStyleBackColor = true;
            // 
            // txtCantidadAlimentacion
            // 
            this.txtCantidadAlimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCantidadAlimentacion.Location = new System.Drawing.Point(401, 116);
            this.txtCantidadAlimentacion.Name = "txtCantidadAlimentacion";
            this.txtCantidadAlimentacion.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadAlimentacion.TabIndex = 7;
            // 
            // dtpAlimentacion
            // 
            this.dtpAlimentacion.Location = new System.Drawing.Point(278, 188);
            this.dtpAlimentacion.Name = "dtpAlimentacion";
            this.dtpAlimentacion.Size = new System.Drawing.Size(200, 20);
            this.dtpAlimentacion.TabIndex = 8;
            // 
            // dgvAlimentacion
            // 
            this.dgvAlimentacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvAlimentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlimentacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDAlimentacion,
            this.ColumnTipoAlimento,
            this.ColumnCantidadAlimento,
            this.ColumnFechaAlimentacion});
            this.dgvAlimentacion.Location = new System.Drawing.Point(45, 243);
            this.dgvAlimentacion.Name = "dgvAlimentacion";
            this.dgvAlimentacion.Size = new System.Drawing.Size(443, 150);
            this.dgvAlimentacion.TabIndex = 9;
            // 
            // ColumnIDAlimentacion
            // 
            this.ColumnIDAlimentacion.HeaderText = "ID del cerdo";
            this.ColumnIDAlimentacion.Name = "ColumnIDAlimentacion";
            // 
            // ColumnTipoAlimento
            // 
            this.ColumnTipoAlimento.HeaderText = "Tipo de Alimento";
            this.ColumnTipoAlimento.Name = "ColumnTipoAlimento";
            // 
            // ColumnCantidadAlimento
            // 
            this.ColumnCantidadAlimento.HeaderText = "Cantidad (Kg)";
            this.ColumnCantidadAlimento.Name = "ColumnCantidadAlimento";
            // 
            // ColumnFechaAlimentacion
            // 
            this.ColumnFechaAlimentacion.HeaderText = "Fecha de Alimentación";
            this.ColumnFechaAlimentacion.Name = "ColumnFechaAlimentacion";
            // 
            // btnGuardarAlimentacion
            // 
            this.btnGuardarAlimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarAlimentacion.Location = new System.Drawing.Point(418, 413);
            this.btnGuardarAlimentacion.Name = "btnGuardarAlimentacion";
            this.btnGuardarAlimentacion.Size = new System.Drawing.Size(95, 58);
            this.btnGuardarAlimentacion.TabIndex = 10;
            this.btnGuardarAlimentacion.Text = "Guardar";
            this.btnGuardarAlimentacion.UseVisualStyleBackColor = false;
            this.btnGuardarAlimentacion.Click += new System.EventHandler(this.btnGuardarAlimentacion_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Control_de_Alimentación__Ninasunta_;
            this.pictureBox5.Location = new System.Drawing.Point(0, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(938, 497);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // Alimentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(936, 495);
            this.Controls.Add(this.btnGuardarAlimentacion);
            this.Controls.Add(this.dgvAlimentacion);
            this.Controls.Add(this.dtpAlimentacion);
            this.Controls.Add(this.txtCantidadAlimentacion);
            this.Controls.Add(this.gbTipoAlimento);
            this.Controls.Add(this.txtIDAlimentacion);
            this.Controls.Add(this.lblFechaAlimentacion);
            this.Controls.Add(this.lblCantidadAlimentacion);
            this.Controls.Add(this.lblTipoAlimento);
            this.Controls.Add(this.lblIDAlimentacion);
            this.Controls.Add(this.btnVolverAlimentación);
            this.Controls.Add(this.pictureBox5);
            this.Name = "Alimentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.gbTipoAlimento.ResumeLayout(false);
            this.gbTipoAlimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverAlimentación;
        private System.Windows.Forms.Label lblIDAlimentacion;
        private System.Windows.Forms.Label lblTipoAlimento;
        private System.Windows.Forms.Label lblCantidadAlimentacion;
        private System.Windows.Forms.Label lblFechaAlimentacion;
        private System.Windows.Forms.TextBox txtIDAlimentacion;
        private System.Windows.Forms.GroupBox gbTipoAlimento;
        private System.Windows.Forms.TextBox txtCantidadAlimentacion;
        private System.Windows.Forms.DateTimePicker dtpAlimentacion;
        private System.Windows.Forms.DataGridView dgvAlimentacion;
        private System.Windows.Forms.RadioButton rbSuplemento;
        private System.Windows.Forms.RadioButton rbMaíz;
        private System.Windows.Forms.RadioButton rbBalanceado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDAlimentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidadAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaAlimentacion;
        private System.Windows.Forms.Button btnGuardarAlimentacion;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}