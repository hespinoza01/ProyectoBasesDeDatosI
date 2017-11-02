namespace proyectoBD
{
    partial class loginDiag
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginDiag));
            iTalk.ControlRenderer controlRenderer1 = new iTalk.ControlRenderer();
            iTalk.MSColorTable msColorTable1 = new iTalk.MSColorTable();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.yes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.mensaje = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.aceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.no = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.iTalk_ContextMenuStrip1 = new iTalk.iTalk_ContextMenuStrip();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.yes);
            this.panel1.Controls.Add(this.mensaje);
            this.panel1.Controls.Add(this.aceptar);
            this.panel1.Controls.Add(this.no);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 185);
            this.panel1.TabIndex = 2;
            // 
            // yes
            // 
            this.yes.ActiveBorderThickness = 1;
            this.yes.ActiveCornerRadius = 20;
            this.yes.ActiveFillColor = System.Drawing.Color.White;
            this.yes.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.yes.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(127)))), ((int)(((byte)(150)))));
            this.yes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.yes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yes.BackgroundImage")));
            this.yes.ButtonText = "Si";
            this.yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.ForeColor = System.Drawing.Color.SeaGreen;
            this.yes.IdleBorderThickness = 2;
            this.yes.IdleCornerRadius = 20;
            this.yes.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(127)))), ((int)(((byte)(150)))));
            this.yes.IdleForecolor = System.Drawing.Color.White;
            this.yes.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.yes.Location = new System.Drawing.Point(27, 126);
            this.yes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(92, 45);
            this.yes.TabIndex = 0;
            this.yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // mensaje
            // 
            this.mensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mensaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mensaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mensaje.HintForeColor = System.Drawing.Color.Empty;
            this.mensaje.HintText = "";
            this.mensaje.isPassword = false;
            this.mensaje.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.mensaje.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.mensaje.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.mensaje.LineThickness = 2;
            this.mensaje.Location = new System.Drawing.Point(13, 38);
            this.mensaje.Margin = new System.Windows.Forms.Padding(4);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(316, 61);
            this.mensaje.TabIndex = 2;
            this.mensaje.Text = "bunifuMaterialTextbox1";
            this.mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aceptar
            // 
            this.aceptar.ActiveBorderThickness = 1;
            this.aceptar.ActiveCornerRadius = 20;
            this.aceptar.ActiveFillColor = System.Drawing.Color.White;
            this.aceptar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.aceptar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(127)))), ((int)(((byte)(150)))));
            this.aceptar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptar.BackgroundImage")));
            this.aceptar.ButtonText = "Aceptar";
            this.aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.ForeColor = System.Drawing.Color.SeaGreen;
            this.aceptar.IdleBorderThickness = 2;
            this.aceptar.IdleCornerRadius = 20;
            this.aceptar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(127)))), ((int)(((byte)(150)))));
            this.aceptar.IdleForecolor = System.Drawing.Color.White;
            this.aceptar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.aceptar.Location = new System.Drawing.Point(125, 126);
            this.aceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(92, 45);
            this.aceptar.TabIndex = 1;
            this.aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // no
            // 
            this.no.ActiveBorderThickness = 1;
            this.no.ActiveCornerRadius = 20;
            this.no.ActiveFillColor = System.Drawing.Color.White;
            this.no.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.no.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(127)))), ((int)(((byte)(150)))));
            this.no.BackColor = System.Drawing.Color.WhiteSmoke;
            this.no.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("no.BackgroundImage")));
            this.no.ButtonText = "No";
            this.no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.ForeColor = System.Drawing.Color.SeaGreen;
            this.no.IdleBorderThickness = 2;
            this.no.IdleCornerRadius = 20;
            this.no.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(127)))), ((int)(((byte)(150)))));
            this.no.IdleForecolor = System.Drawing.Color.White;
            this.no.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.no.Location = new System.Drawing.Point(223, 126);
            this.no.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(92, 45);
            this.no.TabIndex = 2;
            this.no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // iTalk_ContextMenuStrip1
            // 
            this.iTalk_ContextMenuStrip1.Name = "iTalk_ContextMenuStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            this.iTalk_ContextMenuStrip1.Renderer = controlRenderer1;
            this.iTalk_ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // loginDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(342, 185);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(513, 305);
            this.Name = "loginDiag";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "loginDiag";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.loginDiag_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private Bunifu.Framework.UI.BunifuThinButton2 yes;
        private Bunifu.Framework.UI.BunifuThinButton2 aceptar;
        private Bunifu.Framework.UI.BunifuThinButton2 no;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mensaje;
        private iTalk.iTalk_ContextMenuStrip iTalk_ContextMenuStrip1;
    }
}