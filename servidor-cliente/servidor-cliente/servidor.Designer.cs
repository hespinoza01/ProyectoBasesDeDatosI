namespace servidor_cliente
{
    partial class Servidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servidor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.startServer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.stopServer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtIP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPuerto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.statusServer = new System.Windows.Forms.Label();
            this.buttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // startServer
            // 
            this.startServer.ActiveBorderThickness = 1;
            this.startServer.ActiveCornerRadius = 20;
            this.startServer.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.startServer.ActiveForecolor = System.Drawing.Color.SpringGreen;
            this.startServer.ActiveLineColor = System.Drawing.Color.SpringGreen;
            this.startServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.startServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startServer.BackgroundImage")));
            this.startServer.ButtonText = "Iniciar";
            this.startServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startServer.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.startServer.ForeColor = System.Drawing.Color.SeaGreen;
            this.startServer.IdleBorderThickness = 1;
            this.startServer.IdleCornerRadius = 20;
            this.startServer.IdleFillColor = System.Drawing.Color.SpringGreen;
            this.startServer.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.startServer.IdleLineColor = System.Drawing.Color.SpringGreen;
            this.startServer.Location = new System.Drawing.Point(15, 362);
            this.startServer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.startServer.Name = "startServer";
            this.startServer.Size = new System.Drawing.Size(120, 40);
            this.startServer.TabIndex = 1;
            this.startServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startServer.Click += new System.EventHandler(this.startServer_Click);
            // 
            // stopServer
            // 
            this.stopServer.ActiveBorderThickness = 1;
            this.stopServer.ActiveCornerRadius = 20;
            this.stopServer.ActiveFillColor = System.Drawing.Color.SpringGreen;
            this.stopServer.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.stopServer.ActiveLineColor = System.Drawing.Color.SpringGreen;
            this.stopServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.stopServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopServer.BackgroundImage")));
            this.stopServer.ButtonText = "Detener";
            this.stopServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopServer.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.stopServer.ForeColor = System.Drawing.Color.SeaGreen;
            this.stopServer.IdleBorderThickness = 1;
            this.stopServer.IdleCornerRadius = 20;
            this.stopServer.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.stopServer.IdleForecolor = System.Drawing.Color.SpringGreen;
            this.stopServer.IdleLineColor = System.Drawing.Color.SpringGreen;
            this.stopServer.Location = new System.Drawing.Point(203, 362);
            this.stopServer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.stopServer.Name = "stopServer";
            this.stopServer.Size = new System.Drawing.Size(120, 40);
            this.stopServer.TabIndex = 2;
            this.stopServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stopServer.Click += new System.EventHandler(this.stopServer_Click);
            // 
            // txtIP
            // 
            this.txtIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIP.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtIP.HintForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtIP.HintText = "IP Value";
            this.txtIP.isPassword = false;
            this.txtIP.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.txtIP.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.txtIP.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.txtIP.LineThickness = 2;
            this.txtIP.Location = new System.Drawing.Point(15, 288);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(190, 35);
            this.txtIP.TabIndex = 3;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPuerto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPuerto.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtPuerto.HintForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtPuerto.HintText = "Port";
            this.txtPuerto.isPassword = false;
            this.txtPuerto.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.txtPuerto.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.txtPuerto.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.txtPuerto.LineThickness = 2;
            this.txtPuerto.Location = new System.Drawing.Point(223, 288);
            this.txtPuerto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(100, 35);
            this.txtPuerto.TabIndex = 4;
            this.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusServer
            // 
            this.statusServer.AutoSize = true;
            this.statusServer.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusServer.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.statusServer.Location = new System.Drawing.Point(22, 71);
            this.statusServer.Name = "statusServer";
            this.statusServer.Size = new System.Drawing.Size(96, 33);
            this.statusServer.TabIndex = 5;
            this.statusServer.Text = "label1";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("buttonClose.ImageActive")));
            this.buttonClose.Location = new System.Drawing.Point(292, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(44, 44);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonClose.TabIndex = 6;
            this.buttonClose.TabStop = false;
            this.buttonClose.Zoom = 15;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(338, 416);
            this.Controls.Add(this.statusServer);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.stopServer);
            this.Controls.Add(this.startServer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 startServer;
        private Bunifu.Framework.UI.BunifuThinButton2 stopServer;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPuerto;
        private System.Windows.Forms.Label statusServer;
        private Bunifu.Framework.UI.BunifuImageButton buttonClose;
    }
}

