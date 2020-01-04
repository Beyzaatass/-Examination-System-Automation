namespace SinavSistemiSon
{
    partial class LoginIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginIndex));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LoginSifreTestBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LoginAdTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LoginGirisButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LoginOgretmenRadioButon = new System.Windows.Forms.RadioButton();
            this.LoginOgrenciRadioButon = new System.Windows.Forms.RadioButton();
            this.LoginResimPicBox = new System.Windows.Forms.PictureBox();
            this.LoginCikisButon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginResimPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginCikisButon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LoginSifreTestBox
            // 
            this.LoginSifreTestBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LoginSifreTestBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LoginSifreTestBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LoginSifreTestBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LoginSifreTestBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginSifreTestBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LoginSifreTestBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginSifreTestBox.HintForeColor = System.Drawing.Color.Empty;
            this.LoginSifreTestBox.HintText = "";
            this.LoginSifreTestBox.isPassword = true;
            this.LoginSifreTestBox.LineFocusedColor = System.Drawing.Color.Purple;
            this.LoginSifreTestBox.LineIdleColor = System.Drawing.Color.Gray;
            this.LoginSifreTestBox.LineMouseHoverColor = System.Drawing.Color.Purple;
            this.LoginSifreTestBox.LineThickness = 3;
            this.LoginSifreTestBox.Location = new System.Drawing.Point(41, 234);
            this.LoginSifreTestBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginSifreTestBox.MaxLength = 32767;
            this.LoginSifreTestBox.Name = "LoginSifreTestBox";
            this.LoginSifreTestBox.Size = new System.Drawing.Size(324, 33);
            this.LoginSifreTestBox.TabIndex = 21;
            this.LoginSifreTestBox.Text = "12345678";
            this.LoginSifreTestBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LoginAdTextBox
            // 
            this.LoginAdTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LoginAdTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LoginAdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LoginAdTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LoginAdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginAdTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LoginAdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginAdTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.LoginAdTextBox.HintText = "";
            this.LoginAdTextBox.isPassword = false;
            this.LoginAdTextBox.LineFocusedColor = System.Drawing.Color.Purple;
            this.LoginAdTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.LoginAdTextBox.LineMouseHoverColor = System.Drawing.Color.Purple;
            this.LoginAdTextBox.LineThickness = 3;
            this.LoginAdTextBox.Location = new System.Drawing.Point(41, 180);
            this.LoginAdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginAdTextBox.MaxLength = 32767;
            this.LoginAdTextBox.Name = "LoginAdTextBox";
            this.LoginAdTextBox.Size = new System.Drawing.Size(324, 33);
            this.LoginAdTextBox.TabIndex = 20;
            this.LoginAdTextBox.Text = "ecemz";
            this.LoginAdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LoginGirisButon
            // 
            this.LoginGirisButon.ActiveBorderThickness = 1;
            this.LoginGirisButon.ActiveCornerRadius = 20;
            this.LoginGirisButon.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LoginGirisButon.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LoginGirisButon.ActiveLineColor = System.Drawing.Color.Purple;
            this.LoginGirisButon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginGirisButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginGirisButon.BackgroundImage")));
            this.LoginGirisButon.ButtonText = "GİRİŞ YAP";
            this.LoginGirisButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginGirisButon.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginGirisButon.ForeColor = System.Drawing.Color.Black;
            this.LoginGirisButon.IdleBorderThickness = 1;
            this.LoginGirisButon.IdleCornerRadius = 20;
            this.LoginGirisButon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LoginGirisButon.IdleForecolor = System.Drawing.Color.Black;
            this.LoginGirisButon.IdleLineColor = System.Drawing.Color.Purple;
            this.LoginGirisButon.Location = new System.Drawing.Point(41, 347);
            this.LoginGirisButon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LoginGirisButon.Name = "LoginGirisButon";
            this.LoginGirisButon.Size = new System.Drawing.Size(324, 58);
            this.LoginGirisButon.TabIndex = 22;
            this.LoginGirisButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginGirisButon.Click += new System.EventHandler(this.LoginGirisButon_Click);
            // 
            // LoginOgretmenRadioButon
            // 
            this.LoginOgretmenRadioButon.AutoSize = true;
            this.LoginOgretmenRadioButon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginOgretmenRadioButon.Location = new System.Drawing.Point(108, 297);
            this.LoginOgretmenRadioButon.Name = "LoginOgretmenRadioButon";
            this.LoginOgretmenRadioButon.Size = new System.Drawing.Size(81, 19);
            this.LoginOgretmenRadioButon.TabIndex = 23;
            this.LoginOgretmenRadioButon.Text = "Öğretmen";
            this.LoginOgretmenRadioButon.UseVisualStyleBackColor = true;
            // 
            // LoginOgrenciRadioButon
            // 
            this.LoginOgrenciRadioButon.AutoSize = true;
            this.LoginOgrenciRadioButon.Checked = true;
            this.LoginOgrenciRadioButon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginOgrenciRadioButon.Location = new System.Drawing.Point(213, 297);
            this.LoginOgrenciRadioButon.Name = "LoginOgrenciRadioButon";
            this.LoginOgrenciRadioButon.Size = new System.Drawing.Size(71, 19);
            this.LoginOgrenciRadioButon.TabIndex = 24;
            this.LoginOgrenciRadioButon.TabStop = true;
            this.LoginOgrenciRadioButon.Text = "Öğrenci";
            this.LoginOgrenciRadioButon.UseVisualStyleBackColor = true;
            // 
            // LoginResimPicBox
            // 
            this.LoginResimPicBox.Image = ((System.Drawing.Image)(resources.GetObject("LoginResimPicBox.Image")));
            this.LoginResimPicBox.Location = new System.Drawing.Point(153, 52);
            this.LoginResimPicBox.Name = "LoginResimPicBox";
            this.LoginResimPicBox.Size = new System.Drawing.Size(95, 87);
            this.LoginResimPicBox.TabIndex = 25;
            this.LoginResimPicBox.TabStop = false;
            // 
            // LoginCikisButon
            // 
            this.LoginCikisButon.Image = ((System.Drawing.Image)(resources.GetObject("LoginCikisButon.Image")));
            this.LoginCikisButon.Location = new System.Drawing.Point(379, 1);
            this.LoginCikisButon.Name = "LoginCikisButon";
            this.LoginCikisButon.Size = new System.Drawing.Size(28, 26);
            this.LoginCikisButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginCikisButon.TabIndex = 26;
            this.LoginCikisButon.TabStop = false;
            this.LoginCikisButon.Click += new System.EventHandler(this.LoginCikisButon_Click);
            // 
            // LoginIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 481);
            this.Controls.Add(this.LoginCikisButon);
            this.Controls.Add(this.LoginResimPicBox);
            this.Controls.Add(this.LoginOgrenciRadioButon);
            this.Controls.Add(this.LoginOgretmenRadioButon);
            this.Controls.Add(this.LoginGirisButon);
            this.Controls.Add(this.LoginSifreTestBox);
            this.Controls.Add(this.LoginAdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LoginResimPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginCikisButon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox LoginResimPicBox;
        private System.Windows.Forms.RadioButton LoginOgrenciRadioButon;
        private System.Windows.Forms.RadioButton LoginOgretmenRadioButon;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginGirisButon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LoginSifreTestBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LoginAdTextBox;
        private System.Windows.Forms.PictureBox LoginCikisButon;
    }
}

