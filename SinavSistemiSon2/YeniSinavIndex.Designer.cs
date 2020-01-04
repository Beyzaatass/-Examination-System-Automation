namespace SinavSistemiSon
{
    partial class YeniSinavIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniSinavIndex));
            this.SoruEkraniPanel = new System.Windows.Forms.Panel();
            this.SoruTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SecenekDRadioButon = new System.Windows.Forms.RadioButton();
            this.SecenekCRadioButon = new System.Windows.Forms.RadioButton();
            this.SecenekBRadioButon = new System.Windows.Forms.RadioButton();
            this.SecenekARadioButon = new System.Windows.Forms.RadioButton();
            this.SoruResimPicBox = new System.Windows.Forms.PictureBox();
            this.ToplamSoruSayisiLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.OlduguSoruSAyisiLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SinavCikisButon = new Bunifu.Framework.UI.BunifuImageButton();
            this.SinavaBaslaButon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SinavBitirButon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.YeniSoruButon = new Bunifu.Framework.UI.BunifuImageButton();
            this.EskiSoruButon = new Bunifu.Framework.UI.BunifuImageButton();
            this.tableAdapterManager1 = new SinavSistemiSon.SinavSistemiDataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ZamanBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.SoruEkraniPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoruResimPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinavCikisButon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YeniSoruButon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EskiSoruButon)).BeginInit();
            this.SuspendLayout();
            // 
            // SoruEkraniPanel
            // 
            this.SoruEkraniPanel.BackColor = System.Drawing.Color.Thistle;
            this.SoruEkraniPanel.Controls.Add(this.SoruTextBox);
            this.SoruEkraniPanel.Controls.Add(this.SecenekDRadioButon);
            this.SoruEkraniPanel.Controls.Add(this.SecenekCRadioButon);
            this.SoruEkraniPanel.Controls.Add(this.SecenekBRadioButon);
            this.SoruEkraniPanel.Controls.Add(this.SecenekARadioButon);
            this.SoruEkraniPanel.Controls.Add(this.SoruResimPicBox);
            this.SoruEkraniPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.SoruEkraniPanel.Location = new System.Drawing.Point(31, 72);
            this.SoruEkraniPanel.Name = "SoruEkraniPanel";
            this.SoruEkraniPanel.Size = new System.Drawing.Size(710, 378);
            this.SoruEkraniPanel.TabIndex = 0;
            // 
            // SoruTextBox
            // 
            this.SoruTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.SoruTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.SoruTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.SoruTextBox.BorderThickness = 3;
            this.SoruTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SoruTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SoruTextBox.Enabled = false;
            this.SoruTextBox.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoruTextBox.ForeColor = System.Drawing.Color.Black;
            this.SoruTextBox.isPassword = false;
            this.SoruTextBox.Location = new System.Drawing.Point(32, 20);
            this.SoruTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SoruTextBox.MaxLength = 32767;
            this.SoruTextBox.Name = "SoruTextBox";
            this.SoruTextBox.Size = new System.Drawing.Size(411, 181);
            this.SoruTextBox.TabIndex = 6;
            this.SoruTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SecenekDRadioButon
            // 
            this.SecenekDRadioButon.AutoSize = true;
            this.SecenekDRadioButon.Location = new System.Drawing.Point(302, 303);
            this.SecenekDRadioButon.Name = "SecenekDRadioButon";
            this.SecenekDRadioButon.Size = new System.Drawing.Size(14, 13);
            this.SecenekDRadioButon.TabIndex = 5;
            this.SecenekDRadioButon.TabStop = true;
            this.SecenekDRadioButon.UseVisualStyleBackColor = true;
            // 
            // SecenekCRadioButon
            // 
            this.SecenekCRadioButon.AutoSize = true;
            this.SecenekCRadioButon.Location = new System.Drawing.Point(82, 303);
            this.SecenekCRadioButon.Name = "SecenekCRadioButon";
            this.SecenekCRadioButon.Size = new System.Drawing.Size(14, 13);
            this.SecenekCRadioButon.TabIndex = 4;
            this.SecenekCRadioButon.TabStop = true;
            this.SecenekCRadioButon.UseVisualStyleBackColor = true;
            // 
            // SecenekBRadioButon
            // 
            this.SecenekBRadioButon.AutoSize = true;
            this.SecenekBRadioButon.Location = new System.Drawing.Point(302, 244);
            this.SecenekBRadioButon.Name = "SecenekBRadioButon";
            this.SecenekBRadioButon.Size = new System.Drawing.Size(14, 13);
            this.SecenekBRadioButon.TabIndex = 3;
            this.SecenekBRadioButon.TabStop = true;
            this.SecenekBRadioButon.UseVisualStyleBackColor = true;
            // 
            // SecenekARadioButon
            // 
            this.SecenekARadioButon.AutoSize = true;
            this.SecenekARadioButon.Location = new System.Drawing.Point(82, 244);
            this.SecenekARadioButon.Name = "SecenekARadioButon";
            this.SecenekARadioButon.Size = new System.Drawing.Size(14, 13);
            this.SecenekARadioButon.TabIndex = 2;
            this.SecenekARadioButon.TabStop = true;
            this.SecenekARadioButon.UseVisualStyleBackColor = true;
            // 
            // SoruResimPicBox
            // 
            this.SoruResimPicBox.Location = new System.Drawing.Point(514, 20);
            this.SoruResimPicBox.Name = "SoruResimPicBox";
            this.SoruResimPicBox.Size = new System.Drawing.Size(136, 125);
            this.SoruResimPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SoruResimPicBox.TabIndex = 1;
            this.SoruResimPicBox.TabStop = false;
            // 
            // ToplamSoruSayisiLbl
            // 
            this.ToplamSoruSayisiLbl.AutoSize = true;
            this.ToplamSoruSayisiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamSoruSayisiLbl.ForeColor = System.Drawing.Color.Thistle;
            this.ToplamSoruSayisiLbl.Location = new System.Drawing.Point(379, 5);
            this.ToplamSoruSayisiLbl.Name = "ToplamSoruSayisiLbl";
            this.ToplamSoruSayisiLbl.Size = new System.Drawing.Size(35, 24);
            this.ToplamSoruSayisiLbl.TabIndex = 7;
            this.ToplamSoruSayisiLbl.Text = "/50";
            // 
            // OlduguSoruSAyisiLbl
            // 
            this.OlduguSoruSAyisiLbl.AutoSize = true;
            this.OlduguSoruSAyisiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OlduguSoruSAyisiLbl.ForeColor = System.Drawing.Color.Thistle;
            this.OlduguSoruSAyisiLbl.Location = new System.Drawing.Point(356, 4);
            this.OlduguSoruSAyisiLbl.Name = "OlduguSoruSAyisiLbl";
            this.OlduguSoruSAyisiLbl.Size = new System.Drawing.Size(20, 24);
            this.OlduguSoruSAyisiLbl.TabIndex = 6;
            this.OlduguSoruSAyisiLbl.Text = "x";
            // 
            // SinavCikisButon
            // 
            this.SinavCikisButon.Image = ((System.Drawing.Image)(resources.GetObject("SinavCikisButon.Image")));
            this.SinavCikisButon.ImageActive = null;
            this.SinavCikisButon.Location = new System.Drawing.Point(736, 1);
            this.SinavCikisButon.Name = "SinavCikisButon";
            this.SinavCikisButon.Size = new System.Drawing.Size(52, 34);
            this.SinavCikisButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SinavCikisButon.TabIndex = 19;
            this.SinavCikisButon.TabStop = false;
            this.SinavCikisButon.Zoom = 10;
            this.SinavCikisButon.Click += new System.EventHandler(this.SinavCikisButon_Click);
            // 
            // SinavaBaslaButon
            // 
            this.SinavaBaslaButon.Active = false;
            this.SinavaBaslaButon.Activecolor = System.Drawing.Color.Transparent;
            this.SinavaBaslaButon.BackColor = System.Drawing.Color.Thistle;
            this.SinavaBaslaButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SinavaBaslaButon.BorderRadius = 0;
            this.SinavaBaslaButon.ButtonText = "Sınava Başla";
            this.SinavaBaslaButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SinavaBaslaButon.DisabledColor = System.Drawing.Color.Gray;
            this.SinavaBaslaButon.Iconcolor = System.Drawing.Color.Transparent;
            this.SinavaBaslaButon.Iconimage = ((System.Drawing.Image)(resources.GetObject("SinavaBaslaButon.Iconimage")));
            this.SinavaBaslaButon.Iconimage_right = null;
            this.SinavaBaslaButon.Iconimage_right_Selected = null;
            this.SinavaBaslaButon.Iconimage_Selected = null;
            this.SinavaBaslaButon.IconMarginLeft = 0;
            this.SinavaBaslaButon.IconMarginRight = 0;
            this.SinavaBaslaButon.IconRightVisible = true;
            this.SinavaBaslaButon.IconRightZoom = 0D;
            this.SinavaBaslaButon.IconVisible = true;
            this.SinavaBaslaButon.IconZoom = 90D;
            this.SinavaBaslaButon.IsTab = false;
            this.SinavaBaslaButon.Location = new System.Drawing.Point(204, 461);
            this.SinavaBaslaButon.Name = "SinavaBaslaButon";
            this.SinavaBaslaButon.Normalcolor = System.Drawing.Color.Thistle;
            this.SinavaBaslaButon.OnHovercolor = System.Drawing.Color.Thistle;
            this.SinavaBaslaButon.OnHoverTextColor = System.Drawing.Color.White;
            this.SinavaBaslaButon.selected = false;
            this.SinavaBaslaButon.Size = new System.Drawing.Size(108, 48);
            this.SinavaBaslaButon.TabIndex = 23;
            this.SinavaBaslaButon.Text = "Sınava Başla";
            this.SinavaBaslaButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SinavaBaslaButon.Textcolor = System.Drawing.Color.Black;
            this.SinavaBaslaButon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinavaBaslaButon.Click += new System.EventHandler(this.SinavaBaslaButon_Click);
            // 
            // SinavBitirButon
            // 
            this.SinavBitirButon.Active = false;
            this.SinavBitirButon.Activecolor = System.Drawing.Color.Transparent;
            this.SinavBitirButon.BackColor = System.Drawing.Color.Thistle;
            this.SinavBitirButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SinavBitirButon.BorderRadius = 0;
            this.SinavBitirButon.ButtonText = "Sınavı Bitir";
            this.SinavBitirButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SinavBitirButon.DisabledColor = System.Drawing.Color.Gray;
            this.SinavBitirButon.Iconcolor = System.Drawing.Color.Transparent;
            this.SinavBitirButon.Iconimage = ((System.Drawing.Image)(resources.GetObject("SinavBitirButon.Iconimage")));
            this.SinavBitirButon.Iconimage_right = null;
            this.SinavBitirButon.Iconimage_right_Selected = null;
            this.SinavBitirButon.Iconimage_Selected = null;
            this.SinavBitirButon.IconMarginLeft = 0;
            this.SinavBitirButon.IconMarginRight = 0;
            this.SinavBitirButon.IconRightVisible = true;
            this.SinavBitirButon.IconRightZoom = 0D;
            this.SinavBitirButon.IconVisible = true;
            this.SinavBitirButon.IconZoom = 90D;
            this.SinavBitirButon.IsTab = false;
            this.SinavBitirButon.Location = new System.Drawing.Point(333, 461);
            this.SinavBitirButon.Name = "SinavBitirButon";
            this.SinavBitirButon.Normalcolor = System.Drawing.Color.Thistle;
            this.SinavBitirButon.OnHovercolor = System.Drawing.Color.Thistle;
            this.SinavBitirButon.OnHoverTextColor = System.Drawing.Color.White;
            this.SinavBitirButon.selected = false;
            this.SinavBitirButon.Size = new System.Drawing.Size(130, 48);
            this.SinavBitirButon.TabIndex = 22;
            this.SinavBitirButon.Text = "Sınavı Bitir";
            this.SinavBitirButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SinavBitirButon.Textcolor = System.Drawing.Color.Black;
            this.SinavBitirButon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinavBitirButon.Click += new System.EventHandler(this.SinavBitirButon_Click);
            // 
            // YeniSoruButon
            // 
            this.YeniSoruButon.Enabled = false;
            this.YeniSoruButon.Image = ((System.Drawing.Image)(resources.GetObject("YeniSoruButon.Image")));
            this.YeniSoruButon.ImageActive = null;
            this.YeniSoruButon.Location = new System.Drawing.Point(726, 468);
            this.YeniSoruButon.Name = "YeniSoruButon";
            this.YeniSoruButon.Size = new System.Drawing.Size(44, 47);
            this.YeniSoruButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YeniSoruButon.TabIndex = 21;
            this.YeniSoruButon.TabStop = false;
            this.YeniSoruButon.Zoom = 10;
            this.YeniSoruButon.Click += new System.EventHandler(this.YeniSoruButon_Click);
            // 
            // EskiSoruButon
            // 
            this.EskiSoruButon.Image = ((System.Drawing.Image)(resources.GetObject("EskiSoruButon.Image")));
            this.EskiSoruButon.ImageActive = null;
            this.EskiSoruButon.Location = new System.Drawing.Point(5, 468);
            this.EskiSoruButon.Name = "EskiSoruButon";
            this.EskiSoruButon.Size = new System.Drawing.Size(44, 47);
            this.EskiSoruButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EskiSoruButon.TabIndex = 20;
            this.EskiSoruButon.TabStop = false;
            this.EskiSoruButon.Zoom = 10;
            this.EskiSoruButon.Click += new System.EventHandler(this.EskiSoruButon_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.Tbl_KategorilerTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = SinavSistemiSon.SinavSistemiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ZamanBar
            // 
            this.ZamanBar.BackColor = System.Drawing.Color.Silver;
            this.ZamanBar.BorderRadius = 5;
            this.ZamanBar.Location = new System.Drawing.Point(5, 39);
            this.ZamanBar.MaximumValue = 600;
            this.ZamanBar.Name = "ZamanBar";
            this.ZamanBar.ProgressColor = System.Drawing.Color.Teal;
            this.ZamanBar.Size = new System.Drawing.Size(765, 10);
            this.ZamanBar.TabIndex = 24;
            this.ZamanBar.Value = 0;
            // 
            // YeniSinavIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(780, 521);
            this.Controls.Add(this.ZamanBar);
            this.Controls.Add(this.SinavaBaslaButon);
            this.Controls.Add(this.SinavBitirButon);
            this.Controls.Add(this.YeniSoruButon);
            this.Controls.Add(this.EskiSoruButon);
            this.Controls.Add(this.SinavCikisButon);
            this.Controls.Add(this.ToplamSoruSayisiLbl);
            this.Controls.Add(this.OlduguSoruSAyisiLbl);
            this.Controls.Add(this.SoruEkraniPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YeniSinavIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniSinavIndex";
            this.Load += new System.EventHandler(this.YeniSinavIndex_Load);
            this.SoruEkraniPanel.ResumeLayout(false);
            this.SoruEkraniPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoruResimPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinavCikisButon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YeniSoruButon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EskiSoruButon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SoruEkraniPanel;
        private System.Windows.Forms.RadioButton SecenekDRadioButon;
        private System.Windows.Forms.RadioButton SecenekCRadioButon;
        private System.Windows.Forms.RadioButton SecenekBRadioButon;
        private System.Windows.Forms.RadioButton SecenekARadioButon;
        private System.Windows.Forms.PictureBox SoruResimPicBox;
        private Bunifu.Framework.UI.BunifuCustomLabel ToplamSoruSayisiLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel OlduguSoruSAyisiLbl;
        private Bunifu.Framework.UI.BunifuImageButton SinavCikisButon;
        private Bunifu.Framework.UI.BunifuFlatButton SinavaBaslaButon;
        private Bunifu.Framework.UI.BunifuFlatButton SinavBitirButon;
        private Bunifu.Framework.UI.BunifuImageButton YeniSoruButon;
        private Bunifu.Framework.UI.BunifuImageButton EskiSoruButon;
        private SinavSistemiDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private Bunifu.Framework.UI.BunifuMetroTextbox SoruTextBox;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuProgressBar ZamanBar;
    }
}