namespace SinavSis
{
    partial class OgretmenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buton3 = new System.Windows.Forms.Button();
            this.buton2 = new System.Windows.Forms.Button();
            this.buton1 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.soruEkle1 = new SinavSis.SoruEkle();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.buton3);
            this.panel1.Controls.Add(this.buton2);
            this.panel1.Controls.Add(this.buton1);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.pictureEdit2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 420);
            this.panel1.TabIndex = 1;
            // 
            // buton3
            // 
            this.buton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buton3.FlatAppearance.BorderSize = 0;
            this.buton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton3.ForeColor = System.Drawing.SystemColors.Control;
            this.buton3.Image = ((System.Drawing.Image)(resources.GetObject("buton3.Image")));
            this.buton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buton3.Location = new System.Drawing.Point(12, 312);
            this.buton3.Name = "buton3";
            this.buton3.Size = new System.Drawing.Size(170, 98);
            this.buton3.TabIndex = 10;
            this.buton3.Text = "Ana Menüye Dön";
            this.buton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton3.UseVisualStyleBackColor = true;
            this.buton3.Click += new System.EventHandler(this.buton3_Click);
            // 
            // buton2
            // 
            this.buton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buton2.FlatAppearance.BorderSize = 0;
            this.buton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton2.ForeColor = System.Drawing.SystemColors.Control;
            this.buton2.Image = ((System.Drawing.Image)(resources.GetObject("buton2.Image")));
            this.buton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buton2.Location = new System.Drawing.Point(13, 224);
            this.buton2.Name = "buton2";
            this.buton2.Size = new System.Drawing.Size(170, 98);
            this.buton2.TabIndex = 9;
            this.buton2.Text = "Soru Ekle";
            this.buton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton2.UseVisualStyleBackColor = true;
            this.buton2.Click += new System.EventHandler(this.buton2_Click);
            // 
            // buton1
            // 
            this.buton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buton1.FlatAppearance.BorderSize = 0;
            this.buton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton1.ForeColor = System.Drawing.SystemColors.Control;
            this.buton1.Image = ((System.Drawing.Image)(resources.GetObject("buton1.Image")));
            this.buton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buton1.Location = new System.Drawing.Point(12, 120);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(168, 98);
            this.buton1.TabIndex = 8;
            this.buton1.Text = "Anasayfa";
            this.buton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton1.UseVisualStyleBackColor = true;
            this.buton1.Click += new System.EventHandler(this.buton1_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Crimson;
            this.SidePanel.Location = new System.Drawing.Point(0, 120);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 98);
            this.SidePanel.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(154, 15);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "From the procuders of GelGit";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(0, 48);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(182, 72);
            this.pictureEdit2.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 42);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(679, -4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 46);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(286, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(240, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Öğretmen Ekranı";
            // 
            // soruEkle1
            // 
            this.soruEkle1.Location = new System.Drawing.Point(183, 42);
            this.soruEkle1.Name = "soruEkle1";
            this.soruEkle1.Size = new System.Drawing.Size(731, 488);
            this.soruEkle1.TabIndex = 3;
            // 
            // OgretmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 420);
            this.Controls.Add(this.soruEkle1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgretmenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.OgretmenForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buton3;
        private System.Windows.Forms.Button buton2;
        private System.Windows.Forms.Button buton1;
        private System.Windows.Forms.Panel SidePanel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private SoruEkle soruEkle1;
    }
}