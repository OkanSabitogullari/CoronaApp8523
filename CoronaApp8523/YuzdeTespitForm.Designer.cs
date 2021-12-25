
namespace CoronaApp8523
{
    partial class YuzdeTespitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.cbBogaz = new System.Windows.Forms.CheckBox();
            this.cbOksuruk = new System.Windows.Forms.CheckBox();
            this.cbAtes = new System.Windows.Forms.CheckBox();
            this.bTespitEt = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.gbRapor = new System.Windows.Forms.GroupBox();
            this.rtbRapor = new System.Windows.Forms.RichTextBox();
            this.bRapor = new System.Windows.Forms.Button();
            this.gbRapor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdSoyad.Location = new System.Drawing.Point(60, 6);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(179, 26);
            this.tbAdSoyad.TabIndex = 1;
            // 
            // cbBogaz
            // 
            this.cbBogaz.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbBogaz.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBogaz.Location = new System.Drawing.Point(25, 107);
            this.cbBogaz.Name = "cbBogaz";
            this.cbBogaz.Size = new System.Drawing.Size(104, 24);
            this.cbBogaz.TabIndex = 5;
            this.cbBogaz.Text = "Boğaz Ağrısı";
            this.cbBogaz.UseVisualStyleBackColor = true;
            // 
            // cbOksuruk
            // 
            this.cbOksuruk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOksuruk.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOksuruk.Location = new System.Drawing.Point(25, 77);
            this.cbOksuruk.Name = "cbOksuruk";
            this.cbOksuruk.Size = new System.Drawing.Size(104, 24);
            this.cbOksuruk.TabIndex = 4;
            this.cbOksuruk.Text = "Öksürük";
            this.cbOksuruk.UseVisualStyleBackColor = true;
            // 
            // cbAtes
            // 
            this.cbAtes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAtes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAtes.Location = new System.Drawing.Point(25, 47);
            this.cbAtes.Name = "cbAtes";
            this.cbAtes.Size = new System.Drawing.Size(104, 24);
            this.cbAtes.TabIndex = 3;
            this.cbAtes.Text = "Ateş";
            this.cbAtes.UseVisualStyleBackColor = true;
            // 
            // bTespitEt
            // 
            this.bTespitEt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTespitEt.Location = new System.Drawing.Point(25, 137);
            this.bTespitEt.Name = "bTespitEt";
            this.bTespitEt.Size = new System.Drawing.Size(104, 36);
            this.bTespitEt.TabIndex = 6;
            this.bTespitEt.Text = "Tespit Et";
            this.bTespitEt.UseVisualStyleBackColor = true;
            this.bTespitEt.Click += new System.EventHandler(this.bTespitEt_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTemizle.Location = new System.Drawing.Point(135, 137);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(104, 36);
            this.bTemizle.TabIndex = 7;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.Location = new System.Drawing.Point(25, 190);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(359, 251);
            this.lbSonuc.TabIndex = 8;
            // 
            // gbRapor
            // 
            this.gbRapor.Controls.Add(this.rtbRapor);
            this.gbRapor.Location = new System.Drawing.Point(405, 12);
            this.gbRapor.Name = "gbRapor";
            this.gbRapor.Size = new System.Drawing.Size(383, 426);
            this.gbRapor.TabIndex = 9;
            this.gbRapor.TabStop = false;
            this.gbRapor.Text = "Rapor";
            this.gbRapor.Visible = false;
            // 
            // rtbRapor
            // 
            this.rtbRapor.Location = new System.Drawing.Point(6, 23);
            this.rtbRapor.Name = "rtbRapor";
            this.rtbRapor.Size = new System.Drawing.Size(371, 397);
            this.rtbRapor.TabIndex = 0;
            this.rtbRapor.Text = "";
            // 
            // bRapor
            // 
            this.bRapor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bRapor.Location = new System.Drawing.Point(245, 137);
            this.bRapor.Name = "bRapor";
            this.bRapor.Size = new System.Drawing.Size(104, 36);
            this.bRapor.TabIndex = 10;
            this.bRapor.Text = "Rapor";
            this.bRapor.UseVisualStyleBackColor = true;
            this.bRapor.Click += new System.EventHandler(this.bRapor_Click);
            // 
            // YuzdeTespitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRapor);
            this.Controls.Add(this.gbRapor);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bTespitEt);
            this.Controls.Add(this.cbBogaz);
            this.Controls.Add(this.cbOksuruk);
            this.Controls.Add(this.cbAtes);
            this.Controls.Add(this.tbAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "YuzdeTespitForm";
            this.Text = "YüzdeTespit";
            this.gbRapor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.CheckBox cbBogaz;
        private System.Windows.Forms.CheckBox cbOksuruk;
        private System.Windows.Forms.CheckBox cbAtes;
        private System.Windows.Forms.Button bTespitEt;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.GroupBox gbRapor;
        private System.Windows.Forms.RichTextBox rtbRapor;
        private System.Windows.Forms.Button bRapor;
    }
}