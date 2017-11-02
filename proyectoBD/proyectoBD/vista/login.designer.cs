namespace proyectoBD
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.addUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ingresar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.addUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.Transparent;
            this.addUser.Image = ((System.Drawing.Image)(resources.GetObject("addUser.Image")));
            this.addUser.ImageActive = ((System.Drawing.Image)(resources.GetObject("addUser.ImageActive")));
            this.addUser.Location = new System.Drawing.Point(417, 11);
            this.addUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(33, 31);
            this.addUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addUser.TabIndex = 11;
            this.addUser.TabStop = false;
            this.addUser.Zoom = 10;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ImageActive")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(459, 11);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.SpringGreen;
            this.username.HintForeColor = System.Drawing.Color.MediumSpringGreen;
            this.username.HintText = "Username";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.username.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.username.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.username.LineThickness = 2;
            this.username.Location = new System.Drawing.Point(85, 270);
            this.username.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(333, 54);
            this.username.TabIndex = 8;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.SpringGreen;
            this.password.HintForeColor = System.Drawing.Color.MediumSpringGreen;
            this.password.HintText = "";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.password.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.password.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.password.LineThickness = 2;
            this.password.Location = new System.Drawing.Point(85, 352);
            this.password.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(333, 54);
            this.password.TabIndex = 7;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // ingresar
            // 
            this.ingresar.ActiveBorderThickness = 1;
            this.ingresar.ActiveCornerRadius = 20;
            this.ingresar.ActiveFillColor = System.Drawing.Color.SpringGreen;
            this.ingresar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.ingresar.ActiveLineColor = System.Drawing.Color.SpringGreen;
            this.ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.ingresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingresar.BackgroundImage")));
            this.ingresar.ButtonText = "Ingresar";
            this.ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ingresar.IdleBorderThickness = 1;
            this.ingresar.IdleCornerRadius = 20;
            this.ingresar.IdleFillColor = System.Drawing.Color.Transparent;
            this.ingresar.IdleForecolor = System.Drawing.Color.SpringGreen;
            this.ingresar.IdleLineColor = System.Drawing.Color.SpringGreen;
            this.ingresar.Location = new System.Drawing.Point(85, 494);
            this.ingresar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(333, 55);
            this.ingresar.TabIndex = 6;
            this.ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(504, 581);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        public Bunifu.Framework.UI.BunifuImageButton addUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        public Bunifu.Framework.UI.BunifuThinButton2 ingresar;
    }
}

