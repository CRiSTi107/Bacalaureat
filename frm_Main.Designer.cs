namespace BAC_Note
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Resume = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.lbl_Verifications = new System.Windows.Forms.Label();
            this.lnklbl_CRiSTi = new System.Windows.Forms.LinkLabel();
            this.lnklbl_Bac = new System.Windows.Forms.LinkLabel();
            this.lnklbl_BacStatic = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Logo
            // 
            this.pic_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Logo.BackgroundImage = global::BAC_Note.Properties.Resources.iconfinder_Resume_Graduate_2316254;
            this.pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Logo.Location = new System.Drawing.Point(12, 12);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(543, 159);
            this.pic_Logo.TabIndex = 0;
            this.pic_Logo.TabStop = false;
            // 
            // btn_Resume
            // 
            this.btn_Resume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Resume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Resume.Location = new System.Drawing.Point(67, 330);
            this.btn_Resume.Name = "btn_Resume";
            this.btn_Resume.Size = new System.Drawing.Size(119, 23);
            this.btn_Resume.TabIndex = 1;
            this.btn_Resume.Text = "Resume";
            this.btn_Resume.UseVisualStyleBackColor = true;
            this.btn_Resume.Click += new System.EventHandler(this.btn_Resume_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pause.Location = new System.Drawing.Point(383, 330);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(119, 23);
            this.btn_Pause.TabIndex = 2;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // lbl_Verifications
            // 
            this.lbl_Verifications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Verifications.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Verifications.ForeColor = System.Drawing.Color.Green;
            this.lbl_Verifications.Location = new System.Drawing.Point(7, 189);
            this.lbl_Verifications.Name = "lbl_Verifications";
            this.lbl_Verifications.Size = new System.Drawing.Size(548, 120);
            this.lbl_Verifications.TabIndex = 3;
            this.lbl_Verifications.Text = "Am verificat site-ul de 0 ori";
            this.lbl_Verifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnklbl_CRiSTi
            // 
            this.lnklbl_CRiSTi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklbl_CRiSTi.AutoSize = true;
            this.lnklbl_CRiSTi.Location = new System.Drawing.Point(433, 404);
            this.lnklbl_CRiSTi.Name = "lnklbl_CRiSTi";
            this.lnklbl_CRiSTi.Size = new System.Drawing.Size(122, 13);
            this.lnklbl_CRiSTi.TabIndex = 4;
            this.lnklbl_CRiSTi.TabStop = true;
            this.lnklbl_CRiSTi.Text = "Made with ♥ by CRiSTi";
            this.lnklbl_CRiSTi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_CRiSTi_LinkClicked);
            // 
            // lnklbl_Bac
            // 
            this.lnklbl_Bac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklbl_Bac.Location = new System.Drawing.Point(12, 309);
            this.lnklbl_Bac.Name = "lnklbl_Bac";
            this.lnklbl_Bac.Size = new System.Drawing.Size(543, 13);
            this.lnklbl_Bac.TabIndex = 5;
            this.lnklbl_Bac.TabStop = true;
            this.lnklbl_Bac.Text = "bacalaureat.edu.ro";
            this.lnklbl_Bac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnklbl_Bac.Visible = false;
            this.lnklbl_Bac.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_Bac_LinkClicked);
            // 
            // lnklbl_BacStatic
            // 
            this.lnklbl_BacStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklbl_BacStatic.Location = new System.Drawing.Point(12, 328);
            this.lnklbl_BacStatic.Name = "lnklbl_BacStatic";
            this.lnklbl_BacStatic.Size = new System.Drawing.Size(543, 27);
            this.lnklbl_BacStatic.TabIndex = 6;
            this.lnklbl_BacStatic.TabStop = true;
            this.lnklbl_BacStatic.Text = "static.bacalaureat.edu.ro/2020";
            this.lnklbl_BacStatic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnklbl_BacStatic.Visible = false;
            this.lnklbl_BacStatic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_BacStatic_LinkClicked);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 426);
            this.Controls.Add(this.lnklbl_Bac);
            this.Controls.Add(this.lnklbl_CRiSTi);
            this.Controls.Add(this.lbl_Verifications);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Resume);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.lnklbl_BacStatic);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(583, 464);
            this.MinimumSize = new System.Drawing.Size(583, 464);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bacalaureat";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Button btn_Resume;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Label lbl_Verifications;
        private System.Windows.Forms.LinkLabel lnklbl_CRiSTi;
        private System.Windows.Forms.LinkLabel lnklbl_Bac;
        private System.Windows.Forms.LinkLabel lnklbl_BacStatic;
    }
}

