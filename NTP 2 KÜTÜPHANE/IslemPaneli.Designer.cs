namespace NTP_2_KÜTÜPHANE
{
    partial class IslemPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listeSilbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.ekleKitapbtn = new System.Windows.Forms.Button();
            this.verKitapbtn = new System.Windows.Forms.Button();
            this.ekleKullanicibtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listeSilbtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.ekleKitapbtn);
            this.panel1.Controls.Add(this.verKitapbtn);
            this.panel1.Controls.Add(this.ekleKullanicibtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 623);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listeSilbtn
            // 
            this.listeSilbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listeSilbtn.Image = ((System.Drawing.Image)(resources.GetObject("listeSilbtn.Image")));
            this.listeSilbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listeSilbtn.Location = new System.Drawing.Point(-1, 375);
            this.listeSilbtn.Name = "listeSilbtn";
            this.listeSilbtn.Size = new System.Drawing.Size(192, 88);
            this.listeSilbtn.TabIndex = 9;
            this.listeSilbtn.Text = "Öğrenci Listesi / Sil";
            this.listeSilbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listeSilbtn.UseVisualStyleBackColor = false;
            this.listeSilbtn.Click += new System.EventHandler(this.listeSilbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(85, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saat:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-1, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 88);
            this.button5.TabIndex = 6;
            this.button5.Text = "                           İçerikler";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ekleKitapbtn
            // 
            this.ekleKitapbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.ekleKitapbtn.Image = ((System.Drawing.Image)(resources.GetObject("ekleKitapbtn.Image")));
            this.ekleKitapbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleKitapbtn.Location = new System.Drawing.Point(-1, 187);
            this.ekleKitapbtn.Name = "ekleKitapbtn";
            this.ekleKitapbtn.Size = new System.Drawing.Size(192, 88);
            this.ekleKitapbtn.TabIndex = 5;
            this.ekleKitapbtn.Text = "                           Kitap Ekle";
            this.ekleKitapbtn.UseVisualStyleBackColor = false;
            this.ekleKitapbtn.Click += new System.EventHandler(this.ekleKitapbtn_Click);
            // 
            // verKitapbtn
            // 
            this.verKitapbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.verKitapbtn.Image = ((System.Drawing.Image)(resources.GetObject("verKitapbtn.Image")));
            this.verKitapbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verKitapbtn.Location = new System.Drawing.Point(-1, 281);
            this.verKitapbtn.Name = "verKitapbtn";
            this.verKitapbtn.Size = new System.Drawing.Size(192, 88);
            this.verKitapbtn.TabIndex = 4;
            this.verKitapbtn.Text = "                           Kitap Ver";
            this.verKitapbtn.UseVisualStyleBackColor = false;
            this.verKitapbtn.Click += new System.EventHandler(this.verKitapbtn_Click);
            // 
            // ekleKullanicibtn
            // 
            this.ekleKullanicibtn.BackColor = System.Drawing.SystemColors.Menu;
            this.ekleKullanicibtn.Image = ((System.Drawing.Image)(resources.GetObject("ekleKullanicibtn.Image")));
            this.ekleKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleKullanicibtn.Location = new System.Drawing.Point(-1, 93);
            this.ekleKullanicibtn.Name = "ekleKullanicibtn";
            this.ekleKullanicibtn.Size = new System.Drawing.Size(192, 88);
            this.ekleKullanicibtn.TabIndex = 3;
            this.ekleKullanicibtn.Text = "                           Öğrenci Ekle";
            this.ekleKullanicibtn.UseVisualStyleBackColor = false;
            this.ekleKullanicibtn.Click += new System.EventHandler(this.ekleKullanicibtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(192, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 76);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kütüphane Bilgi Sistemi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Wheat;
            this.button1.Location = new System.Drawing.Point(854, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IslemPaneli
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1116, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "IslemPaneli";
            this.Text = "IslemPaneli";
            this.Load += new System.EventHandler(this.IslemPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ekleKullanicibtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ekleKitapbtn;
        private System.Windows.Forms.Button verKitapbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button listeSilbtn;
    }
}