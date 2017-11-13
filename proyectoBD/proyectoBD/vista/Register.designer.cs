namespace proyectoBD
{
    partial class Register
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.edit = new System.Windows.Forms.PictureBox();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.apellidoTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nombreTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.perfil = new System.Windows.Forms.PictureBox();
            this.next = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lateral = new System.Windows.Forms.Panel();
            this.confirPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nomUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.finalizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bac = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfil)).BeginInit();
            this.lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bac)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 100;
            this.bunifuElipse2.TargetControl = this.edit;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.edit, BunifuAnimatorNS.DecorationType.None);
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Location = new System.Drawing.Point(205, 111);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(25, 25);
            this.edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.edit.TabIndex = 23;
            this.edit.TabStop = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // open
            // 
            this.open.FileName = "openFileDialog1";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.apellidoTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.apellidoTxt, BunifuAnimatorNS.DecorationType.None);
            this.apellidoTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.apellidoTxt.ForeColor = System.Drawing.Color.SpringGreen;
            this.apellidoTxt.HintForeColor = System.Drawing.Color.Empty;
            this.apellidoTxt.HintText = "";
            this.apellidoTxt.isPassword = false;
            this.apellidoTxt.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.apellidoTxt.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.apellidoTxt.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.apellidoTxt.LineThickness = 3;
            this.apellidoTxt.Location = new System.Drawing.Point(76, 303);
            this.apellidoTxt.Margin = new System.Windows.Forms.Padding(4);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(205, 30);
            this.apellidoTxt.TabIndex = 28;
            this.apellidoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.apellidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidoTxt_KeyPress);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(76, 283);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(51, 16);
            this.bunifuCustomLabel5.TabIndex = 29;
            this.bunifuCustomLabel5.Text = "Apellido";
            // 
            // nombreTxt
            // 
            this.nombreTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.nombreTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.nombreTxt, BunifuAnimatorNS.DecorationType.None);
            this.nombreTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nombreTxt.ForeColor = System.Drawing.Color.SpringGreen;
            this.nombreTxt.HintForeColor = System.Drawing.Color.Empty;
            this.nombreTxt.HintText = "";
            this.nombreTxt.isPassword = false;
            this.nombreTxt.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.nombreTxt.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.nombreTxt.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.nombreTxt.LineThickness = 3;
            this.nombreTxt.Location = new System.Drawing.Point(73, 208);
            this.nombreTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(205, 30);
            this.nombreTxt.TabIndex = 25;
            this.nombreTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nombreTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTxt_KeyPress);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(73, 188);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(51, 16);
            this.bunifuCustomLabel6.TabIndex = 26;
            this.bunifuCustomLabel6.Text = "Nombre";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.close, BunifuAnimatorNS.DecorationType.None);
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = ((System.Drawing.Image)(resources.GetObject("close.ImageActive")));
            this.close.Location = new System.Drawing.Point(362, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 24;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // perfil
            // 
            this.perfil.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.perfil, BunifuAnimatorNS.DecorationType.None);
            this.perfil.Image = ((System.Drawing.Image)(resources.GetObject("perfil.Image")));
            this.perfil.Location = new System.Drawing.Point(145, 36);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(100, 100);
            this.perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.perfil.TabIndex = 22;
            this.perfil.TabStop = false;
            // 
            // next
            // 
            this.next.ActiveBorderThickness = 1;
            this.next.ActiveCornerRadius = 20;
            this.next.ActiveFillColor = System.Drawing.Color.SpringGreen;
            this.next.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.next.ActiveLineColor = System.Drawing.Color.SpringGreen;
            this.next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.ButtonText = "Siguiente";
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.next, BunifuAnimatorNS.DecorationType.None);
            this.next.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.next.IdleBorderThickness = 1;
            this.next.IdleCornerRadius = 20;
            this.next.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.next.IdleForecolor = System.Drawing.Color.SpringGreen;
            this.next.IdleLineColor = System.Drawing.Color.SpringGreen;
            this.next.Location = new System.Drawing.Point(221, 403);
            this.next.Margin = new System.Windows.Forms.Padding(5);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(124, 40);
            this.next.TabIndex = 27;
            this.next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // lateral
            // 
            this.lateral.Controls.Add(this.confirPass);
            this.lateral.Controls.Add(this.pass);
            this.lateral.Controls.Add(this.bunifuCustomLabel3);
            this.lateral.Controls.Add(this.bunifuCustomLabel1);
            this.lateral.Controls.Add(this.nomUser);
            this.lateral.Controls.Add(this.bunifuCustomLabel2);
            this.lateral.Controls.Add(this.finalizar);
            this.bunifuTransition1.SetDecoration(this.lateral, BunifuAnimatorNS.DecorationType.None);
            this.lateral.Location = new System.Drawing.Point(9, 172);
            this.lateral.Name = "lateral";
            this.lateral.Size = new System.Drawing.Size(373, 283);
            this.lateral.TabIndex = 30;
            // 
            // confirPass
            // 
            this.confirPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.confirPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.confirPass, BunifuAnimatorNS.DecorationType.None);
            this.confirPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.confirPass.ForeColor = System.Drawing.Color.SpringGreen;
            this.confirPass.HintForeColor = System.Drawing.Color.Empty;
            this.confirPass.HintText = "";
            this.confirPass.isPassword = false;
            this.confirPass.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.confirPass.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.confirPass.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.confirPass.LineThickness = 3;
            this.confirPass.Location = new System.Drawing.Point(69, 169);
            this.confirPass.Margin = new System.Windows.Forms.Padding(4);
            this.confirPass.Name = "confirPass";
            this.confirPass.Size = new System.Drawing.Size(205, 30);
            this.confirPass.TabIndex = 38;
            this.confirPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.confirPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirPass_KeyPress);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.pass, BunifuAnimatorNS.DecorationType.None);
            this.pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pass.ForeColor = System.Drawing.Color.SpringGreen;
            this.pass.HintForeColor = System.Drawing.Color.Empty;
            this.pass.HintText = "";
            this.pass.isPassword = false;
            this.pass.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.pass.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.pass.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.pass.LineThickness = 3;
            this.pass.Location = new System.Drawing.Point(69, 110);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(205, 30);
            this.pass.TabIndex = 37;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pass_KeyPress);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(65, 146);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(127, 16);
            this.bunifuCustomLabel3.TabIndex = 36;
            this.bunifuCustomLabel3.Text = "Confirmar Contraseña";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(67, 92);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(72, 16);
            this.bunifuCustomLabel1.TabIndex = 34;
            this.bunifuCustomLabel1.Text = "Contraseña";
            // 
            // nomUser
            // 
            this.nomUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.nomUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.nomUser, BunifuAnimatorNS.DecorationType.None);
            this.nomUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nomUser.ForeColor = System.Drawing.Color.SpringGreen;
            this.nomUser.HintForeColor = System.Drawing.Color.Empty;
            this.nomUser.HintText = "";
            this.nomUser.isPassword = false;
            this.nomUser.LineFocusedColor = System.Drawing.Color.MediumSeaGreen;
            this.nomUser.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.nomUser.LineMouseHoverColor = System.Drawing.Color.MediumSeaGreen;
            this.nomUser.LineThickness = 3;
            this.nomUser.Location = new System.Drawing.Point(69, 49);
            this.nomUser.Margin = new System.Windows.Forms.Padding(4);
            this.nomUser.Name = "nomUser";
            this.nomUser.Size = new System.Drawing.Size(205, 30);
            this.nomUser.TabIndex = 30;
            this.nomUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nomUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomUser_KeyPress);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(64, 26);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(44, 16);
            this.bunifuCustomLabel2.TabIndex = 31;
            this.bunifuCustomLabel2.Text = "Correo";
            // 
            // finalizar
            // 
            this.finalizar.ActiveBorderThickness = 1;
            this.finalizar.ActiveCornerRadius = 20;
            this.finalizar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.finalizar.ActiveForecolor = System.Drawing.Color.SpringGreen;
            this.finalizar.ActiveLineColor = System.Drawing.Color.SpringGreen;
            this.finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.finalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finalizar.BackgroundImage")));
            this.finalizar.ButtonText = "Finalizar";
            this.finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.finalizar, BunifuAnimatorNS.DecorationType.None);
            this.finalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.finalizar.IdleBorderThickness = 1;
            this.finalizar.IdleCornerRadius = 20;
            this.finalizar.IdleFillColor = System.Drawing.Color.SpringGreen;
            this.finalizar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.finalizar.IdleLineColor = System.Drawing.Color.SpringGreen;
            this.finalizar.Location = new System.Drawing.Point(241, 239);
            this.finalizar.Margin = new System.Windows.Forms.Padding(5);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(124, 40);
            this.finalizar.TabIndex = 32;
            this.finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finalizar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // bac
            // 
            this.bac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.bac, BunifuAnimatorNS.DecorationType.None);
            this.bac.Image = ((System.Drawing.Image)(resources.GetObject("bac.Image")));
            this.bac.ImageActive = ((System.Drawing.Image)(resources.GetObject("bac.ImageActive")));
            this.bac.Location = new System.Drawing.Point(9, 6);
            this.bac.Name = "bac";
            this.bac.Size = new System.Drawing.Size(41, 25);
            this.bac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bac.TabIndex = 37;
            this.bac.TabStop = false;
            this.bac.Zoom = 10;
            this.bac.Click += new System.EventHandler(this.bac_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 100;
            this.bunifuElipse3.TargetControl = this.perfil;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(394, 467);
            this.Controls.Add(this.bac);
            this.Controls.Add(this.lateral);
            this.Controls.Add(this.close);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.apellidoTxt);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.perfil);
            this.Controls.Add(this.next);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfil)).EndInit();
            this.lateral.ResumeLayout(false);
            this.lateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.OpenFileDialog open;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.PictureBox edit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox apellidoTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nombreTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.PictureBox perfil;
        private Bunifu.Framework.UI.BunifuThinButton2 next;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nomUser;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 finalizar;
        private Bunifu.Framework.UI.BunifuImageButton bac;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox confirPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pass;
        public System.Windows.Forms.Panel lateral;
    }
}