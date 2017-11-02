namespace proyectoBD
{
    partial class viewCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewCarga));
            this.progress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.colorT = new System.Windows.Forms.Timer(this.components);
            this.label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.texto = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.animated = true;
            this.progress.animationIterval = 1;
            this.progress.animationSpeed = 1;
            this.progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.progress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress.BackgroundImage")));
            this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progress.ForeColor = System.Drawing.Color.SeaGreen;
            this.progress.LabelVisible = false;
            this.progress.LineProgressThickness = 8;
            this.progress.LineThickness = 5;
            this.progress.Location = new System.Drawing.Point(75, 194);
            this.progress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progress.MaxValue = 100;
            this.progress.Name = "progress";
            this.progress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.progress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.progress.Size = new System.Drawing.Size(150, 150);
            this.progress.TabIndex = 0;
            this.progress.Value = 30;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // colorT
            // 
            this.colorT.Interval = 20;
            this.colorT.Tick += new System.EventHandler(this.colorT_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Silver;
            this.label.Location = new System.Drawing.Point(34, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(126, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Iniciando...";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(36, 35);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(121, 17);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Por favor, espere.";
            // 
            // texto
            // 
            this.texto.Enabled = true;
            this.texto.Interval = 500;
            this.texto.Tick += new System.EventHandler(this.texto_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 7000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 63);
            this.panel1.TabIndex = 3;
            // 
            // viewCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(300, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewCarga";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewCarga";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar progress;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.Timer colorT;
        private Bunifu.Framework.UI.BunifuCustomLabel label;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Timer texto;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panel1;
    }
}