namespace YOUTUBE_CSharpForm_01DotNetFramework
{
    partial class frmMenuStrip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saludosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despedidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sub1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sub2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felicitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaMero1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaMero2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saludosToolStripMenuItem,
            this.despedidasToolStripMenuItem,
            this.felicitacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saludosToolStripMenuItem
            // 
            this.saludosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu1ToolStripMenuItem,
            this.subMenu2ToolStripMenuItem});
            this.saludosToolStripMenuItem.Name = "saludosToolStripMenuItem";
            this.saludosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.saludosToolStripMenuItem.Text = "Saludos";
            // 
            // subMenu1ToolStripMenuItem
            // 
            this.subMenu1ToolStripMenuItem.Name = "subMenu1ToolStripMenuItem";
            this.subMenu1ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.subMenu1ToolStripMenuItem.Text = "subMenu1";
            this.subMenu1ToolStripMenuItem.Click += new System.EventHandler(this.subMenu1ToolStripMenuItem_Click);
            // 
            // subMenu2ToolStripMenuItem
            // 
            this.subMenu2ToolStripMenuItem.Name = "subMenu2ToolStripMenuItem";
            this.subMenu2ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.subMenu2ToolStripMenuItem.Text = "subMenu2";
            this.subMenu2ToolStripMenuItem.Click += new System.EventHandler(this.subMenu2ToolStripMenuItem_Click);
            // 
            // despedidasToolStripMenuItem
            // 
            this.despedidasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub1ToolStripMenuItem,
            this.sub2ToolStripMenuItem});
            this.despedidasToolStripMenuItem.Name = "despedidasToolStripMenuItem";
            this.despedidasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.despedidasToolStripMenuItem.Text = "Despedidas";
            // 
            // sub1ToolStripMenuItem
            // 
            this.sub1ToolStripMenuItem.Name = "sub1ToolStripMenuItem";
            this.sub1ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.sub1ToolStripMenuItem.Text = "sub1";
            this.sub1ToolStripMenuItem.Click += new System.EventHandler(this.sub1ToolStripMenuItem_Click);
            // 
            // sub2ToolStripMenuItem
            // 
            this.sub2ToolStripMenuItem.Name = "sub2ToolStripMenuItem";
            this.sub2ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.sub2ToolStripMenuItem.Text = "sub2";
            this.sub2ToolStripMenuItem.Click += new System.EventHandler(this.sub2ToolStripMenuItem_Click);
            // 
            // felicitacionesToolStripMenuItem
            // 
            this.felicitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaMero1ToolStripMenuItem,
            this.yaMero2ToolStripMenuItem});
            this.felicitacionesToolStripMenuItem.Name = "felicitacionesToolStripMenuItem";
            this.felicitacionesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.felicitacionesToolStripMenuItem.Text = "Felicitaciones";
            // 
            // yaMero1ToolStripMenuItem
            // 
            this.yaMero1ToolStripMenuItem.Name = "yaMero1ToolStripMenuItem";
            this.yaMero1ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.yaMero1ToolStripMenuItem.Text = "yaMero1";
            // 
            // yaMero2ToolStripMenuItem
            // 
            this.yaMero2ToolStripMenuItem.Name = "yaMero2ToolStripMenuItem";
            this.yaMero2ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.yaMero2ToolStripMenuItem.Text = "yaMero2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cada uno de los elementos de MenuStrip\r\nva a funcionar como un boton";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Label para recibir informacion del formulario\r\nprincipal";
            // 
            // frmMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuStrip";
            this.Text = "frmMenuStrip";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saludosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMenu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMenu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despedidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sub1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sub2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felicitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaMero1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaMero2ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}