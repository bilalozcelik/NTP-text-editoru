namespace text_editoru
{
    partial class Form1
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
            this.AnaMenu = new System.Windows.Forms.MenuStrip();
            this.menuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuYazdir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.cmDuzen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belge = new System.Drawing.Printing.PrintDocument();
            this.menuBicim = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYaziTipi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRenk = new System.Windows.Forms.ToolStripMenuItem();
            this.AnaMenu.SuspendLayout();
            this.cmDuzen.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnaMenu
            // 
            this.AnaMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDosya,
            this.menuDuzen,
            this.menuBicim,
            this.menuHakkinda});
            this.AnaMenu.Location = new System.Drawing.Point(0, 0);
            this.AnaMenu.Name = "AnaMenu";
            this.AnaMenu.Size = new System.Drawing.Size(800, 28);
            this.AnaMenu.TabIndex = 0;
            this.AnaMenu.Text = "menuStrip1";
            // 
            // menuDosya
            // 
            this.menuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYeni,
            this.menuAc,
            this.menuKaydet,
            this.toolStripSeparator1,
            this.menuYazdir,
            this.menuKapat});
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(64, 24);
            this.menuDosya.Text = "Dosya";
            // 
            // menuYeni
            // 
            this.menuYeni.Name = "menuYeni";
            this.menuYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuYeni.Size = new System.Drawing.Size(188, 26);
            this.menuYeni.Text = "Yeni";
            this.menuYeni.Click += new System.EventHandler(this.menuYeni_Click);
            // 
            // menuAc
            // 
            this.menuAc.Name = "menuAc";
            this.menuAc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuAc.Size = new System.Drawing.Size(188, 26);
            this.menuAc.Text = "Aç";
            this.menuAc.Click += new System.EventHandler(this.menuAc_Click);
            // 
            // menuKaydet
            // 
            this.menuKaydet.Name = "menuKaydet";
            this.menuKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuKaydet.Size = new System.Drawing.Size(188, 26);
            this.menuKaydet.Text = "Kaydet";
            this.menuKaydet.Click += new System.EventHandler(this.menuKaydet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // menuYazdir
            // 
            this.menuYazdir.Name = "menuYazdir";
            this.menuYazdir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuYazdir.Size = new System.Drawing.Size(188, 26);
            this.menuYazdir.Text = "Yazdır";
            this.menuYazdir.Click += new System.EventHandler(this.menuYazdir_Click);
            // 
            // menuKapat
            // 
            this.menuKapat.Name = "menuKapat";
            this.menuKapat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuKapat.Size = new System.Drawing.Size(188, 26);
            this.menuKapat.Text = "Kapat";
            this.menuKapat.Click += new System.EventHandler(this.menuKapat_Click);
            // 
            // menuDuzen
            // 
            this.menuDuzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKes,
            this.menuKopyala,
            this.menuYapistir});
            this.menuDuzen.Name = "menuDuzen";
            this.menuDuzen.Size = new System.Drawing.Size(65, 24);
            this.menuDuzen.Text = "Düzen";
            // 
            // menuKes
            // 
            this.menuKes.Name = "menuKes";
            this.menuKes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuKes.Size = new System.Drawing.Size(224, 26);
            this.menuKes.Text = "Kes";
            this.menuKes.Click += new System.EventHandler(this.menuKes_Click);
            // 
            // menuKopyala
            // 
            this.menuKopyala.Name = "menuKopyala";
            this.menuKopyala.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuKopyala.Size = new System.Drawing.Size(224, 26);
            this.menuKopyala.Text = "Kopyala";
            this.menuKopyala.Click += new System.EventHandler(this.menuKopyala_Click);
            // 
            // menuYapistir
            // 
            this.menuYapistir.Name = "menuYapistir";
            this.menuYapistir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuYapistir.Size = new System.Drawing.Size(224, 26);
            this.menuYapistir.Text = "Yapıştır";
            this.menuYapistir.Click += new System.EventHandler(this.menuYapistir_Click);
            // 
            // menuHakkinda
            // 
            this.menuHakkinda.Name = "menuHakkinda";
            this.menuHakkinda.Size = new System.Drawing.Size(85, 24);
            this.menuHakkinda.Text = "Hakkında";
            this.menuHakkinda.Click += new System.EventHandler(this.menuHakkinda_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.ContextMenuStrip = this.cmDuzen;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Location = new System.Drawing.Point(0, 28);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(800, 422);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "";
            // 
            // cmDuzen
            // 
            this.cmDuzen.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmDuzen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.cmDuzen.Name = "cmDuzen";
            this.cmDuzen.Size = new System.Drawing.Size(133, 76);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.kesToolStripMenuItem.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // belge
            // 
            this.belge.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.belge_PrintPage);
            // 
            // menuBicim
            // 
            this.menuBicim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYaziTipi,
            this.menuRenk});
            this.menuBicim.Name = "menuBicim";
            this.menuBicim.Size = new System.Drawing.Size(60, 24);
            this.menuBicim.Text = "Biçim";
            // 
            // menuYaziTipi
            // 
            this.menuYaziTipi.Name = "menuYaziTipi";
            this.menuYaziTipi.Size = new System.Drawing.Size(224, 26);
            this.menuYaziTipi.Text = "Yazı Tipi";
            this.menuYaziTipi.Click += new System.EventHandler(this.menuYaziTipi_Click);
            // 
            // menuRenk
            // 
            this.menuRenk.Name = "menuRenk";
            this.menuRenk.Size = new System.Drawing.Size(224, 26);
            this.menuRenk.Text = "Renk";
            this.menuRenk.Click += new System.EventHandler(this.menuRenk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.AnaMenu);
            this.MainMenuStrip = this.AnaMenu;
            this.Name = "Form1";
            this.Text = "Text Editörü 1.0";
            this.AnaMenu.ResumeLayout(false);
            this.AnaMenu.PerformLayout();
            this.cmDuzen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AnaMenu;
        private System.Windows.Forms.ToolStripMenuItem menuDuzen;
        private System.Windows.Forms.ToolStripMenuItem menuKes;
        private System.Windows.Forms.ToolStripMenuItem menuKopyala;
        private System.Windows.Forms.ToolStripMenuItem menuYapistir;
        private System.Windows.Forms.ToolStripMenuItem menuHakkinda;
        private System.Windows.Forms.ToolStripMenuItem menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuYeni;
        private System.Windows.Forms.ToolStripMenuItem menuAc;
        private System.Windows.Forms.ToolStripMenuItem menuKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuYazdir;
        private System.Windows.Forms.ToolStripMenuItem menuKapat;
        private System.Windows.Forms.RichTextBox txtEditor;
        private System.Windows.Forms.ContextMenuStrip cmDuzen;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument belge;
        private System.Windows.Forms.ToolStripMenuItem menuBicim;
        private System.Windows.Forms.ToolStripMenuItem menuYaziTipi;
        private System.Windows.Forms.ToolStripMenuItem menuRenk;
    }
}

