 
namespace PROJE_VTYS_OTOMASYON
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnStok = new DevExpress.XtraBars.BarButtonItem();
            this.BtnVeresiye = new DevExpress.XtraBars.BarButtonItem();
            this.BtnIrsaliye = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAyar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGrafikler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnToplualim = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAlisveris = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnUrunler,
            this.BtnMusteriler,
            this.BtnStok,
            this.BtnVeresiye,
            this.BtnIrsaliye,
            this.BtnAyar,
            this.BtnAnasayfa,
            this.BtnGrafikler,
            this.BtnToplualim,
            this.BtnAlisveris});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1182, 183);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Caption = "ÜRÜNLER";
            this.BtnUrunler.Id = 1;
            this.BtnUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunler.ImageOptions.Image")));
            this.BtnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnUrunler.ImageOptions.LargeImage")));
            this.BtnUrunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnUrunler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUrunler_ItemClick);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.Caption = "MÜŞTERİLER";
            this.BtnMusteriler.Id = 2;
            this.BtnMusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMusteriler.ImageOptions.Image")));
            this.BtnMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMusteriler.ImageOptions.LargeImage")));
            this.BtnMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMusteriler_ItemClick);
            // 
            // BtnStok
            // 
            this.BtnStok.Caption = "STOK";
            this.BtnStok.Id = 3;
            this.BtnStok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnStok.ImageOptions.Image")));
            this.BtnStok.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnStok.ImageOptions.LargeImage")));
            this.BtnStok.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnStok.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnStok.Name = "BtnStok";
            // 
            // BtnVeresiye
            // 
            this.BtnVeresiye.Caption = "VERESİYE";
            this.BtnVeresiye.Id = 4;
            this.BtnVeresiye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnVeresiye.ImageOptions.Image")));
            this.BtnVeresiye.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnVeresiye.ImageOptions.LargeImage")));
            this.BtnVeresiye.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnVeresiye.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnVeresiye.Name = "BtnVeresiye";
            this.BtnVeresiye.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // BtnIrsaliye
            // 
            this.BtnIrsaliye.Caption = "İRSALİYE";
            this.BtnIrsaliye.Id = 5;
            this.BtnIrsaliye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnIrsaliye.ImageOptions.Image")));
            this.BtnIrsaliye.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnIrsaliye.ImageOptions.LargeImage")));
            this.BtnIrsaliye.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnIrsaliye.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnIrsaliye.Name = "BtnIrsaliye";
            this.BtnIrsaliye.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnIrsaliye_ItemClick);
            // 
            // BtnAyar
            // 
            this.BtnAyar.Caption = "AYARLAR";
            this.BtnAyar.Id = 6;
            this.BtnAyar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyar.ImageOptions.Image")));
            this.BtnAyar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAyar.ImageOptions.LargeImage")));
            this.BtnAyar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnAyar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAyar.Name = "BtnAyar";
            // 
            // BtnAnasayfa
            // 
            this.BtnAnasayfa.Caption = "ANA MENÜ";
            this.BtnAnasayfa.Id = 7;
            this.BtnAnasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnasayfa.ImageOptions.Image")));
            this.BtnAnasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAnasayfa.ImageOptions.LargeImage")));
            this.BtnAnasayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnAnasayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAnasayfa.Name = "BtnAnasayfa";
            // 
            // BtnGrafikler
            // 
            this.BtnGrafikler.Caption = "GRAFİKLER";
            this.BtnGrafikler.Id = 8;
            this.BtnGrafikler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGrafikler.ImageOptions.Image")));
            this.BtnGrafikler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGrafikler.ImageOptions.LargeImage")));
            this.BtnGrafikler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnGrafikler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnGrafikler.Name = "BtnGrafikler";
            this.BtnGrafikler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGrafikler_ItemClick);
            // 
            // BtnToplualim
            // 
            this.BtnToplualim.Caption = "TOPLU ALIM";
            this.BtnToplualim.Id = 9;
            this.BtnToplualim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnToplualim.ImageOptions.Image")));
            this.BtnToplualim.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnToplualim.ImageOptions.LargeImage")));
            this.BtnToplualim.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnToplualim.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnToplualim.Name = "BtnToplualim";
            // 
            // BtnAlisveris
            // 
            this.BtnAlisveris.Caption = "ALIŞVERİŞ";
            this.BtnAlisveris.Id = 10;
            this.BtnAlisveris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlisveris.ImageOptions.Image")));
            this.BtnAlisveris.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAlisveris.ImageOptions.LargeImage")));
            this.BtnAlisveris.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnAlisveris.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAlisveris.Name = "BtnAlisveris";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "MARKET";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnAnasayfa);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnUrunler);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnMusteriler);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnStok);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnVeresiye);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnIrsaliye);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnToplualim);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnAlisveris);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnGrafikler);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnAyar);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 763);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnUrunler;
        private DevExpress.XtraBars.BarButtonItem BtnMusteriler;
        private DevExpress.XtraBars.BarButtonItem BtnStok;
        private DevExpress.XtraBars.BarButtonItem BtnVeresiye;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnIrsaliye;
        private DevExpress.XtraBars.BarButtonItem BtnAyar;
        private DevExpress.XtraBars.BarButtonItem BtnAnasayfa;
        private DevExpress.XtraBars.BarButtonItem BtnGrafikler;
        private DevExpress.XtraBars.BarButtonItem BtnToplualim;
        private DevExpress.XtraBars.BarButtonItem BtnAlisveris;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

