﻿
namespace Presentacion.Platos
{
    partial class EditarPlato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPlato));
            this.pxbImagen = new Guna.UI.WinForms.GunaPictureBox();
            this.btnSelectImagen = new Guna.UI.WinForms.GunaGradientButton();
            this.cbxCategoria = new Guna.UI.WinForms.GunaComboBox();
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.txtDescripcion = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtPrecio = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtCodigo = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pxbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pxbImagen
            // 
            this.pxbImagen.BackColor = System.Drawing.Color.Transparent;
            this.pxbImagen.BaseColor = System.Drawing.Color.White;
            this.pxbImagen.Location = new System.Drawing.Point(454, 77);
            this.pxbImagen.Name = "pxbImagen";
            this.pxbImagen.Radius = 10;
            this.pxbImagen.Size = new System.Drawing.Size(273, 169);
            this.pxbImagen.TabIndex = 57;
            this.pxbImagen.TabStop = false;
            // 
            // btnSelectImagen
            // 
            this.btnSelectImagen.AnimationHoverSpeed = 0.07F;
            this.btnSelectImagen.AnimationSpeed = 0.03F;
            this.btnSelectImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectImagen.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnSelectImagen.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnSelectImagen.BorderColor = System.Drawing.Color.Black;
            this.btnSelectImagen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelectImagen.FocusedColor = System.Drawing.Color.Empty;
            this.btnSelectImagen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectImagen.ForeColor = System.Drawing.Color.White;
            this.btnSelectImagen.Image = null;
            this.btnSelectImagen.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectImagen.Location = new System.Drawing.Point(530, 252);
            this.btnSelectImagen.Name = "btnSelectImagen";
            this.btnSelectImagen.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSelectImagen.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSelectImagen.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSelectImagen.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSelectImagen.OnHoverImage = null;
            this.btnSelectImagen.OnPressedColor = System.Drawing.Color.Black;
            this.btnSelectImagen.Radius = 10;
            this.btnSelectImagen.Size = new System.Drawing.Size(120, 36);
            this.btnSelectImagen.TabIndex = 56;
            this.btnSelectImagen.Text = "Seleccionar otra";
            this.btnSelectImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cbxCategoria.BaseColor = System.Drawing.Color.White;
            this.cbxCategoria.BorderColor = System.Drawing.Color.Black;
            this.cbxCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.cbxCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxCategoria.ForeColor = System.Drawing.Color.Black;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Merienda"});
            this.cbxCategoria.Location = new System.Drawing.Point(469, 324);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxCategoria.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxCategoria.Radius = 10;
            this.cbxCategoria.Size = new System.Drawing.Size(258, 26);
            this.cbxCategoria.TabIndex = 55;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.Black;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(54, 174);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.Radius = 10;
            this.txtNombre.Size = new System.Drawing.Size(258, 30);
            this.txtNombre.TabIndex = 54;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(49, 146);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(86, 25);
            this.gunaLabel9.TabIndex = 53;
            this.gunaLabel9.Text = "Nombre";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(407, 409);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(134, 42);
            this.gunaButton1.TabIndex = 52;
            this.gunaButton1.Text = "Cancelar";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(218, 409);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Radius = 10;
            this.btnGuardar.Size = new System.Drawing.Size(134, 42);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.BaseColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderColor = System.Drawing.Color.Black;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescripcion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDescripcion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.Location = new System.Drawing.Point(54, 324);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.Radius = 10;
            this.txtDescripcion.Size = new System.Drawing.Size(258, 30);
            this.txtDescripcion.TabIndex = 50;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(49, 296);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(108, 25);
            this.gunaLabel8.TabIndex = 49;
            this.gunaLabel8.Text = "Descipción";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(525, 49);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(79, 25);
            this.gunaLabel6.TabIndex = 48;
            this.gunaLabel6.Text = "Imagen";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(464, 296);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(98, 25);
            this.gunaLabel4.TabIndex = 47;
            this.gunaLabel4.Text = "Categoría";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecio.BaseColor = System.Drawing.Color.White;
            this.txtPrecio.BorderColor = System.Drawing.Color.Black;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrecio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrecio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecio.Location = new System.Drawing.Point(54, 249);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.Radius = 10;
            this.txtPrecio.Size = new System.Drawing.Size(258, 30);
            this.txtPrecio.TabIndex = 46;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(49, 221);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(68, 25);
            this.gunaLabel3.TabIndex = 45;
            this.gunaLabel3.Text = "Precio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.BaseColor = System.Drawing.Color.White;
            this.txtCodigo.BorderColor = System.Drawing.Color.Black;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCodigo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCodigo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(54, 101);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.Radius = 10;
            this.txtCodigo.Size = new System.Drawing.Size(258, 30);
            this.txtCodigo.TabIndex = 44;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(49, 74);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(77, 25);
            this.gunaLabel2.TabIndex = 43;
            this.gunaLabel2.Text = "Código";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(228, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(334, 40);
            this.gunaLabel1.TabIndex = 42;
            this.gunaLabel1.Text = "Editar datos del Platillo";
            // 
            // EditarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 460);
            this.Controls.Add(this.pxbImagen);
            this.Controls.Add(this.btnSelectImagen);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarPlato";
            this.Text = "EditarPlato";
            this.Load += new System.EventHandler(this.EditarPlato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox pxbImagen;
        private Guna.UI.WinForms.GunaGradientButton btnSelectImagen;
        private Guna.UI.WinForms.GunaComboBox cbxCategoria;
        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton btnGuardar;
        private Guna.UI.WinForms.GunaTextBox txtDescripcion;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtPrecio;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtCodigo;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}