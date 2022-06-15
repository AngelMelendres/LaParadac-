
namespace Presentacion.Ventas
{
    partial class ListadoVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.btnCerrar = new Guna.UI.WinForms.GunaButton();
            this.GroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnVer = new Guna.UI.WinForms.GunaButton();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.txtCedula = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnVender = new Guna.UI.WinForms.GunaButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.pnlFondo.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.btnCerrar);
            this.pnlFondo.Controls.Add(this.GroupBox1);
            this.pnlFondo.Controls.Add(this.btnVender);
            this.pnlFondo.Controls.Add(this.btnGuardar);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(776, 460);
            this.pnlFondo.TabIndex = 54;
            this.pnlFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFondo_Paint);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AnimationHoverSpeed = 0.07F;
            this.btnCerrar.AnimationSpeed = 0.03F;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.BorderColor = System.Drawing.Color.Black;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = null;
            this.btnCerrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCerrar.Location = new System.Drawing.Point(624, 420);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCerrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrar.Radius = 10;
            this.btnCerrar.Size = new System.Drawing.Size(74, 32);
            this.btnCerrar.TabIndex = 53;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.BaseColor = System.Drawing.Color.White;
            this.GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.GroupBox1.BorderSize = 1;
            this.GroupBox1.Controls.Add(this.btnVer);
            this.GroupBox1.Controls.Add(this.gunaDataGridView1);
            this.GroupBox1.Controls.Add(this.txtCedula);
            this.GroupBox1.Controls.Add(this.gunaLabel3);
            this.GroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Location = new System.Drawing.Point(22, 60);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Radius = 5;
            this.GroupBox1.Size = new System.Drawing.Size(702, 357);
            this.GroupBox1.TabIndex = 54;
            this.GroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnVer
            // 
            this.btnVer.AnimationHoverSpeed = 0.07F;
            this.btnVer.AnimationSpeed = 0.03F;
            this.btnVer.BackColor = System.Drawing.Color.Transparent;
            this.btnVer.BaseColor = System.Drawing.Color.Teal;
            this.btnVer.BorderColor = System.Drawing.Color.Black;
            this.btnVer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVer.FocusedColor = System.Drawing.Color.Empty;
            this.btnVer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Image = null;
            this.btnVer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVer.Location = new System.Drawing.Point(548, 18);
            this.btnVer.Name = "btnVer";
            this.btnVer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnVer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVer.OnHoverImage = null;
            this.btnVer.OnPressedColor = System.Drawing.Color.Black;
            this.btnVer.Radius = 10;
            this.btnVer.Size = new System.Drawing.Size(134, 32);
            this.btnVer.TabIndex = 55;
            this.btnVer.Text = "Ver Factura";
            this.btnVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(12, 67);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(670, 244);
            this.gunaDataGridView1.TabIndex = 58;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.Transparent;
            this.txtCedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtCedula.BaseColor = System.Drawing.Color.White;
            this.txtCedula.BorderColor = System.Drawing.Color.Black;
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCedula.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCedula.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCedula.Location = new System.Drawing.Point(200, 20);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.Radius = 10;
            this.txtCedula.Size = new System.Drawing.Size(308, 30);
            this.txtCedula.TabIndex = 55;
            this.txtCedula.TextOffsetX = 15;
            this.txtCedula.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCedula_KeyUp);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(21, 20);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(173, 25);
            this.gunaLabel3.TabIndex = 56;
            this.gunaLabel3.Text = "Cédula del cliente:";
            // 
            // btnVender
            // 
            this.btnVender.AnimationHoverSpeed = 0.07F;
            this.btnVender.AnimationSpeed = 0.03F;
            this.btnVender.BackColor = System.Drawing.Color.Transparent;
            this.btnVender.BaseColor = System.Drawing.Color.DarkSlateGray;
            this.btnVender.BorderColor = System.Drawing.Color.Black;
            this.btnVender.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVender.FocusedColor = System.Drawing.Color.Empty;
            this.btnVender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Image = global::Presentacion.Properties.Resources.money;
            this.btnVender.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVender.Location = new System.Drawing.Point(162, 12);
            this.btnVender.Name = "btnVender";
            this.btnVender.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnVender.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVender.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVender.OnHoverImage = null;
            this.btnVender.OnPressedColor = System.Drawing.Color.Black;
            this.btnVender.Size = new System.Drawing.Size(134, 42);
            this.btnVender.TabIndex = 53;
            this.btnVender.Text = "Vender";
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BaseColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Presentacion.Properties.Resources.lista;
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(22, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Size = new System.Drawing.Size(134, 42);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "Listado";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 460);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoVentas";
            this.Text = "ListadoVentas";
            this.pnlFondo.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnGuardar;
        private Guna.UI.WinForms.GunaButton btnVender;
        private System.Windows.Forms.Panel pnlFondo;
        private Guna.UI.WinForms.GunaGroupBox GroupBox1;
        private Guna.UI.WinForms.GunaButton btnCerrar;
        private Guna.UI.WinForms.GunaTextBox txtCedula;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btnVer;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
    }
}