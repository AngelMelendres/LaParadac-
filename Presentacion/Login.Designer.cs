
namespace Presentacion
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnEntrar = new Guna.UI.WinForms.GunaGradientButton();
            this.lblRecuperar = new System.Windows.Forms.Label();
            this.txtCedula = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtContraseña = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // btnEntrar
            // 
            this.btnEntrar.AnimationHoverSpeed = 0.07F;
            this.btnEntrar.AnimationSpeed = 0.03F;
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(145)))));
            this.btnEntrar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(211)))), ((int)(((byte)(159)))));
            this.btnEntrar.BorderColor = System.Drawing.Color.Black;
            this.btnEntrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEntrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Image = null;
            this.btnEntrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEntrar.Location = new System.Drawing.Point(40, 404);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnEntrar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnEntrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEntrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEntrar.OnHoverImage = null;
            this.btnEntrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEntrar.Radius = 20;
            this.btnEntrar.Size = new System.Drawing.Size(293, 42);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Ingresar";
            this.btnEntrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblRecuperar
            // 
            this.lblRecuperar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRecuperar.AutoSize = true;
            this.lblRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperar.Location = new System.Drawing.Point(164, 362);
            this.lblRecuperar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecuperar.Name = "lblRecuperar";
            this.lblRecuperar.Size = new System.Drawing.Size(174, 17);
            this.lblRecuperar.TabIndex = 6;
            this.lblRecuperar.Text = "¿Olvidaste tu contraseña?";
            // 
            // txtCedula
            // 
            this.txtCedula.Animated = true;
            this.txtCedula.BackColor = System.Drawing.Color.White;
            this.txtCedula.BackgroundImage = global::Presentacion.Properties.Resources.User;
            this.txtCedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(145)))));
            this.txtCedula.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtCedula.LineColor = System.Drawing.Color.Gainsboro;
            this.txtCedula.Location = new System.Drawing.Point(40, 240);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.Size = new System.Drawing.Size(293, 35);
            this.txtCedula.TabIndex = 10;
            this.txtCedula.Text = "Cédula";
            this.txtCedula.TextOffsetX = 25;
            this.txtCedula.Enter += new System.EventHandler(this.txtCedula_Enter);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.BackgroundImage = global::Presentacion.Properties.Resources.Contraseña;
            this.txtContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(145)))));
            this.txtContraseña.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtContraseña.LineColor = System.Drawing.Color.Gainsboro;
            this.txtContraseña.Location = new System.Drawing.Point(40, 310);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '\0';
            this.txtContraseña.Size = new System.Drawing.Size(293, 35);
            this.txtContraseña.TabIndex = 9;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.TextOffsetX = 25;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "BIENVENIDO";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(138, 66);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaCirclePictureBox1.TabIndex = 12;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(145)))));
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(331, 8);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Teal;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(28, 27);
            this.gunaControlBox1.TabIndex = 13;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 486);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblRecuperar);
            this.Controls.Add(this.btnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLineTextBox txtCedula;
        private Guna.UI.WinForms.GunaLineTextBox txtContraseña;
        private System.Windows.Forms.Label lblRecuperar;
        private Guna.UI.WinForms.GunaGradientButton btnEntrar;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}

